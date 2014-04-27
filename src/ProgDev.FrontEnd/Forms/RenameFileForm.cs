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

using ProgDev.FrontEnd.Common.FlexForms;
using System.Windows.Forms;

namespace ProgDev.FrontEnd.Forms
{
   public partial class RenameFileForm : Form
   {
      public RenameFileForm(RenameFileFormViewModel viewModel)
      {
         InitializeComponent();

         _OldNameTxt.BindText(viewModel.OldNameText);
         _NewNameTxt.BindText(viewModel.NewNameText);
         _NewNameTxt.BindError(_ErrorProvider, viewModel.NewNameError);
         _OkBtn.BindEnabled(viewModel.OkEnabled);
         _OkBtn.BindClick(viewModel.OkClick);
         viewModel.Start(this);
      }
   }
}
