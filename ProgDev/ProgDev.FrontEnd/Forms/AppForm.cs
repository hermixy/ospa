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

using ProgDev.FrontEnd.Common.FlexForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace ProgDev.FrontEnd.Forms
{
   public partial class AppForm : Form
   {
      private ProjectContentForm _ProgramExplorer;

      public AppForm(AppFormViewModel viewModel)
      {
         InitializeComponent();
            
         _ProgramExplorer = FormsFactory.NewProjectContentForm();
         _ProgramExplorer.Show(_DockPanel, DockState.DockLeft);

         var asdf = new EditorForm();
         asdf.Show(_DockPanel, DockState.Document);
         asdf = new EditorForm();
         asdf.Show(_DockPanel, DockState.Document);
         asdf = new EditorForm();
         asdf.Show(_DockPanel, DockState.Document);

         this.BindLocation(viewModel.Location);
         this.BindSize(viewModel.Size);
         this.BindMinimumSize(viewModel.MinimumSize);
         this.BindWindowState(viewModel.WindowState);
         this.BindText(viewModel.Title);
         _NewButton.BindClick(viewModel.NewClick);
         _NewProjectMnu.BindClick(viewModel.NewClick);
         _OpenButton.BindClick(viewModel.OpenClick);
         _OpenProjectMnu.BindClick(viewModel.OpenClick);
         _SaveButton.BindClick(viewModel.SaveClick);
         _SaveButton.BindEnabled(viewModel.SaveEnabled);
         _SaveProjectMnu.BindClick(viewModel.SaveClick);
         _SaveProjectMnu.BindEnabled(viewModel.SaveEnabled);
         _NewFileBtn.BindClick(viewModel.NewFileClick);
         _NewFileMnu.BindClick(viewModel.NewFileClick);
         _BuildButton.BindClick(viewModel.BuildClick);
         _CompileMnu.BindClick(viewModel.BuildClick);
         _DeployButton.BindClick(viewModel.DeployClick);
         _DeployMnu.BindClick(viewModel.DeployClick);
         _DebugButton.BindClick(viewModel.DebugClick);
         _DebugMnu.BindClick(viewModel.DebugClick);
         this.BindClosing(viewModel.Closing);
         viewModel.Start(this);
      }

      private void OnAboutClick(object sender, EventArgs e)
      {
         FormsFactory.NewAboutForm().ShowDialog();
      }

      private void _ToolStripContainer_TopToolStripPanel_Paint(object sender, PaintEventArgs e)
      {
         Control c = (Control)sender;
         e.Graphics.DrawLine(SystemPens.ControlLight, 0, c.Height - 2, c.Width - 1, c.Height - 2);
         e.Graphics.DrawLine(SystemPens.ControlDark, 0, c.Height - 1, c.Width - 1, c.Height - 1);
      }

      private void _StatusStrip_Paint(object sender, PaintEventArgs e)
      {
         Control c = (Control)sender;
         e.Graphics.DrawLine(SystemPens.ControlDark, 0, 0, c.Width - 1, 0);
         e.Graphics.DrawLine(SystemPens.ControlLight, 0, 1, c.Width - 1, 1);
      }
   }
}
