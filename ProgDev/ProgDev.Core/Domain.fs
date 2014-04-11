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

namespace ProgDev.Core.Domain
open System

type PouType =
   | Class = 0
   | DataType = 1
   | Function = 2
   | FunctionBlock = 3
   | GlobalVars = 4
   | Interface = 5
   | Program = 6

type PouLanguage =
   | FunctionBlockDiagram = 0
   | InstructionList = 1
   | LadderDiagram = 2
   | SequentialFunctionChart = 3
   | StructuredText = 4

module FileExtensions =
   let GetLanguageExtension (x : PouLanguage) : string =
      match x with
      | PouLanguage.FunctionBlockDiagram -> "fbd"
      | PouLanguage.InstructionList -> "il"
      | PouLanguage.LadderDiagram -> "ld"
      | PouLanguage.SequentialFunctionChart -> "sfc"
      | PouLanguage.StructuredText -> "st"
      | _ -> raise (Exception "Invalid PouLanguage.")

   let ParseLanguageExtension (x : string) : PouLanguage =
      match x with
      | "fbd" -> PouLanguage.FunctionBlockDiagram
      | "il" -> PouLanguage.InstructionList
      | "ld" -> PouLanguage.LadderDiagram
      | "sfc" -> PouLanguage.SequentialFunctionChart
      | "st" -> PouLanguage.StructuredText
      | _ -> raise (Exception "Invalid language extension.")

   let GetTypeExtension (x : PouType) : string =
      match x with
      | PouType.Class -> "cls"
      | PouType.DataType -> "typ"
      | PouType.Function -> "fun"
      | PouType.FunctionBlock -> "fb"
      | PouType.GlobalVars -> "var"
      | PouType.Interface -> "int"
      | PouType.Program -> "prg"
      | _ -> raise (Exception "Invalid PouType.")

   let ParseTypeExtension (x : string) : PouType =
      match x with
      | "cls" -> PouType.Class
      | "typ" -> PouType.DataType
      | "fun" -> PouType.Function
      | "fb" -> PouType.FunctionBlock
      | "var" -> PouType.GlobalVars
      | "int" -> PouType.Interface
      | "prg" -> PouType.Program
      | _ -> raise (Exception "Invalid type extension.")
