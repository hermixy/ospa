// OSPA ProgDev
// Copyright (C) 2014 Brian Luft
// 
// This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public 
// License as published by the Free Software Foundation; either version 2 of the License, or (at your option) any later
// version.
// 
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied 
// warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more 
// details.
// 
// You should have received a copy of the GNU General Public License along with this program; if not, write to the Free
// Software Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301, USA.

module ProgDev.BusinessLogic.Project
open ProgDev.Domain
open ProgDev.Services
open ProgDev.Services.Utility
open ProgDev.Resources
open System

type File (folder, name, pouType, pouLanguage) =
   member this.Folder : string = folder
   member this.Name : string = name // No file extension, just the name portion
   member this.Type : PouType = pouType
   member this.Language : PouLanguage = pouLanguage

   member this.ToNewFilename (name : string) : string =
      let languageExt = FileExtensions.GetLanguageExtension this.Language
      let typeExt = FileExtensions.GetTypeExtension this.Type
      name + "." + languageExt + "." + typeExt

   member this.ToFilename () : string =
      this.ToNewFilename this.Name

let ToFile (x : BundleFile) : File =
   let dottedParts = x.Filename.Split('.')
   if dottedParts.Length <> 3 then failwith Strings.ErrorMalformedFilename
   let name = dottedParts.[0]
   let pouLanguage = FileExtensions.ParseLanguageExtension dottedParts.[1]
   let pouType = FileExtensions.ParseTypeExtension dottedParts.[2]
   new File(x.Folder, name, pouType, pouLanguage)

(*********************************************************************************************************************)
let mutable private _FilePath : string option = None
let private _ChangedEvent = new DelegateEvent<System.Action>()
let private Notify () = _ChangedEvent.Trigger([| |])

(*********************************************************************************************************************)
module private BundleManager =
   let mutable private _Bundle : Bundle = { Files = [] }
   let mutable private _Dirty : bool = false
   let mutable private _UndoStack = [] : Bundle list
   let mutable private _RedoStack = [] : Bundle list
  
   // Read-only access
   let Bundle () = _Bundle
   let IsDirty () = _Dirty

   let CanUndo () = not _UndoStack.IsEmpty
   let CanRedo () = not _RedoStack.IsEmpty

   let Do (action : Bundle -> Bundle) =
      _UndoStack <- List.Cons(_Bundle, _UndoStack)
      if _UndoStack.Length > 100 then
         _UndoStack <- _UndoStack |> List.toSeq |> Seq.take 100 |> Seq.toList
      _RedoStack <- []
      _Bundle <- action _Bundle
      _Dirty <- true
      Notify()

   let Undo () =
      if _UndoStack.IsEmpty then ()
      else
         _RedoStack <- List.Cons(_Bundle, _RedoStack)
         _Bundle <- _UndoStack.Head
         _UndoStack <- _UndoStack.Tail
         _Dirty <- true
         Notify()
   
   let Redo () =
      if _RedoStack.IsEmpty then ()
      else
         _UndoStack <- List.Cons(_Bundle, _UndoStack)
         _Bundle <- _RedoStack.Head
         _RedoStack <- _RedoStack.Tail
         _Dirty <- true
         Notify()

   let New () =
      _FilePath <- None
      _Bundle <- { Files = [] }
      _UndoStack <- []
      _RedoStack <- []
      _Dirty <- false
      Notify()

   let Load (filePath : string) =
      _Bundle <- Bundler.Load filePath
      _FilePath <- Some filePath
      _UndoStack <- []
      _RedoStack <- []
      _Dirty <- false
      Notify()

   let Save (filePath : string) =
      Bundler.Save _Bundle filePath
      _FilePath <- Some filePath
      _Dirty <- false
      Notify()

(*********************************************************************************************************************)
type ProjectEvents () =
   [<CLIEvent>]
   member this.Changed = _ChangedEvent.Publish

type ProjectContents () =
   member this.Folders
      with get () = 
         BundleManager.Bundle().Files
         |> List.toSeq 
         |> Seq.map (fun x -> x.Folder)
         |> Seq.distinct
         |> Seq.sort

   member this.Files
      with get () = 
         BundleManager.Bundle().Files 
         |> List.toSeq 
         |> Seq.map ToFile
         |> Seq.sortBy (fun x -> x.Folder)

   member this.FilePath
      with get () =
         match _FilePath with
         | Some x -> x
         | None -> null

   member this.ProjectName
      with get () =
         match _FilePath with
         | Some x -> System.IO.Path.GetFileNameWithoutExtension x
         | None -> Strings.Untitled

   member this.IsDirty
      with get () = BundleManager.IsDirty()

let Events = new ProjectEvents()

let Contents = new ProjectContents()

(*********************************************************************************************************************)
let New () = BundleManager.New()
let Load (filePath : string) = BundleManager.Load filePath
let Save (filePath : string) = BundleManager.Save filePath

