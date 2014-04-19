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

using ProgDev.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProgDev.FrontEnd.Forms
{
   public partial class MessageForm : Form
   {
      public string Result { get; private set; }

      public static MessageForm ErrorBox(string message, string detail = null)
      {
         return new MessageForm(message, Strings.ErrorTitle, detail: detail);
      }

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
