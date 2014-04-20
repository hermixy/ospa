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
using ProgDev.FrontEnd.Common;
using ProgDev.FrontEnd.Common.FlexForms;
using ProgDev.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgDev.FrontEnd.Forms
{
   public sealed class MoveFileFormViewModel : FormViewModel
   {
      private readonly IReadOnlyList<Project.File> _Files;
      public ListField<ListViewRow> PouList;
      public ListField<string> NewFolderList;
      public Field<string> NewFolderText;
      public ComputedField<string> NewFolderError;
      public ComputedField<bool> OkEnabled;
      public Signal OkClick;

      public MoveFileFormViewModel(IReadOnlyList<Project.File> files)
      {
         _Files = files;
      }

      protected override void Initialize()
      {
         PouList.Set(_Files.Select(x => new ListViewRow
         {
            Icon = Images.Pou16,
            GroupName = x.Folder,
            Cells = new List<string> { x.Name, x.Type.ToShortString(), x.Language.ToShortString() },
            Tag = x
         }));

         NewFolderList.Set(Project.Contents.Folders);
         NewFolderText.Value = Project.Contents.Folders.DefaultIfEmpty("").FirstOrDefault();
      }

      [Compute("NewFolderError"), Depends("NewFolderText")]
      private string ComputeNewFolderError()
      {
         return InputValidator.IsFolder(NewFolderText.Value) ? "" : Strings.ErrorExpectedFolder;
      }

      [Compute("OkEnabled"), Depends("NewFolderError")]
      private bool ComputeOkEnabled()
      {
         return !NewFolderError.Value.Any();
      }

      [OnSignal("OkClick")]
      private void OnOkClick()
      {
         try
         {
            Project.Commands.MoveFiles(_Files, NewFolderText.Value);
            Close(DialogResult.OK);
         }
         catch (Exception ex)
         {
            ShowChildDialog(MessageForm.ErrorBox(ex.Message));
         }
      }
   }
}
