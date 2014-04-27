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
using ProgDev.FrontEnd.Forms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgDev.FrontEnd.Controllers
{
   public sealed class OpenEditorController
   {
      private readonly List<EditorForm> _Editors = new List<EditorForm>();
      private readonly Func<Project.File, EditorForm> _DoOpenFile;

      public OpenEditorController(Func<Project.File, EditorForm> doOpenFile)
      {
         _DoOpenFile = doOpenFile;
      }

      public void Open(Project.File file)
      {
         var existingEditor = _Editors.SingleOrDefault(x => x.File == file);
         if (existingEditor == null)
         {
            var newEditor = _DoOpenFile(file);
            newEditor.FormClosed += (sender, e) => _Editors.Remove(newEditor);
            _Editors.Add(newEditor);
         }
         else
         {
            existingEditor.Show();
         }
      }
   }
}
