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

using System.Windows.Forms;

namespace ProgDev.FrontEnd.Controls
{
   public partial class SplitEditorControl : EditorControl
   {
      private readonly EditorControl _TopControl;
      private readonly EditorControl _BottomControl;

      public SplitEditorControl(EditorControl topControl, EditorControl bottomControl)
      {
         InitializeComponent();
         
         _TopControl = topControl;
         _TopControl.Dock = DockStyle.Fill;
         _TopControl.SourceTextChange += (sender, e) =>
         {
            InternalSetSourceText(_TopControl.SourceText);
            _BottomControl.ExternalSetSourceText(SourceText);
         };
         _SplitContainer.Panel1.Controls.Add(_TopControl);

         _BottomControl = bottomControl;
         _BottomControl.Dock = DockStyle.Fill;
         _BottomControl.SourceTextChange += (sender, e) =>
         {
            InternalSetSourceText(_BottomControl.SourceText);
            _TopControl.ExternalSetSourceText(SourceText);
         };
         _SplitContainer.Panel2.Controls.Add(_BottomControl);
      }

      protected override void OnExternalTextChange()
      {
         _TopControl.ExternalSetSourceText(SourceText);
         _BottomControl.ExternalSetSourceText(SourceText);
      }
   }
}
