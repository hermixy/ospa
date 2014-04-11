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

let private CreateFile (absoluteRoot : string) (file : Dal.VirtualFile) : unit =
   let absolutePath = Path.Combine(absoluteRoot, file.Folder, file.Name)
   let folderPath = Path.Combine(absoluteRoot, file.Folder)
   if not (Directory.Exists folderPath) then ignore (Directory.CreateDirectory folderPath)
   File.WriteAllText(absolutePath, file.Content)

let private CreateFiles (absoluteRoot : string) (files : Dal.VirtualFile list) : unit =
   let createFile = CreateFile absoluteRoot
   ignore (List.map createFile files)

let Unbundle (sourceFilePath : string) (targetPath : string) : unit =
   let bundle = Dal.Load sourceFilePath
   CreateFiles targetPath bundle.Files
