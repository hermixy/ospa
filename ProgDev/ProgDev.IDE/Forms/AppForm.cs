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

using System;
using System.ComponentModel;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace ProgDev.IDE.Forms
{
   public partial class AppForm : Form
   {
      private ProgramExplorerForm _ProgramExplorer;

      public AppForm()
      {
         InitializeComponent();

         if (Settings.Default.AppForm_SavedPositionExists)
         {
            var screenArea = Screen.PrimaryScreen.WorkingArea;

            Width = Math.Max(MinimumSize.Width, Settings.Default.AppForm_Width);
            Height = Math.Max(MinimumSize.Height, Settings.Default.AppForm_Height);
            Left = Math.Min(screenArea.Width - Width, Math.Max(0, Settings.Default.AppForm_Left));
            Top = Math.Min(screenArea.Height - Height, Math.Max(0, Settings.Default.AppForm_Top));
         }

         _ProgramExplorer = new ProgramExplorerForm();
         _ProgramExplorer.Show(_DockPanel, DockState.DockLeft);
      }

      protected override void OnClosing(CancelEventArgs e)
      {
         Settings.Default.AppForm_SavedPositionExists = true;
         Settings.Default.AppForm_Left = Left;
         Settings.Default.AppForm_Top = Top;
         Settings.Default.AppForm_Width = Width;
         Settings.Default.AppForm_Height = Height;
         Settings.Default.Save();

         base.OnClosing(e);
      }

      private void OnAboutClick(object sender, EventArgs e)
      {
         FormsFactory.NewAboutForm().ShowDialog();
      }
   }
}
