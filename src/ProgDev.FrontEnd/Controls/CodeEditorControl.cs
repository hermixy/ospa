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

namespace ProgDev.FrontEnd.Controls
{
   public partial class CodeEditorControl : EditorControl
   {
      public CodeEditorControl()
      {
         InitializeComponent();

         _TextEditor.Text = SourceText;
         _TextEditor.TextChanged += OnTextChanged;
         _UpdateTimer.Tick += OnUpdateTimer;
      }

      void OnUpdateTimer(object sender, EventArgs e)
      {
         _UpdateTimer.Stop();
         InternalSetSourceText(_TextEditor.Text);
      }

      private void OnTextChanged(object sender, EventArgs e)
      {
         // Only update the SourceText when the user stops typing for a brief moment, rather than updating on every 
         // keystroke which could be slow on low-end machines.  Updating the SourceText creates an undo checkpoint.
         _UpdateTimer.Stop();
         _UpdateTimer.Start();
      }

      protected override void OnExternalTextChange()
      {
         // Save scrollbar and caret position.
         int scroll = _TextEditor.ActiveTextAreaControl.VScrollBar.Value;
         var caret = _TextEditor.ActiveTextAreaControl.Caret.Position;

         _TextEditor.Text = SourceText;

         // Restore scrollbar and caret position.
         _TextEditor.ActiveTextAreaControl.VScrollBar.Value =
            Math.Min(scroll, _TextEditor.ActiveTextAreaControl.VScrollBar.Maximum);
         _TextEditor.ActiveTextAreaControl.Caret.Position = caret;

         // In some cases the text editor doesn't properly update itself without this:
         _TextEditor.ActiveTextAreaControl.Refresh();
      }
   }
}
