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
using ProgDev.FrontEnd.Common;
using ProgDev.FrontEnd.Common.FlexForms;
using ProgDev.Resources;
using System.Collections.Generic;
using System.Linq;

namespace ProgDev.FrontEnd.Forms
{
   public sealed class ProjectContentFormViewModel : FormViewModel
   {
      public ListField<ListViewRow> List;

      protected override void Initialize()
      {
         Populate();
         Project.Events.Changed += () => Populate();
      }

      private void Populate()
      {
         List.Set(Project.Files.Select(x => new ListViewRow
         {
            Icon = Images.Pou16,
            GroupName = x.Folder,
            Cells = new List<string> { x.Name, x.Type.ToShortString(), x.Language.ToShortString() }
         }));
      }
   }
}
