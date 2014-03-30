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

module ProgDev.Core.Bundler
open System.IO
open System.Text

let rec private GetAllFolders (path : string) : string seq =
   Array.toSeq (Directory.GetDirectories path)
   |> Seq.map GetAllFolders
   |> Seq.fold Seq.append Seq.empty<string>
   |> Seq.append [| path |]

let private GetAllFiles (folders : string seq) : string seq =
   folders
   |> Seq.map Directory.GetFiles
   |> Seq.map Array.toSeq
   |> Seq.fold Seq.append Seq.empty<string>

let private CreateVirtualFolder (folderPath : string) : Dal.VirtualFolder =
   {
      Path = folderPath
   }

let private CreateVirtualFile (filePath : string) : Dal.VirtualFile =
   {
      Path = Path.GetDirectoryName(filePath)
      Name = Path.GetFileName(filePath)
      Content = File.ReadAllText(filePath)
   }

let private CreateBundle (sourcePath : string) : Dal.Bundle =
   let folderPaths = GetAllFolders sourcePath 
   {
      Folders = 
         folderPaths 
         |> Seq.map CreateVirtualFolder 
         |> Seq.toList
      Files = 
         GetAllFiles folderPaths 
         |> Seq.map CreateVirtualFile 
         |> Seq.toList
   }

let Bundle (sourcePath : string) (targetFilePath : string) : unit =
   Dal.Save (CreateBundle sourcePath) targetFilePath
