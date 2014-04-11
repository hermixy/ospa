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
using ProgDev.IDE.Common.FlexForms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgDev.IDE.Forms
{
   public sealed class ProjectContentFormViewModel : FormViewModel
   {
      public ListField<ListViewRow> List;

      protected override void Initialize()
      {
         List.Add(new ListViewRow { Icon = Images.PageWhite16, GroupName = null, Cells = new List<string> { "Main", "Program", "FBD" } });
         List.Add(new ListViewRow { Icon = Images.PageWhite16, GroupName = null, Cells = new List<string> { "Blahblah", "Data type", "SFC" } });
         List.Add(new ListViewRow { Icon = Images.PageWhite16, GroupName = "Hello", Cells = new List<string> { "Whee", "Func. block", "IL" } });
         List.Add(new ListViewRow { Icon = Images.PageWhite16, GroupName = "Hello", Cells = new List<string> { "Blah_Blah", "Function", "ST" } });
         List.Add(new ListViewRow { Icon = Images.PageWhite16, GroupName = "Hello", Cells = new List<string> { "Yeah", "Interface", "LD" } });
      }
   }
}
