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

namespace ProgDev.IDE.Forms
{
   public sealed class UnitFormViewModel : FormViewModel
   {
      private readonly string _Name;
      private readonly bool _IsNew;

      public Field<string> NameText;
      public ComputedField<string> NameError;
      public ComputedField<bool> OkEnabled;
      public ComputedField<string> OkText;
      public Signal OkClick;

      public UnitFormViewModel(string name, bool isNew)
      {
         _Name = name;
         _IsNew = isNew;
      }

      protected override void Initialize()
      {
         NameText.Value = _Name;
      }

      [Compute("NameError"), Depends("NameText")]
      public string ComputeNameError()
      {
         return InputValidator.IsIdentifier(NameText.Value) ? "" : Strings.ErrorExpectedIdentifier;
      }

      [Compute("IsOkEnabled"), Depends("NameError")]
      public bool ComputeOkEnabled()
      {
         return NameError.Value == "";
      }

      [Compute("OkText")]
      public string ComputeOkText()
      {
         return _IsNew ? Strings.ButtonCreate : Strings.ButtonSave;
      }

      [OnSignal("OkClick")]
      public void OnOkClick()
      {
         Close();
      }
   }
}
