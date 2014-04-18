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

namespace ProgDev.FrontEnd.Forms
{
   public partial class EditorForm : DockContent
   {
      public EditorForm()
      {
         InitializeComponent();

         _SplitContainer.Paint += OnSplitContainerPaint;
      }

      void OnSplitContainerPaint(object sender, PaintEventArgs e)
      {
         var r = _SplitContainer.SplitterRectangle;
         e.Graphics.FillRectangle(SystemBrushes.Control, r);
         r.X -= 1;
         r.Width += 2;
         r.Height -= 1;
         e.Graphics.DrawRectangle(SystemPens.ControlDark, r);
      }
   }
}
