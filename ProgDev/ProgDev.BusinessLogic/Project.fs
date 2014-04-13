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

type File = {
   Folder : string
   Filename : string // Includes file extensions
   Name : string // No file extension, just the name portion
   Type : PouType
   Language : PouLanguage
}

(*********************************************************************************************************************)
let mutable private _FilePath : string option = None
let mutable private _Bundle : Bundle = { Files = [] }
let mutable private _Dirty : bool = false
let private _ChangedEvent = new DelegateEvent<System.Action>()

let private NamePart (filename : string) : string = filename.Split('.').[0]

let private ToFile (x : BundleFile) : File =
   let dottedParts = x.Name.Split('.')
   if dottedParts.Length <> 3 then raise (Exception "Malformed filename.")
   let name = dottedParts.[0]
   let pouLanguage = dottedParts.[1] |> FileExtensions.ParseLanguageExtension
   let pouType = dottedParts.[2] |> FileExtensions.ParseTypeExtension
   { Folder = x.Folder; Filename = x.Name; Name = name; Type = pouType; Language = pouLanguage }

let private SetBundle x =
   _Bundle <- x
   _ChangedEvent.Trigger([| |])

(*********************************************************************************************************************)
type EventsContainer () =
   [<CLIEvent>]
   member this.Changed = _ChangedEvent.Publish

let Events : EventsContainer = new EventsContainer()

let Folders () =
   _Bundle.Files
   |> List.toSeq 
   |> Seq.map (fun x -> x.Folder)
   |> Seq.distinct

let Files () =
   _Bundle.Files 
   |> List.toSeq 
   |> Seq.map ToFile

let FilePath () =
   match _FilePath with
   | Some x -> x
   | None -> null

let ProjectName () =
   match _FilePath with
   | Some x -> System.IO.Path.GetFileNameWithoutExtension x
   | None -> Strings.Untitled

let IsDirty = _Dirty

(*********************************************************************************************************************)
let New () =
   _FilePath <- None
   SetBundle { Files = [] }
   _Dirty <- false
   _ChangedEvent.Trigger([| |])

let Load (filePath : string) =
   SetBundle (Bundler.Load filePath)
   _FilePath <- Some filePath
   _Dirty <- false
   _ChangedEvent.Trigger([| |])

let Save (filePath : string) =
   Bundler.Save _Bundle filePath
   _FilePath <- Some filePath
   _Dirty <- false
   _ChangedEvent.Trigger([| |])

(*********************************************************************************************************************)
module private FileOperations =
   let private GetFile (namespaceName : string) (name : string) (bundle : Bundle) =
      bundle.Files 
      |> List.toSeq 
      |> Seq.filter (fun x -> x.Name =? name && x.Folder =? namespaceName) 
      |> Seq.exactlyOne

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
      | _ -> raise (Exception "Invalid combination of type and language.")

   let private GetTemplateString (pouType : PouType, pouLanguage : PouLanguage) =
      GetTemplate(pouType, pouLanguage) |> System.Text.Encoding.UTF8.GetString

   let NewFile (folder : string) (name : string) (pouType : PouType) (pouLanguage : PouLanguage) (bundle : Bundle) =
      if bundle.Files |> List.exists (fun x -> (NamePart x.Name) =? name && x.Folder =? folder) 
         then raise (Exception "File already exists.")
      let parts = [name; FileExtensions.GetLanguageExtension pouLanguage; FileExtensions.GetTypeExtension pouType]
      let filename = String.Join(".", parts)
      let content = GetTemplateString(pouType, pouLanguage)
      let newFile : BundleFile = { Folder = folder; Name = filename; Content = content; }
      let files = List.append bundle.Files [ newFile ]
      { Files = files }

   let RenameFile (folder : string) (oldName : string) (newName : string) (bundle : Bundle) =
      let oldFile = bundle |> GetFile folder oldName
      let newFile = { Folder = oldFile.Folder; Name = newName; Content = oldFile.Content } : BundleFile
      let files = bundle.Files |> List.map (fun x -> if x = oldFile then newFile else x)
      { Files = files }

   let DeleteFile (folder : string) (name : string) (bundle : Bundle) =
      let file = bundle |> GetFile folder name
      let files = bundle.Files |> List.filter (fun x -> x <> file)
      { Files = files }

(*********************************************************************************************************************)
module Commands =
   type private Command = {
      Do : Bundle -> Bundle
      Undo : Bundle -> Bundle
      Name : string
   }

   let mutable private _UndoStack = [] : Command list
   let mutable private _RedoStack = [] : Command list

   let private Do (command : Command) =
      _Bundle <- _Bundle |> command.Do
      _UndoStack <- List.Cons(command, _UndoStack)
      _RedoStack <- []
      _Dirty <- true
      
   let CanUndo = not _UndoStack.IsEmpty
   let CanRedo = not _RedoStack.IsEmpty

   let Undo () =
      if _UndoStack.IsEmpty then ()
      else
         let command = _UndoStack.Head
         _Bundle <- _Bundle |> command.Undo
         _UndoStack <- _UndoStack.Tail
         _RedoStack <- List.Cons(command, _RedoStack)
         _Dirty <- true
   
   let Redo () =
      if _RedoStack.IsEmpty then ()
      else
         let command = _RedoStack.Head
         _Bundle <- _Bundle |> command.Do
         _RedoStack <- _RedoStack.Tail
         _UndoStack <- List.Cons(command, _UndoStack)
         _Dirty <- true
   
   let NewFile (folder : string) (name : string) (pouType : PouType) (pouLanguage : PouLanguage) =
      Do {
         Do = (fun b -> b |> FileOperations.NewFile folder name pouType pouLanguage)
         Undo = (fun b -> b |> FileOperations.DeleteFile folder name)
         Name = Strings.CommandAddFile
      }
      (*
   let RenameFile (folder : string) (oldName : string) (newName : string) =
      Do {
         Do = (fun b -> b |> FileOperations.RenameFile namespaceName oldName newName)
         Undo = (fun b -> b |> FileOperations.RenameFile namespaceName newName oldName)
      }

   let MoveFile (folder : string) (name : string) (newnamespaceName : string) =
      Do {
         Do = (fun b -> b |> FileOperations.MoveFile oldnamespaceName name newnamespaceName)
         Undo = (fun b -> b |> FileOperations.MoveFile newnamespaceName name oldnamespaceName)
      }
*)