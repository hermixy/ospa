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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using ProgDev.FrontEnd.Common.FlexForms;

namespace ProgDev.FrontEnd.Forms
{
   public partial class ProjectContentForm : DockContent
   {
      public ProjectContentForm(ProjectContentFormViewModel viewModel)
      {
         InitializeComponent();

         SizeChanged += OnSizeChanged;
         _ContextMnu.Opening += OnContextMenuOpening;

         _ListView.BindItems(viewModel.List);
         viewModel.Start(this);
      }

      private void OnContextMenuOpening(object sender, CancelEventArgs e)
      {
         bool selection = _ListView.SelectedItems.Count > 0;
         _ContextMnu.Enabled = selection;
      }

      private void OnSizeChanged(object sender, EventArgs e)
      {
         _NameCol.Width = Width - _TypeCol.Width - _LanguageCol.Width - SystemInformation.VerticalScrollBarWidth - 5;
      }
   }
}
