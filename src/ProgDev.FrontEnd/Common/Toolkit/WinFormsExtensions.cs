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
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProgDev.FrontEnd.Common.Toolkit
{
   public static class WinFormsExtensions
   {
      private static void SetColumnWidths(this ListView control, ColumnHeader variableColumn, 
         IEnumerable<ColumnHeader> fixedColumns)
      {
         // Note:
         // If BeginUpdate/EndUpdate are not used here, there is an issue:
         // - The user resizes the form such that the previous column widths would require a horizontal scrollbar.
         // - This method is executed in response to the SizeChanged event, shrinking the variable column's width.
         // - Despite the fact that the columns now fit, the ListView shows a horizontal scrollbar.  It goes away
         //   on the next resize, as long as that resize doesn't again shrink the ListView below the current columns
         //   width.
         // The BeginUpdate/EndUpdate seems to resolve that issue, but there is still sometimes a brief flash of
         // the horizontal scrollbar.  Good enough for government work.

         control.BeginUpdate();
         try
         {
            int fixedColumnsWidth = fixedColumns.Select(x => x.Width).Sum();
            int variableColumnWidth = control.Width - fixedColumnsWidth;

            if (control.IsVScrollBarVisible())
               variableColumnWidth -= SystemInformation.VerticalScrollBarWidth;

            variableColumn.Width = variableColumnWidth;
         }
         finally
         {
            control.EndUpdate();
         }
      }

      public static void AutoSizeColumnWidths(this ListView control, ColumnHeader variableColumn)
      {
         var fixedColumns = control.Columns.Cast<ColumnHeader>().Where(x => x != variableColumn).ToList();
         control.SizeChanged += (sender, e) => control.SetColumnWidths(variableColumn, fixedColumns);
      }

      public static bool IsVScrollBarVisible(this ListView control)
      {
         var scrollbarInfo = new NativeMethods.SCROLLBARINFO();
         scrollbarInfo.cbSize = (UInt32)Marshal.SizeOf(scrollbarInfo);
         int result = NativeMethods.GetScrollBarInfo(control.Handle, NativeMethods.OBJID_VSCROLL, ref scrollbarInfo);
         if (result == 0)
            throw new Exception("Win32 error: " + Marshal.GetLastWin32Error());
         else
            return scrollbarInfo.rgstate[0] != NativeMethods.STATE_SYSTEM_INVISIBLE;
      }
   }
}
