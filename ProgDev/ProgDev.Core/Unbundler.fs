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

module ProgDev.Core.Unbundler
open System.IO
open System.Text

let private CreateFolder (absoluteRoot : string) (folder : Dal.VirtualFolder) : unit =
   let absolutePath = Path.Combine(absoluteRoot, folder.Path)
   ignore (Directory.CreateDirectory absolutePath)

let private CreateFolders (absoluteRoot : string) (folders : Dal.VirtualFolder list) : unit =
   let createFolder = CreateFolder absoluteRoot
   ignore (List.map createFolder folders)

let private CreateFile (absoluteRoot : string) (file : Dal.VirtualFile) : unit =
   let absolutePath = Path.Combine(absoluteRoot, file.Path, file.Name)
   use stream = File.Create absolutePath
   use writer = new StreamWriter(stream, Encoding.UTF8)
   writer.Write file.Content

let private CreateFiles (absoluteRoot : string) (files : Dal.VirtualFile list) : unit =
   let createFile = CreateFile absoluteRoot
   ignore (List.map createFile files)

let Unbundle (sourceFilePath : string) (targetPath : string) : unit =
   let bundle = Dal.Load sourceFilePath
   CreateFolders targetPath bundle.Folders
   CreateFiles targetPath bundle.Files
