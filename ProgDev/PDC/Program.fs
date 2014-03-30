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

open ProgDev.Core
open System
open System.IO
open System.Text

let Handle (verb : string) (args : string list) : int =
   match verb with
   | "bundle" -> 
      if args.Length = 2 then Bundler.Bundle args.[0] args.[1]; 0
      else printfn "Usage: pdc bundle <source directory> <output .OSP file path>"; -1
   | "unbundle" ->
      if args.Length = 2 then Unbundler.Unbundle args.[0] args.[1]; 0
      else printfn "Usage: pdc unbundle <source .OSP file path> <output directory>"; -1
   | _ -> 
      printfn "Invalid command."; -1

[<EntryPoint>]
let main argv = 
   try
      if argv.Length = 0 then 
         printfn "OSPA ProgDev Command Line Interface"
         printfn "(C) 2014 Brian Luft"
         printfn "---"
         printfn "Usage: pdc <command> <argument list>"
         printfn "Commands: bundle unbundle"
         -1
      else Handle argv.[0] (argv |> Array.toSeq |> Seq.skip(1) |> Seq.toList)
   with
      | ex -> printfn "Fatal error!\n%s\n%s" ex.Message (ex.StackTrace.ToString()); -1
