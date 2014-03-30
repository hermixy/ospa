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

module ProgDev.Core.Dal
open System
open System.IO
open System.Text

type VirtualFile = {
   Path : string
   Name : string
   Content : string
}

type VirtualFolder = {
   Path : string
}

type Bundle = {
   Folders : VirtualFolder list
   Files : VirtualFile list
}

let private FoldersStart = "{[ProgDev.Folders]}"
let private FolderStart = "\r\n{[ProgDev.Folder]}\r\n"
let private FilesStart = "\r\n{[ProgDev.Files]}"
let private FileStart = "\r\n{[ProgDev.File]}\r\n"
let private FieldDelimeter = "\r\n{[======]}\r\n"

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Serialization
//

let private SerializeVirtualFile (file : VirtualFile) : string =
   FileStart + file.Path + FieldDelimeter + file.Name + FieldDelimeter + file.Content

let rec private SerializeVirtualFolder (folder : VirtualFolder) : string =
   FolderStart + folder.Path

let private SerializeArchive (bundle : Bundle) : string =
   let folderRecords = List.map SerializeVirtualFolder bundle.Folders
   let foldersSection = String.concat "" folderRecords
   let fileRecords = List.map SerializeVirtualFile bundle.Files
   let filesSection = String.concat "" fileRecords
   FoldersStart + foldersSection + FilesStart + filesSection

let Save (bundle : Bundle) (filePath : string) : unit =
   use stream = File.Create(filePath)
   use writer = new StreamWriter(stream, Encoding.UTF8)
   writer.Write(SerializeArchive bundle)

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Deserialization
//

let private CheckAndChop (haystack : string) (needle : string) : string =
   if haystack.Length < needle.Length then
      raise (Exception("Premature end of file."))
   elif haystack.Substring(0, needle.Length) <> needle then
      raise (Exception("Unexpected text in file."))
   else
      haystack.Substring(needle.Length)

let private DeserializeVirtualFile (encoded : string) : VirtualFile =
   let fields = encoded.Split([| FieldDelimeter |], StringSplitOptions.None)
   {
      Path = fields.[0]
      Name = fields.[1]
      Content = fields.[2]
   }

let private DeserializeVirtualFolder (encoded : string) : VirtualFolder =
   {
      Path = encoded
   }

let private DeserializeArchive (encoded : string) : Bundle =
   let body = CheckAndChop encoded FoldersStart
   let sections = body.Split([| FilesStart |], StringSplitOptions.None)
   let folderRecords = sections.[0].Split([| FolderStart |], StringSplitOptions.RemoveEmptyEntries)
   let fileRecords = sections.[1].Split([| FileStart |], StringSplitOptions.RemoveEmptyEntries)
   {
      Folders = List.map DeserializeVirtualFolder (Array.toList folderRecords)
      Files = List.map DeserializeVirtualFile (Array.toList fileRecords)
   }

let Load (filePath : string) : Bundle =
   use stream = File.OpenRead(filePath)
   use reader = new StreamReader(stream, Encoding.UTF8)
   let encoded = reader.ReadToEnd()
   DeserializeArchive encoded
