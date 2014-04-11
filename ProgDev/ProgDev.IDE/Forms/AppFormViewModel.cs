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

using ProgDev.IDE.Common.FlexForms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ProgDev.IDE.Forms
{
   public sealed class AppFormViewModel : FormViewModel
   {
      public Field<Point> Location;
      public Field<Size> Size;
      public Field<Size> MinimumSize;
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
         }
      }

      [OnSignal("NewFileClick")]
      private void OnNewFileClick()
      {
         var form = FormsFactory.NewNewFileForm("Untitled");
         ShowChildDialog(form);
      }

      [OnSignal("Closing")]
      private void OnClosing(CancelEventArgs e)
      {
         Settings.Default.AppForm_SavedPositionExists = true;
         Settings.Default.AppForm_Location = Location.Value;
         Settings.Default.AppForm_Size = Size.Value;
         Settings.Default.Save();
      }
   }
}
