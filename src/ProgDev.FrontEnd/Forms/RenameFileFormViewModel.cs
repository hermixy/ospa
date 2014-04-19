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
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProgDev.FrontEnd.Forms
{
   public sealed class RenameFileFormViewModel : FormViewModel
   {
      private readonly Project.File _File;
      public Field<string> OldNameText;
      public Field<string> NewNameText;
      public ComputedField<string> NewNameError;
      public ComputedField<bool> OkEnabled;
      public Signal OkClick;

      public RenameFileFormViewModel(Project.File file)
      {
         _File = file;
      }

      protected override void Initialize()
      {
         string name = _File.Name;
         OldNameText.Value = name;
         NewNameText.Value = name;
      }

      [Compute("NewNameError"), Depends("NewNameText")]
      private string ComputeNewNameError()
      {
         return InputValidator.IsIdentifier(NewNameText.Value) ? "" : Strings.ErrorExpectedIdentifier;
      }

      [Compute("OkEnabled"), Depends("NewNameError")]
      private bool ComputeOkEnabled()
      {
         return !NewNameError.Value.Any();
      }

      [OnSignal("OkClick")]
      private void OnOkClick()
      {
         try
         {
            Project.Commands.RenameFile(_File, NewNameText.Value);
            Close(DialogResult.OK);
         }
         catch (Exception ex)
         {
            ShowChildDialog(FormsFactory.NewErrorForm(ex.Message));
         }
      }
   }
}
