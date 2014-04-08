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

using Microsoft.WindowsAPICodePack.Dialogs;
using ProgDev.IDE.Common;
using ProgDev.IDE.Common.FlexForms;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace ProgDev.IDE.Forms
{
   public partial class AppForm : Form
   {
      private ProgramExplorerForm _ProgramExplorer;

      public AppForm(AppFormViewModel viewModel)
      {
         InitializeComponent();

         _ProgramExplorer = new ProgramExplorerForm();
         _ProgramExplorer.Show(_DockPanel, DockState.DockRight);

         this.BindLocation(viewModel.Location);
         this.BindSize(viewModel.Size);
         this.BindMinimumSize(viewModel.MinimumSize);
         _NewButton.BindClick(viewModel.NewClick);
         _OpenButton.BindClick(viewModel.OpenClick);
         _SaveButton.BindClick(viewModel.SaveClick);
         _AddButton.BindClick(viewModel.AddClick);
         _BuildButton.BindClick(viewModel.BuildClick);
         _DeployButton.BindClick(viewModel.DeployClick);
         _DebugButton.BindClick(viewModel.DebugClick);
         this.BindClosing(viewModel.Closing);
         viewModel.Start(this);
      }

      private void OnAboutClick(object sender, EventArgs e)
      {
         FormsFactory.NewAboutForm().ShowDialog();
      }
   }
}
