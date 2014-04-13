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
using ProgDev.FrontEnd.Common;
using ProgDev.FrontEnd.Common.FlexForms;
using ProgDev.Resources;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProgDev.FrontEnd.Forms
{
   public sealed class AppFormViewModel : FormViewModel
   {
      public Field<Point> Location;
      public Field<Size> Size;
      public Field<Size> MinimumSize;
      public Field<FormWindowState> WindowState;
      public Field<string> Title;
      public ComputedField<bool> SaveEnabled;
      public Signal NewClick;
      public Signal OpenClick;
      public Signal SaveClick;
      public Signal NewFileClick;
      public Signal BuildClick;
      public Signal DeployClick;
      public Signal DebugClick;
      public Signal Closing;

      protected override void Initialize()
      {
         if (Settings.Default.AppForm_SavedPositionExists)
         {
            var screenArea = Screen.PrimaryScreen.WorkingArea;

            int width = Math.Max(MinimumSize.Value.Width, Settings.Default.AppForm_Size.Width);
            int height = Math.Max(MinimumSize.Value.Height, Settings.Default.AppForm_Size.Height);
            int left = Math.Min(screenArea.Width - width, Math.Max(0, Settings.Default.AppForm_Location.X));
            int top = Math.Min(screenArea.Height - height, Math.Max(0, Settings.Default.AppForm_Location.Y));
            Location.Value = new Point(left, top);
            Size.Value = new Size(width, height);
            WindowState.Value = Settings.Default.AppForm_WindowState;
         }

         OnProjectChanged();
         Project.Events.Changed += OnProjectChanged;
      }

      void OnProjectChanged()
      {
         string filename = Project.ProjectName();
         if (Project.IsDirty)
            filename += "*";
         Title.Value = string.Format(Strings.AppFormTitle, filename);
         SaveEnabled.Poll();
      }

      private bool DoSave()
      {
         if (Project.FilePath() == null)
         {
            var dlg = new SaveFileDialog
            {
               AddExtension = true,
               AutoUpgradeEnabled = true,
               CheckPathExists = true,
               DefaultExt = "." + FileExtensions.ProjectExtension,
               Filter = string.Format(Strings.OpenProjectFilter, FileExtensions.ProjectExtension),
               OverwritePrompt = true,
               Title = Strings.SaveProjectTitle
            };
            var result = ShowChildDialog(dlg);
            if (result == DialogResult.OK)
            {
               Project.Save(dlg.FileName);
               return true;
            }
            else
            {
               return false;
            }
         }
         else
         {
            Project.Save(Project.FilePath());
            return true;
         }
      }

      [Compute("SaveEnabled")]
      private bool ComputeSaveEnabled()
      {
         return Project.IsDirty;
      }

      [OnSignal("NewClick")]
      private void OnNewClick()
      {
         Process.Start(Application.ExecutablePath);
      }

      [OnSignal("OpenClick")]
      private void OnOpenClick()
      {
         if (!Project.IsDirty)
         {
            string projectName = 
               Project.FilePath() == null 
               ? Strings.Untitled
               : Path.GetFileNameWithoutExtension(Project.FilePath());
            string message = string.Format(Strings.SaveChangedPrompt, projectName);

            var dlg = new MessageForm(message, Strings.OpenProjectTitle, 
               new[] { Strings.ButtonSave, Strings.ButtonDontSave, Strings.ButtonCancel }, Images.Page32);
            if (ShowChildDialog(dlg) == DialogResult.Cancel)
               return;
            else if (dlg.Result == Strings.ButtonSave)
               DoSave();
         }

         var openDlg = new OpenFileDialog
         {
            AutoUpgradeEnabled = true,
            CheckFileExists = true,
            CheckPathExists = true,
            DefaultExt = "." + FileExtensions.ProjectExtension, 
            Filter = string.Format(Strings.OpenProjectFilter, FileExtensions.ProjectExtension),
            Multiselect = false, 
            Title = Strings.OpenProjectTitle,
            ValidateNames = true
         };
         if (ShowChildDialog(openDlg) == DialogResult.OK)
         {
            try
            {
               Project.Load(openDlg.FileName);
            }
            catch (Exception ex)
            {
               ShowChildDialog(new MessageForm(
                  Strings.ErrorOpenProject, Strings.OpenProjectTitle, detail: ex.ToDetailString()));
               return;
            }
         }
      }

      [OnSignal("SaveClick")]
      private void OnSaveClick()
      {
         DoSave();
      }

      [OnSignal("NewFileClick")]
      private void OnNewFileClick()
      {
         var form = FormsFactory.NewNewFileForm(Strings.Untitled);
         ShowChildDialog(form);
      }

      [OnSignal("Closing")]
      private void OnClosing(CancelEventArgs e)
      {
         Settings.Default.AppForm_SavedPositionExists = true;
         Settings.Default.AppForm_WindowState = WindowState.Value;
         if (WindowState.Value == FormWindowState.Normal)
         {
            Settings.Default.AppForm_Location = Location.Value;
            Settings.Default.AppForm_Size = Size.Value;
         }
         Settings.Default.Save();
      }
   }
}
