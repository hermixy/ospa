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
using System.Collections.Generic;
using System.Linq;

namespace ProgDev.IDE.Forms
{
   public sealed class NewFileFormViewModel : FormViewModel
   {
      private static readonly IReadOnlyList<string> _Types = new[] { 
         Strings.FileTypeProgram, Strings.FileTypeFunctionBlock, Strings.FileTypeFunction, Strings.FileTypeGlobalVars,
         Strings.FileTypeDataType, Strings.FileTypeClass, Strings.FileTypeInterface };
      private static readonly IReadOnlyList<string> _Languages = new[] { 
         Strings.LanguageIL, Strings.LanguageLD, Strings.LanguageFBD, Strings.LanguageSFC, Strings.LanguageST };

      private readonly string _Name;
      private readonly bool _IsNew;

      public Field<string> NameText;
      public ComputedField<string> NameError;
      public ListField<string> TypeList;
      public Field<int> TypeSelectedIndex;
      public ListField<string> LanguageList;
      public Field<int> LanguageSelectedIndex;
      public ComputedField<bool> LanguageEnabled;
      public ComputedField<bool> OkEnabled;
      public Signal OkClick;

      public NewFileFormViewModel(string name)
      {
         _Name = name;
      }

      protected override void Initialize()
      {
         NameText.Value = _Name;
         TypeList.AddRange(_Types);
         LanguageList.AddRange(_Languages);
         TypeSelectedIndex.Value = 0;
         LanguageSelectedIndex.Value = 4;
      }

      [Compute("LanguageEnabled"), Depends("TypeSelectedIndex")]
      private bool ComputeLanguageEnabled()
      {
         if (TypeSelectedIndex.Value == -1)
            return false;

         string type = _Types[TypeSelectedIndex.Value];
         return
            type == Strings.FileTypeClass ||
            type == Strings.FileTypeFunction ||
            type == Strings.FileTypeFunctionBlock ||
            type == Strings.FileTypeProgram;
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
