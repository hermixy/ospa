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
using System.Windows.Forms;

namespace ProgDev.IDE.Forms
{
   public partial class NewFileForm : Form
   {
      public NewFileForm(NewFileFormViewModel viewModel)
      {
         InitializeComponent();

         _NameTxt.BindText(viewModel.NameText);
         _NameTxt.BindError(_ErrorProvider, viewModel.NameError);
         _FolderCmb.BindItems(viewModel.FolderList);
         _FolderCmb.BindText(viewModel.FolderText);
         _FolderCmb.BindError(_ErrorProvider, viewModel.FolderError);
         _TypeCmb.BindItems(viewModel.TypeList);
         _TypeCmb.BindSelectedIndex(viewModel.TypeSelectedIndex);
         _LanguageLbl.BindEnabled(viewModel.LanguageEnabled);
         _LanguageCmb.BindItems(viewModel.LanguageList);
         _LanguageCmb.BindSelectedIndex(viewModel.LanguageSelectedIndex);
         _LanguageCmb.BindEnabled(viewModel.LanguageEnabled);
         _OkBtn.BindEnabled(viewModel.OkEnabled);
         _OkBtn.BindClick(viewModel.OkClick);
         viewModel.Start(this);
      }
   }
}
