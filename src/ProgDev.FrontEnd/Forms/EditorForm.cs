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
using ProgDev.FrontEnd.Controls;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace ProgDev.FrontEnd.Forms
{
   public partial class EditorForm : DockContent
   {
      private readonly EditorControl _Editor;
      private readonly Project.File _File;

      public EditorForm(EditorControl editorControl, Project.File file)
      {
         InitializeComponent();

         _Editor = editorControl;
         _Editor.Dock = DockStyle.Fill;
         _Editor.SourceTextChange += OnSourceTextChange;
         Controls.Add(_Editor);

         _File = file;
         _Editor.ExternalSetSourceText(_File.Content);

         Project.Events.Changed += OnProjectChanged;
      }

      private void OnProjectChanged()
      {
         if (_File.Exists) // the file may have been deleted
            _Editor.ExternalSetSourceText(_File.Content);
         else
            Close();
         
      }

      private void OnSourceTextChange(object sender, EventArgs e)
      {
         Project.Commands.ModifyFile(_File, _Editor.SourceText);
      }
   }
}
