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

(*********************************************************************************************************************)
type PouType =
   | Class = 0
   | DataType = 1
   | Function = 2
   | FunctionBlock = 3
   | GlobalVars = 4
   | Interface = 5
   | Program = 6

(*********************************************************************************************************************)
type PouLanguage =
   | FunctionBlockDiagram = 0
   | InstructionList = 1
   | LadderDiagram = 2
   | SequentialFunctionChart = 3
   | StructuredText = 4

(*********************************************************************************************************************)
module FileExtensions =
   [<Literal>]
   let private LangFBD = "fbd"
   [<Literal>]
   let private LangIL = "il"
   [<Literal>]
   let private LangLD = "ld"
   [<Literal>]
   let private LangSFC = "sfc"
   [<Literal>]
   let private LangST = "st"

   [<Literal>]
   let private TypeClass = "clas"
   [<Literal>]
   let private TypeDataType = "type"
   [<Literal>]
   let private TypeFunction = "func"
   [<Literal>]
   let private TypeFunctionBlock = "fblk"
   [<Literal>]
   let private TypeGlobalVars = "gvar"
   [<Literal>]
   let private TypeInterface = "intf"
   [<Literal>]
   let private TypeProgram = "prog"

   let GetLanguageExtension (x : PouLanguage) : string =
      match x with
      | PouLanguage.FunctionBlockDiagram -> LangFBD
      | PouLanguage.InstructionList -> LangIL
      | PouLanguage.LadderDiagram -> LangLD
      | PouLanguage.SequentialFunctionChart -> LangSFC
      | PouLanguage.StructuredText -> LangST
      | _ -> raise (Exception "Invalid PouLanguage.")

   let ParseLanguageExtension (x : string) : PouLanguage =
      match x with
      | LangFBD -> PouLanguage.FunctionBlockDiagram
      | LangIL -> PouLanguage.InstructionList
      | LangLD -> PouLanguage.LadderDiagram
      | LangSFC -> PouLanguage.SequentialFunctionChart
      | LangST -> PouLanguage.StructuredText
      | _ -> raise (Exception "Invalid language extension.")

   let GetTypeExtension (x : PouType) : string =
      match x with
      | PouType.Class -> TypeClass
      | PouType.DataType -> TypeDataType
      | PouType.Function -> TypeFunction
      | PouType.FunctionBlock -> TypeFunctionBlock
      | PouType.GlobalVars -> TypeGlobalVars
      | PouType.Interface -> TypeInterface
      | PouType.Program -> TypeProgram
      | _ -> raise (Exception "Invalid PouType.")

   let ParseTypeExtension (x : string) : PouType =
      match x with
      | TypeClass -> PouType.Class
      | TypeDataType -> PouType.DataType
      | TypeFunction -> PouType.Function
      | TypeFunctionBlock -> PouType.FunctionBlock
      | TypeGlobalVars -> PouType.GlobalVars
      | TypeInterface -> PouType.Interface
      | TypeProgram -> PouType.Program
      | _ -> raise (Exception "Invalid type extension.")
