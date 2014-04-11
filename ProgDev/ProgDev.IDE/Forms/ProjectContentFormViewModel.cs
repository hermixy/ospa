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

using ProgDev.Core;
using ProgDev.IDE.Common;
using ProgDev.IDE.Common.FlexForms;
using System.Collections.Generic;

namespace ProgDev.IDE.Forms
{
   public sealed class ProjectContentFormViewModel : FormViewModel
   {
      public ListField<ListViewRow> List;

      protected override void Initialize()
      {
         Populate();
      }

      private void Populate()
      {
         var newList = new List<ListViewRow>();

         foreach (var file in Project.Files)
         {
            var row = new ListViewRow
            {
               Icon = Images.PageWhite16,
               GroupName = file.Folder,
               Cells = new List<string> { file.Name, file.Type.ToShortString(), file.Language.ToShortString() }
            };
            newList.Add(row);
         }

         List.Set(newList);
      }
   }
}
