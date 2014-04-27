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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace ProgDev.FrontEnd.Forms
{
   public partial class AppForm : Form
   {
      private readonly ProjectContentForm _ProjectContentForm;

      public AppForm(AppFormViewModel viewModel, ProjectContentForm projectContentForm)
      {
         InitializeComponent();

         // Project content form
         _ProjectContentForm = projectContentForm;
         _ProjectContentForm.Show(_DockPanel, DockState.DockLeft);
         // Dock panel
         _DockPanel.BindDockLeftPortion(viewModel.DockLeftPortion);
         _DockPanel.BindDockRightPortion(viewModel.DockRightPortion);
         _DockPanel.BindDockTopPortion(viewModel.DockTopPortion);
         _DockPanel.BindDockBottomPortion(viewModel.DockBottomPortion);
         _ProjectContentForm.BindDockState(viewModel.ProjectContentFormDockState);
         // Window frame
         this.BindLocation(viewModel.Location);
         this.BindSize(viewModel.Size);
         this.BindMinimumSize(viewModel.MinimumSize);
         this.BindWindowState(viewModel.WindowState);
         // Titlebar
         this.BindText(viewModel.Title);
         this.BindClosing(viewModel.PromptClose, viewModel.CanClose);
         // File menu
         _NewButton.BindClick(viewModel.NewClick);
         _NewProjectMnu.BindClick(viewModel.NewClick);
         _OpenButton.BindClick(viewModel.OpenClick);
         _OpenProjectMnu.BindClick(viewModel.OpenClick);
         _SaveButton.BindClick(viewModel.SaveClick);
         _SaveButton.BindEnabled(viewModel.SaveEnabled);
         _SaveProjectMnu.BindClick(viewModel.SaveClick);
         _SaveProjectMnu.BindEnabled(viewModel.SaveEnabled);
         _SaveProjectAsMnu.BindClick(viewModel.SaveAsClick);
         // Edit menu
         _UndoMnu.BindEnabled(viewModel.UndoEnabled);
         _UndoMnu.BindClick(viewModel.UndoClick);
         _RedoMnu.BindEnabled(viewModel.RedoEnabled);
         _RedoMnu.BindClick(viewModel.RedoClick);
         // Program menu
         _NewFileBtn.BindClick(viewModel.NewFileClick);
         _NewFileMnu.BindClick(viewModel.NewFileClick);
         _BuildButton.BindClick(viewModel.BuildClick);
         _CompileMnu.BindClick(viewModel.BuildClick);
         _DeployButton.BindClick(viewModel.DeployClick);
         _DeployMnu.BindClick(viewModel.DeployClick);
         _DebugButton.BindClick(viewModel.DebugClick);
         _DebugMnu.BindClick(viewModel.DebugClick);
         // Help menu
         _AboutMenuItem.BindClick(viewModel.AboutClick);
         viewModel.Start(this);
      }

      /// <summary>
      /// Called when the Project Content Form wants to open some files.
      /// </summary>
      public void OnOpenFiles(IReadOnlyList<PouReference> files)
      {
         foreach (var file in files)
         {
            try
            {
               var projectFile = Project.Contents.GetFile(file.Folder, file.Name);
               var editorForm = FormsFactory.NewEditorForm(projectFile);
               editorForm.Show(_DockPanel, DockState.Document);
            }
            catch (Exception ex)
            {
               FormsFactory.NewErrorForm(ex.Message).ShowDialog(this);
            }
         }
      }

      private void OnTopToolStripPanelPaint(object sender, PaintEventArgs e)
      {
         Control c = (Control)sender;
         e.Graphics.DrawLine(SystemPens.ControlLight, 0, c.Height - 2, c.Width - 1, c.Height - 2);
         e.Graphics.DrawLine(SystemPens.ControlDark, 0, c.Height - 1, c.Width - 1, c.Height - 1);
      }

      private void OnStatusStripPaint(object sender, PaintEventArgs e)
      {
         Control c = (Control)sender;
         e.Graphics.DrawLine(SystemPens.ControlDark, 0, 0, c.Width - 1, 0);
         e.Graphics.DrawLine(SystemPens.ControlLight, 0, 1, c.Width - 1, 1);
      }
   }
}
