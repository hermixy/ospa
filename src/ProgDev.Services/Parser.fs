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

module ProgDev.Services.Parser
open ProgDev.Parsers
open ProgDev.Domain.Ast
open Antlr4.Runtime.Tree;

let private Parse_POU_Decl (node : ITerminalNode) : ProgramOrganizationUnitDeclaration = 
   {
      UsingDirectives = []
      GlobalVariableDeclarationBlocks = []
      DataTypeDeclarations = []
      AccessDeclarationBlocks = []
      FunctionDeclarations = []
      FunctionBlockDeclarations = []
      ClassDeclarations = []
      InterfaceDeclarations = []
      NamespaceDeclarations = []
   }

let private Parse_Prog (tree : IParseTree) : ControlProgram =
   { 
      ProgramOrganizationUnitDeclarations =  []
         //tree
            //|> Seq.map Parse_POU_Decl 
            //|> List.ofSeq 
   }

let Parse (inputSource : string) : ControlProgram = 
   let parseResult = ParseHandler.Parse inputSource
   if parseResult.IsError then
      raise (System.Exception(parseResult.ErrorMessage))
   else
      Parse_Prog parseResult.ParseTree