(*********************************************************************************************************************)
module private FileOperations =
   let private ToNamePart (filename : string) : string = filename.Split('.').[0]

   let private GetBundleFile (folder : string) (name : string) (bundle : Bundle) =
      bundle.Files 
      |> List.toSeq 
      |> Seq.filter (fun x -> (ToNamePart x.Filename) =? name && x.Folder =? folder) 
      |> Seq.exactlyOne

   let private CheckFileDoesNotExist folder name bundle =
      if bundle.Files |> List.exists (fun x -> (ToNamePart x.Filename) =? name && x.Folder =? folder) 
         then failwith (String.Format(Strings.ErrorFileExists, name, folder))

   let private GetTemplate (pouType : PouType, pouLanguage : PouLanguage) =
      match (pouLanguage, pouType) with
      | PouLanguage.FunctionBlockDiagram, PouType.Class -> FileTemplates.FbdClass
      | PouLanguage.FunctionBlockDiagram, PouType.FunctionBlock -> FileTemplates.FbdBlock
      | PouLanguage.FunctionBlockDiagram, PouType.Function -> FileTemplates.FbdFunction
      | PouLanguage.FunctionBlockDiagram, PouType.Program -> FileTemplates.FbdProgram
      | PouLanguage.InstructionList, PouType.Class -> FileTemplates.IlClass
      | PouLanguage.InstructionList, PouType.FunctionBlock -> FileTemplates.IlBlock
      | PouLanguage.InstructionList, PouType.Function -> FileTemplates.IlFunction
      | PouLanguage.InstructionList, PouType.Program -> FileTemplates.IlProgram
      | PouLanguage.LadderDiagram, PouType.Class -> FileTemplates.LdClass
      | PouLanguage.LadderDiagram, PouType.FunctionBlock -> FileTemplates.LdBlock
      | PouLanguage.LadderDiagram, PouType.Function -> FileTemplates.LdFunction
      | PouLanguage.LadderDiagram, PouType.Program -> FileTemplates.LdProgram
      | PouLanguage.SequentialFunctionChart, PouType.FunctionBlock -> FileTemplates.SfcBlock
      | PouLanguage.SequentialFunctionChart, PouType.Program -> FileTemplates.SfcProgram
      | PouLanguage.StructuredText, PouType.Class -> FileTemplates.StClass
      | PouLanguage.StructuredText, PouType.FunctionBlock -> FileTemplates.StBlock
      | PouLanguage.StructuredText, PouType.Function -> FileTemplates.StFunction
      | PouLanguage.StructuredText, PouType.GlobalVars -> FileTemplates.StVariables
      | PouLanguage.StructuredText, PouType.Interface -> FileTemplates.StInterface
      | PouLanguage.StructuredText, PouType.Program -> FileTemplates.StProgram
      | PouLanguage.StructuredText, PouType.DataType -> FileTemplates.StDataType
      | _ -> failwith Strings.ErrorInvalidTypeLanguageCombo

   let private GetTemplateString (pouType : PouType, pouLanguage : PouLanguage) =
      GetTemplate(pouType, pouLanguage) |> System.Text.Encoding.UTF8.GetString

   let NewFile (folder : string) (name : string) (pouType : PouType) (pouLanguage : PouLanguage) (bundle : Bundle) =
      CheckFileDoesNotExist folder name bundle
      let parts = [name; FileExtensions.GetLanguageExtension pouLanguage; FileExtensions.GetTypeExtension pouType]
      let filename = String.Join(".", parts)
      let content = GetTemplateString(pouType, pouLanguage)
      let newFile : BundleFile = { Folder = folder; Filename = filename; Content = content; }
      let files = List.Cons(newFile, bundle.Files)
      { Files = files }

   let RenameFile (file : File) (newName : string) (bundle : Bundle) =
      CheckFileDoesNotExist file.Folder newName bundle
      let oldFile = GetBundleFile file.Folder file.Name bundle
      let newFilename = file.ToNewFilename newName
      let newFile = { Folder = oldFile.Folder; Filename = newFilename; Content = oldFile.Content } : BundleFile
      let files = bundle.Files |> List.map (fun x -> if x = oldFile then newFile else x) 
      { Files = files }

   let MoveFiles (namePaths : (string * string) list) (newFolder : string) (bundle : Bundle) =
      // namePaths = list of (folder, name without extension)
      let files = bundle.Files |> List.map (fun x ->
         CheckFileDoesNotExist newFolder (ToNamePart x.Filename) bundle
         let namePath = (x.Folder, ToNamePart x.Filename)
         if namePaths |> List.exists (fun y -> y = namePath) then
            // This is one of the files being moved.
            { Folder = newFolder; Filename = x.Filename; Content = x.Filename } : BundleFile
         else x)
      { Files = files }

   let DeleteFile (file : File) (bundle : Bundle) =
      let file = bundle |> GetBundleFile file.Folder file.Name
      let files = bundle.Files |> List.filter (fun x -> x <> file)
      { Files = files }

(*********************************************************************************************************************)
type ProjectCommands () =
   member this.CanUndo with get () = BundleManager.CanUndo()
   member this.CanRedo with get () = BundleManager.CanRedo()
   member this.Undo () = BundleManager.Undo()
   member this.Redo () = BundleManager.Redo()
   
   member this.NewFile folder name pouType pouLanguage =
      BundleManager.Do (FileOperations.NewFile folder name pouType pouLanguage)
      
   member this.RenameFile (file : File) newName =
      if file.Name <> newName then
         BundleManager.Do (FileOperations.RenameFile file newName)

   member this.MoveFiles (files : File seq) newFolder =
      let namePaths = files |> Seq.map (fun x -> (x.Folder, x.Name)) |> Seq.toList
      BundleManager.Do (FileOperations.MoveFiles namePaths newFolder)

let Commands = new ProjectCommands()
