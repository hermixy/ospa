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

module ProgDev.Compiler.Ast

// Using_Directive
type UsingDirective = {
   FullyQualifiedNamespaces : string list
}

/// Global_Var_Decls
type GlobalVariableDeclarationBlock() = class end

// Data_Type_Decl
type DataTypeDeclaration() = class end

// Access_Decls
type AccessDeclarationBlock() = class end

// Func_Decl
type FunctionDeclaration() = class end

// FB_Decl
type FunctionBlockDeclaration() = class end

// Class_Decl
type ClassDeclaration() = class end

// Multibits_Type_Name
type MultibitsTypeName =
   | Byte
   | Word
   | Dword
   | Lword

// Bit_Str_Type_Name
type BitStringTypeName =
   | Bool
   | Multibits of MultibitsTypeName

// DT_Type_Name
type DateTimeTypeName =
   | DateTime
   | LongDateTime

// Tod_Type_Name
type TimeOfDayTypeName =
   | TimeOfDay
   | LongTimeOfDay

// Date_Type_Name
type DateTypeName =
   | Date
   | LongDate

// Time_Type_Name
type TimeTypeName =
   | Time
   | LongTime

// String_Type_Name
type StringTypeName =
   | String of uint32 option
   | WideString of uint32 option
   | Character
   | WideCharacter

// Real_Type_Name
type RealTypeName =
   | Real
   | LongReal

// Unsign_Int_Type_Name
type UnsignedIntegerTypeName =
   | UnsignedShortInteger
   | UnsignedInteger
   | UnsignedDoubleInteger
   | UnsignedLongInteger

// Sign_Int_Type_Name
type SignedIntegerTypeName =
   | ShortInteger
   | Integer
   | DoubleInteger
   | LongInteger

// Int_Type_Name
type IntegerTypeName =
   | Signed of SignedIntegerTypeName
   | Unsigned of UnsignedIntegerTypeName

// Numeric_Type_Name
type NumericTypeName =
   | Integer of IntegerTypeName
   | Real of RealTypeName

// Elem_Type_Name
type ElementaryTypeName =
   | Numeric of NumericTypeName
   | BitString of BitStringTypeName
   | String of StringTypeName
   | Date of DateTypeName
   | Time of TimeTypeName

// Struct_Type_Access, Array_Type_Access, Enum_Type_Access, Subrange_Type_Access, Simple_Type_Access, 
// String_Type_Access, Single_Elem_Type_Access, Class_Type_Access, Ref_Type_Access, Interface_Type_Access
type SymbolReference = {
   Namespace : string option
   Identifier : string
}

// Data_Type_Access
type DataTypeAccess =
   | Elementary of ElementaryTypeName
   | Derived of SymbolReference

// Array_Conformand
type ArrayConformand = {
   NumDimensions : int
   Type : DataTypeAccess
}

// Array_Conform_Decl
type ArrayConformDeclaration = {
   Variables : string list
   Conformand : ArrayConformand
}

type EdgeType =
   | Rising
   | Falling

// Edge_Decl
type EdgeDeclaration = {
   Variables : string list
   Type : EdgeType
}

// Var_Decl_Init


// Input_Decl
//var InputDeclaration = 

// Input_Decls
type InputDeclarationBlock = {
   Retain : bool option

}

// IO_Var_Decls
type IoVariableDeclarationBlock = 
   | In of InputDeclarationBlock
   | Out //todo
   | InOut //todo

// Method_Prototype
type MethodPrototype = {
   MethodName : string
   ReturnType : DataTypeAccess option
}

// Interface_Decl
type InterfaceDeclaration = {
   Name : string
   UsingDirectives : UsingDirective list
   ExtendsInterfaces : SymbolReference list
   MethodPrototypes : MethodPrototype list
}

// Namespace_Decl
type NamespaceDeclaration = {
   IsInternal : bool
   FullyQualifiedNamespace : string
   DataTypeDeclarations : DataTypeDeclaration list
   FunctionDeclarations : FunctionDeclaration list
   FunctionBlockDeclarations : FunctionBlockDeclaration list
   ClassDeclarations : ClassDeclaration list
   InterfaceDeclarations : InterfaceDeclaration list
   NamespaceDeclarations : NamespaceDeclaration list
}

// POU_Decl
type ProgramOrganizationUnitDeclaration = {
   UsingDirectives : UsingDirective list
   GlobalVariableDeclarationBlocks : GlobalVariableDeclarationBlock list
   DataTypeDeclarations : DataTypeDeclaration list
   AccessDeclarationBlocks : AccessDeclarationBlock list
   FunctionDeclarations : FunctionDeclaration list
   FunctionBlockDeclarations : FunctionBlockDeclaration list
   ClassDeclarations : ClassDeclaration list
   InterfaceDeclarations : InterfaceDeclaration list
   NamespaceDeclarations : NamespaceDeclaration list
}

// prog
type ControlProgram = {
   ProgramOrganizationUnitDeclarations : ProgramOrganizationUnitDeclaration list
}
