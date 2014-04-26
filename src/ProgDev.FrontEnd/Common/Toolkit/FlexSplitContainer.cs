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

using System.Drawing;
using System.Windows.Forms;

namespace ProgDev.FrontEnd.Common.Toolkit
{
   public sealed class FlexSplitContainer : SplitContainer
   {
      protected override void OnLayout(LayoutEventArgs e)
      {
         base.OnLayout(e);
         Invalidate(SplitterRectangle);
      }

      protected override void OnPaint(PaintEventArgs e)
      {
         base.OnPaint(e);
         var bgRect = SplitterRectangle;
         if (Orientation == Orientation.Horizontal)
         {
            bgRect.Y++;
            bgRect.Height -= 2;
         }
         else
         {
            bgRect.X++;
            bgRect.Width -= 2;
         }
         e.Graphics.FillRectangle(SystemBrushes.Control, bgRect);

         var borderRect = SplitterRectangle;
         if (Orientation == Orientation.Horizontal)
         {
            borderRect.X -= 1;
            borderRect.Width += 2;
            borderRect.Height -= 1;
         }
         else
         {
            borderRect.Y -= 1;
            borderRect.Height += 2;
            borderRect.Width -= 2;
         }
         e.Graphics.DrawRectangle(SystemPens.ControlDark, borderRect);
      }

   }
}
