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
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProgDev.IDE.Common.FlexForms
{
   public static class Binder
   {
      public static EventHandler Bind<T>(Field<T> field, Func<T> accessor, Action<T> mutator)
      {
         bool ignoreChangedEvent = false;

         // Initialize the property by reading from the form.  The view model's Initialize() method may override this 
         // later, or it may choose to accept the value set by the form.
         field.Value = accessor();

         field.Changed += (sender, e) =>
         {
            if (!ignoreChangedEvent)
               mutator(field.Value);
         };

         return (sender, e) =>
         {
            ignoreChangedEvent = true;
            try
            {
               field.Value = accessor();
            }
            finally
            {
               ignoreChangedEvent = false;
            }
         };
      }

      public static void BindText(this Control control, Field<string> field)
      {
         control.TextChanged += Bind(field, () => control.Text, x => control.Text = x);
      }
      
      public static void BindVisible(this Control control, Field<bool> field)
      {
         control.VisibleChanged += Bind(field, () => control.Visible, x => control.Visible = x);
      }

      public static void BindEnabled(this Control control, Field<bool> field)
      {
         control.EnabledChanged += Bind(field, () => control.Enabled, x => control.Enabled = x);
      }

      public static void BindChecked(this CheckBox control, Field<bool> field)
      {
         control.CheckedChanged += Bind(field, () => control.Checked, x => control.Checked = x);
      }

      public static void BindChecked(this RadioButton control, Field<bool> field)
      {
         control.CheckedChanged += Bind(field, () => control.Checked, x => control.Checked = x);
      }

      public static void BindLocation(this Control control, Field<Point> field)
      {
         control.LocationChanged += Bind(field, () => control.Location, x => control.Location = x);
      }

      public static void BindSize(this Control control, Field<Size> field)
      {
         control.SizeChanged += Bind(field, () => control.Size, x => control.Size = x);
      }

      public static void BindError(this ErrorProvider control, Control target, Field<string> field)
      {
         // This is a read-only control, so there's no event.
         Bind(field, () => control.GetError(target), x => control.SetError(target, x));
      }

      public static void BindError(this Control target, ErrorProvider control, Field<string> field)
      {
         // This is a read-only control, so there's no event.
         Bind(field, () => control.GetError(target), x => control.SetError(target, x));
      }

      public static void BindMinimumSize(this Control control, Field<Size> field)
      {
         // There is no MinimumSizeChanged event.
         Bind(field, () => control.MinimumSize, x => control.MinimumSize = x);
      }

      public static void BindMaximumSize(this Control control, Field<Size> field)
      {
         // There is no MaximumSizeChanged event.
         Bind(field, () => control.MaximumSize, x => control.MaximumSize = x);
      }

      public static void BindClick(this Control control, Signal command)
      {
         control.Click += command;
      }

      public static void BindClick(this ToolStripButton control, Signal command)
      {
         control.Click += command;
      }

      public static void BindClosing(this Form control, Signal command)
      {
         control.FormClosing += (sender, e) => command.Handler(sender, e);
      }

      public static void BindItems(this ComboBox control, ListField<string> field)
      {
         control.Items.AddRange(field.ToArray());

         field.Changed += (sender, e) =>
         {
            int selectedIndex = control.SelectedIndex;
            control.BeginUpdate();
            control.Items.Clear();
            control.Items.AddRange(field.ToArray());
            control.SelectedIndex = Math.Min(control.Items.Count - 1, selectedIndex);
            control.EndUpdate();
         };
      }

      public static void BindSelectedIndex(this ComboBox control, Field<int> field)
      {
         control.SelectedIndexChanged += Bind(field, () => control.SelectedIndex, x => control.SelectedIndex = x);
      }
   }
}
