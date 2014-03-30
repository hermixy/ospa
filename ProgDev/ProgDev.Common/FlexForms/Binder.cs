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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgDev.Common.FlexForms
{
   public static class Binder
   {
      public static EventHandler Bind<T>(Field<T> property, Func<T> accessor, Action<T> mutator)
      {
         bool ignoreChangedEvent = false;

         // Initialize the property by reading from the form.  The view model's Begin() method may override this later,
         // or it may choose to accept the value set by the form.
         property.Value = accessor();

         property.Changed += (sender, e) =>
         {
            if (!ignoreChangedEvent)
               mutator(property.Value);
         };

         return (sender, e) =>
         {
            ignoreChangedEvent = true;
            try
            {
               property.Value = accessor();
            }
            finally
            {
               ignoreChangedEvent = false;
            }
         };
      }

      public static void BindText(this Control control, Field<string> property)
      {
         control.TextChanged += Bind(property, () => control.Text, x => control.Text = x);
      }
      
      public static void BindVisible(this Control control, Field<bool> property)
      {
         control.VisibleChanged += Bind(property, () => control.Visible, x => control.Visible = x);
      }

      public static void BindEnabled(this Control control, Field<bool> property)
      {
         control.EnabledChanged += Bind(property, () => control.Enabled, x => control.Enabled = x);
      }

      public static void BindChecked(this CheckBox control, Field<bool> property)
      {
         control.CheckedChanged += Bind(property, () => control.Checked, x => control.Checked = x);
      }

      public static void BindChecked(this RadioButton control, Field<bool> property)
      {
         control.CheckedChanged += Bind(property, () => control.Checked, x => control.Checked = x);
      }

      public static void BindClick(this Button control, Signal command)
      {
         control.Click += command;
      }
   }
}
