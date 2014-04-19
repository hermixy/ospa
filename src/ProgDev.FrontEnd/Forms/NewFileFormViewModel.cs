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
using ProgDev.Domain;
using ProgDev.FrontEnd.Common.FlexForms;
using ProgDev.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProgDev.FrontEnd.Forms
{
   public sealed class NewFileFormViewModel : FormViewModel
   {
      private readonly string _InitialName;
      public Field<string> NameText;
      public ComputedField<string> NameError;

      public ListField<string> FolderList;
      public Field<string> FolderText;
      public ComputedField<string> FolderError;

      public ListField<string> TypeList;
      public Field<int> TypeSelectedIndex;

      public ListField<string> LanguageList;
      public Field<int> LanguageSelectedIndex;
      public ComputedField<bool> LanguageEnabled;

      public ComputedField<bool> OkEnabled;
      public Signal OkClick;

      public NewFileFormViewModel(string name)
      {
         _InitialName = name;
      }

      protected override void Initialize()
      {
         NameText.Value = _InitialName;
         FolderList.Set(Project.Contents.Folders);
         FolderText.Value = Project.Contents.Folders.DefaultIfEmpty("").FirstOrDefault();
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
         return InputValidator.IsFolder(FolderText.Value) ? "" : Strings.ErrorExpectedFolder;
      }

      [Compute("OkEnabled"), Depends("NameError", "FolderError")]
      private bool ComputeOkEnabled()
      {
         return !NameError.Value.Any() && !FolderError.Value.Any();
      }

      private readonly static IReadOnlyDictionary<string, PouType> _TypeMap = new Dictionary<string, PouType>
      {
         { Strings.FileTypeProgram, PouType.Program },
         { Strings.FileTypeFunctionBlock, PouType.FunctionBlock },
         { Strings.FileTypeFunction, PouType.Function },
         { Strings.FileTypeGlobalVars, PouType.GlobalVars },
         { Strings.FileTypeDataType, PouType.DataType },
         { Strings.FileTypeClass, PouType.Class },
         { Strings.FileTypeInterface, PouType.Interface }
      };

      private readonly static IReadOnlyDictionary<string, PouLanguage> _LangMap = new Dictionary<string, PouLanguage>
      {
         { Strings.LanguageIL, PouLanguage.InstructionList },
         { Strings.LanguageLD, PouLanguage.LadderDiagram },
         { Strings.LanguageFBD, PouLanguage.FunctionBlockDiagram },
         { Strings.LanguageSFC, PouLanguage.SequentialFunctionChart },
         { Strings.LanguageST, PouLanguage.StructuredText }
      };

      [OnSignal("OkClick")]
      private void OnOkClick()
      {
         try
         {
            Project.Commands.NewFile(
               folder: FolderText.Value, 
               name: NameText.Value, 
               pouType: _TypeMap[TypeList[TypeSelectedIndex.Value]],
               pouLanguage: _LangMap[LanguageList[LanguageSelectedIndex.Value]]);
            Close(DialogResult.OK);
         }
         catch (Exception ex)
         {
            ShowChildDialog(MessageForm.ErrorBox(ex.Message));
         }
      }
   }
}
