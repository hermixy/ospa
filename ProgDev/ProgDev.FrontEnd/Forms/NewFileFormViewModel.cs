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

using ProgDev.BusinessLogic;
using ProgDev.FrontEnd.Common.FlexForms;
using ProgDev.Resources;
using System.Collections.Generic;
using System.Linq;

namespace ProgDev.FrontEnd.Forms
{
   public sealed class NewFileFormViewModel : FormViewModel
   {
      // Name textbox
      private readonly string _InitialName;
      public Field<string> NameText;
      public ComputedField<string> NameError;

      // Folder combobox
      private readonly IEnumerable<string> _InitialFolders;
      public ListField<string> FolderList;
      public Field<string> FolderText;
      public ComputedField<string> FolderError;

      // Type combobox
      public ListField<string> TypeList;
      public Field<int> TypeSelectedIndex;

      // Language combobox
      public ListField<string> LanguageList;
      public Field<int> LanguageSelectedIndex;
      public ComputedField<bool> LanguageEnabled;

      // OK button
      public ComputedField<bool> OkEnabled;
      public Signal OkClick;

      public NewFileFormViewModel(string name, IEnumerable<string> folders)
      {
         _InitialName = name;
         _InitialFolders = folders;
      }

      protected override void Initialize()
      {
         NameText.Value = _InitialName;
         FolderList.Set(_InitialFolders);
         FolderText.Value = _InitialFolders.DefaultIfEmpty("").FirstOrDefault();
         TypeList.AddRange(new[] 
         { 
            Strings.FileTypeProgram, 
            Strings.FileTypeFunctionBlock, 
            Strings.FileTypeFunction, 
            Strings.FileTypeGlobalVars,
            Strings.FileTypeDataType, 
            Strings.FileTypeClass, 
            Strings.FileTypeInterface 
         });
         LanguageList.AddRange(new[] 
         { 
            Strings.LanguageIL, 
            Strings.LanguageLD, 
            Strings.LanguageFBD, 
            Strings.LanguageSFC, 
            Strings.LanguageST 
         });
         TypeSelectedIndex.Value = 0; // Program
         LanguageSelectedIndex.Value = 4; // Structured Text
      }

      [Compute("LanguageEnabled"), Depends("TypeSelectedIndex")]
      private bool ComputeLanguageEnabled()
      {
         if (TypeSelectedIndex.Value == -1)
            return false;

         string type = TypeList[TypeSelectedIndex.Value];
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

      [Compute("FolderError"), Depends("FolderText")]
      private string ComputeFolderError()
      {
         return (FolderText.Value == "" || InputValidator.IsNamespace(FolderText.Value)) ? "" : Strings.ErrorExpectedNamespaceOrEmpty;
      }

      [Compute("OkEnabled"), Depends("NameError", "FolderError")]
      private bool ComputeOkEnabled()
      {
         return !NameError.Value.Any() && !FolderError.Value.Any();
      }

      [OnSignal("OkClick")]
      private void OnOkClick()
      {
         Close();
      }
   }
}
