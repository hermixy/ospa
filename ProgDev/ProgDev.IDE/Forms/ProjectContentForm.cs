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
using ProgDev.IDE.Common.FlexForms;

namespace ProgDev.IDE.Forms
{
   public partial class ProjectContentForm : DockContent
   {
      public ProjectContentForm(ProjectContentFormViewModel viewModel)
      {
         InitializeComponent();

         SizeChanged += OnSizeChanged;

         _ListView.BindItems(viewModel.List);
         viewModel.Start(this);
      }

      void OnSizeChanged(object sender, EventArgs e)
      {
         _NameCol.Width = Width - _TypeCol.Width - _LanguageCol.Width - SystemInformation.VerticalScrollBarWidth - 5;
      }
   }
}
