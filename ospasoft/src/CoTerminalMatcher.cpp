// OSPASOFT
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

#include "System.h"
#include "CoTerminalMatcher.h"

#define REGEX_IDENTIFIER   "[A-Z][A-Z0-9]*"
#define REGEX_PRAGMA       "{[^}]*}"
#define REGEX_UNSIGNED_INT "[0-9](_?[0-9])*"  
   // "Single underscore characters "_" inserted between the digits of a numeric literal shall not be significant.
   // No other use of underscore characters in numeric literals is allowed." - IEC 61131-3, 6.3.2

CoTerminalMatcher::CoTerminalMatcher()
:  _IdentifierRegex(REGEX_IDENTIFIER), _PragmaRegex(REGEX_PRAGMA), _UnsignedIntRegex(REGEX_UNSIGNED_INT)
{
}

bool CoTerminalMatcher::Match_Identifier(const std::string& token, std::string* output)
{
   if (!std::regex_match(token, _IdentifierRegex))
      return false;

   *output = token;
   return true;
}

bool CoTerminalMatcher::Match_Pragma(const std::string& token, std::string* output)
{
   if (!std::regex_match(token, _PragmaRegex))
      return false;

   *output = token;
   return true;
}
