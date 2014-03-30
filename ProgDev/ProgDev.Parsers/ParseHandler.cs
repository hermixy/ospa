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

using Antlr4.Runtime;
using System;

namespace ProgDev.Parsers
{
   public static class ParseHandler
   {
      public static ParserResult Parse(string input)
      {
         try
         {
            var stream = new AntlrInputStream(input);
            var lexer = new OspaLexer(stream);
            var lexerStream = new CommonTokenStream(lexer);
            var parser = new OspaParser(lexerStream);
            var tree = parser.prog();
            return new ParserResult(tree);
         }
         catch (Exception ex)
         {
            return new ParserResult(ex.Message);
         }
      }
   }
}
