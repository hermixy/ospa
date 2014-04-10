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
using System.Linq;

namespace ProgDev.IDE.Forms
{
   public sealed class NewFolderFormViewModel : FormViewModel
   {
      // Name textbox
      private readonly string _InitialName;
      public Field<string> NameText;
      public ComputedField<string> NameError;

      // OK button
      public ComputedField<bool> OkEnabled;
      public Signal OkClick;

      public NewFolderFormViewModel(string name)
      {
         _InitialName = name;
      }

      protected override void Initialize()
      {
         NameText.Value = _InitialName;
      }

      [Compute("NameError"), Depends("NameText")]
      private string ComputeNameError()
      {
         return InputValidator.IsIdentifier(NameText.Value) ? "" : Strings.ErrorExpectedIdentifier;
      }

      [Compute("OkEnabled"), Depends("NameError")]
      private bool ComputeOkEnabled()
      {
         return !NameError.Value.Any();
      }

      [OnSignal("OkClick")]
      private void OnOkClick()
      {
         Close();
      }
   }
}
