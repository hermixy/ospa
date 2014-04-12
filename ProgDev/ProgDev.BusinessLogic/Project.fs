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
open System
open ProgDev.Domain
open ProgDev.Services
open ProgDev.Services.Utility

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

let Folders : string seq =
   _Bundle.Files
   |> List.toSeq 
   |> Seq.map (fun x -> x.Folder)
   |> Seq.distinct

let Files : File seq =
   _Bundle.Files 
   |> List.toSeq 
   |> Seq.map ToFile

let FilePath =
   match _FilePath with
   | Some x -> x
   | None -> null

(*********************************************************************************************************************)
let New () =
   _FilePath <- None
   SetBundle { Files = [] }

let Load (filePath : string) =
   SetBundle (Bundler.Load filePath)
   _FilePath <- Some filePath

let Save (filePath : string) =
   Bundler.Save _Bundle filePath
   _FilePath <- Some filePath

let AddNewFile (name : string) (folder : string) (pouType : PouType) (pouLanguage : PouLanguage) (content : string) =
   if _Bundle.Files |> List.exists (fun x -> (NamePart x.Name) =? name && x.Folder =? folder) 
      then raise (Exception "File already exists.")
   let parts = [name; FileExtensions.GetLanguageExtension pouLanguage; FileExtensions.GetTypeExtension pouType]
   let filename = String.Join(".", parts)
   let newFile : BundleFile = { Folder = folder; Name = filename; Content = content; }
   let files = List.append _Bundle.Files [ newFile ]
   SetBundle { Files = files }
   newFile |> ToFile

let RenameFolder (oldFolderName : string) (newFolderName : string) =
   let files = 
      _Bundle.Files 
      |> List.map (fun x -> 
         if x.Name =? oldFolderName 
            then { Folder = newFolderName; Name = x.Name; Content = x.Content; } : BundleFile
         else x)
   SetBundle { Files = files }

let RenameFile (folderName : string) (oldName : string) (newName : string) =
   let oldFile = 
      _Bundle.Files 
      |> List.toSeq 
      |> Seq.filter (fun x -> x.Name =? oldName && x.Folder =? oldName) 
      |> Seq.exactlyOne
   let newFile = { Folder = oldFile.Folder; Name = newName; Content = oldFile.Content } : BundleFile
   let files = _Bundle.Files |> List.map (fun x -> if x = oldFile then newFile else x)
   SetBundle { Files = files }

let DeleteFolder (folderName : string) =
   let files = _Bundle.Files |> List.filter (fun x -> x.Folder <>? folderName)
   SetBundle { Files = files }

let DeleteFile (folderName : string) (name : string) =
   let files = _Bundle.Files |> List.filter (fun x -> x.Folder <>? folderName || x.Name <>? name)
   SetBundle { Files = files }
