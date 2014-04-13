using ProgDev.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgDev.FrontEnd.Forms
{
   public partial class MessageForm : Form
   {
      public string Result { get; private set; }

      public MessageForm(string message, string title, string[] buttons = null, Image icon = null, string detail = null)
      {
         InitializeComponent();

         if (buttons == null)
            buttons = new[] { "OK" };

         if (icon == null)
            icon = Images.Error32;

         Text = title;
         _MessageTxt.Text = message;
         _IconBox.Image = icon;

         if (buttons.Length == 1)
         {
            _Btn1.Visible = false;
            _Btn2.Visible = false;
            _Btn3.Text = buttons[0];
            AcceptButton = _Btn3;
            CancelButton = _Btn3;
         }
         else if (buttons.Length == 2)
         {
            _Btn1.Visible = false;
            _Btn2.Text = buttons[0];
            _Btn3.Text = buttons[1];
            AcceptButton = _Btn2;
            CancelButton = _Btn3;
         }
         else if (buttons.Length == 3)
         {
            _Btn1.Text = buttons[0];
            _Btn2.Text = buttons[1];
            _Btn3.Text = buttons[2];
            AcceptButton = _Btn1;
            CancelButton = _Btn3;
         }
         else
         {
            throw new ArgumentOutOfRangeException("buttons");
         }

         if (detail == null)
         {
            Height -= _DetailTxt.Height;
            _DetailTxt.Visible = false;
         }
         else
         {
            _DetailTxt.Text = detail;
         }

         _ButtonPanel.Paint += OnButtonPanelPaint;
         _Btn1.Click += OnButtonClick;
         _Btn2.Click += OnButtonClick;
         _Btn3.Click += OnButtonClick;
      }

      void OnButtonPanelPaint(object sender, PaintEventArgs e)
      {
         e.Graphics.DrawLine(SystemPens.ControlLight, 0, 0, _ButtonPanel.Width, 0);
      }

      void OnButtonClick(object sender, EventArgs e)
      {
         Button btn = (Button)sender;
         Result = btn.Text;
         DialogResult = btn == _Btn3 ? DialogResult.Cancel : DialogResult.OK;
         Close();
      }
   }
}
