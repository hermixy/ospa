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

using ProgDev.Core;
using ProgDev.IDE.Common.FlexForms;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProgDev.IDE.Forms
{
   public sealed class UnitFormViewModel : FormViewModel
   {
      public Field<string> NameText;
      public Field<string> NameError;
      public Field<bool> IsOkEnabled;
      public Signal OkClick;

      protected override void Initialize()
      {
         NameText.Value = string.Empty;
         NameError.Value = string.Empty;
         IsOkEnabled.Value = false;
      }

      [OnChange("NameText")]
      public void OnChange()
      {
         Validate();
      }

      public bool Validate()
      {
         bool validName = InputValidator.IsIdentifier(NameText.Value);
         IsOkEnabled.Value = validName;

         if (validName)
            NameError.Value = string.Empty;
         else
            NameError.Value = "Name must be a valid identifier (alphanumeric and underscore, starting with a letter)";

         return IsOkEnabled.Value;
      }

      [OnSignal("OkClick")]
      public void OnOkClick()
      {
         if (Validate())
         {
            Close();
         }
      }
   }
}
