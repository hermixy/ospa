using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgDev.IDE.Common.FlexForms;

namespace ProgDev.IDE.Forms
{
   public partial class UnitForm : Form
   {
      public UnitForm(UnitFormViewModel viewModel)
      {
         InitializeComponent();

         _NameTxt.TextChanged += (sender, e) =>
         {
            int a = 5;
         };
         _NameTxt.BindText(viewModel.NameText);
         _ErrorProvider.BindError(_NameTxt, viewModel.NameError);
         _OkBtn.BindEnabled(viewModel.IsOkEnabled);
         _OkBtn.BindClick(viewModel.OkClick);
         viewModel.Start(this);
      }
   }
}
