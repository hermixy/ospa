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
using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace ProgDev.FrontEnd.Forms
{
   public partial class AppForm : Form
   {
      private readonly ProjectContentForm _ProjectContentForm;
      private readonly SearchResultsForm _SearchResultsForm;

      public AppForm(AppFormViewModel viewModel, ProjectContentForm projectContentForm, 
         SearchResultsForm searchResultsForm, out Func<Project.File, EditorForm> doOpenFile)
      {
         InitializeComponent();

         // Exposing this allows the OpenEditorController to manipulate dialogs without needing access to (or knowledge
         // of) the dock panel control.  Similarly, the AppForm does not need to know how the controller does its job; 
         // it just does what it's told.
         doOpenFile = DoOpenFile;

         // Project content form
         _ProjectContentForm = projectContentForm;
         _ProjectContentForm.Show(_DockPanel, DockState.DockLeft);
         // Find form
         _SearchResultsForm = searchResultsForm;
         _SearchResultsForm.Show(_DockPanel, DockState.DockLeft);
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

         // Bring the Project Content Form to the front.
         _ProjectContentForm.Show();
      }

      private EditorForm DoOpenFile(Project.File projectFile)
      {
         var editorForm = FormsFactory.NewEditorForm(projectFile);
         editorForm.Show(_DockPanel, DockState.Document);
         return editorForm;
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
