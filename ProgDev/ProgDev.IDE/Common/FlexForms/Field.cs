﻿// OSPA ProgDev
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

namespace ProgDev.IDE.Common.FlexForms
{
   public abstract class Field
   {
      public event EventHandler Changed;

      protected void Notify()
      {
         if (Changed != null)
            Changed(this, EventArgs.Empty);
      }

      public abstract void SetValue(object value);
   }

   public class Field<T> : Field
   {
      protected T _Value;

      public override void SetValue(object value)
      {
         Value = (T)value;
      }

      public virtual T Value
      {
         get
         {
            return _Value;
         }
         set
         {
            _Value = value;
            Notify();
         }
      }
   }
}
