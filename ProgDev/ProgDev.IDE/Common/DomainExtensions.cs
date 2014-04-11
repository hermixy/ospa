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

using ProgDev.Core.Domain;
using System;

namespace ProgDev.IDE.Common
{
   public static class DomainExtensions
   {
      public static string ToShortString(this PouType self)
      {
         switch (self)
         {
            case PouType.Class: return Strings.ShortFileTypeClass;
            case PouType.DataType: return Strings.ShortFileTypeDataType;
            case PouType.Function: return Strings.ShortFileTypeFunction;
            case PouType.FunctionBlock: return Strings.ShortFileTypeFunctionBlock;
            case PouType.GlobalVars: return Strings.ShortFileTypeGlobalVars;
            case PouType.Interface: return Strings.ShortFileTypeInterface;
            case PouType.Program: return Strings.ShortFileTypeProgram;
            default: throw new ArgumentOutOfRangeException("self");
         }
      }

      public static string ToShortString(this PouLanguage self)
      {
         switch (self)
         {
            case PouLanguage.FunctionBlockDiagram: return Strings.ShortLanguageFBD;
            case PouLanguage.InstructionList: return Strings.ShortLanguageIL;
            case PouLanguage.LadderDiagram: return Strings.ShortLanguageLD;
            case PouLanguage.SequentialFunctionChart: return Strings.ShortLanguageSFC;
            case PouLanguage.StructuredText: return Strings.ShortLanguageST;
            default: throw new ArgumentOutOfRangeException("self");
         }
      }
   }
}
