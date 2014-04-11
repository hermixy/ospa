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
   Folder : string
   Name : string
   Content : string
}

type Bundle = {
   Files : VirtualFile list
}

let private FilesStart = "{[[ProgDev.Project]]}\r\n"
let private FileStart = "\r\n{[[ProgDev.File]]}\r\n"
let private FieldDelimeter = "\r\n{[[======]]}\r\n"

(*********************************************************************************************************************)
// Serialization

let rec private Serialize (x : obj) : string = 
   match x with
   | :? Bundle as bundle ->
      let filesSection = bundle.Files |> List.map Serialize |> String.concat ""
      FilesStart + filesSection   
   | :? VirtualFile as file -> 
      FileStart + file.Folder + FieldDelimeter + file.Name + FieldDelimeter + file.Content
   | _ -> raise (Exception("Unrecognized type"))

let Save (bundle : Bundle) (filePath : string) : unit =
   use stream = File.Create(filePath)
   use writer = new StreamWriter(stream, Encoding.UTF8)
   Serialize bundle |> writer.Write

(*********************************************************************************************************************)
// Deserialization

let private CheckAndChop (haystack : string) (needle : string) : string =
   if haystack.Length < needle.Length then
      raise (Exception("Premature end of file."))
   elif haystack.Substring(0, needle.Length) <> needle then
      raise (Exception("Unexpected text in file.\r\n" 
         + "Expected: \"" + needle + "\"\r\n" 
         + "Actual: \"" + haystack.Substring(0, needle.Length) + "\""))
   else
      haystack.Substring(needle.Length)

let private DeserializeVirtualFile (encoded : string) : VirtualFile =
   let fields = encoded.Split([| FieldDelimeter |], StringSplitOptions.None)
   { Folder = fields.[0]; Name = fields.[1]; Content = fields.[2] }

let private DeserializeBundle (encoded : string) : Bundle =
   let body = CheckAndChop encoded FilesStart
   let fileRecords = body.Split([| FileStart |], StringSplitOptions.RemoveEmptyEntries)
   let files = fileRecords  |> Array.map DeserializeVirtualFile |> Array.toList
   { Files = files }

let Load (filePath : string) : Bundle =
   use stream = File.OpenRead(filePath)
   use reader = new StreamReader(stream, Encoding.UTF8)
   let encoded = reader.ReadToEnd()
   DeserializeBundle encoded
