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
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProgDev.FrontEnd.Common.Toolkit
{
   public static class NativeMethods
   {
      [DllImport("user32.dll", SetLastError = true, EntryPoint = "GetScrollBarInfo")]
      private static extern int GetScrollBarInfo(IntPtr hWnd, uint idObject, ref SCROLLBARINFO psbi);

      [StructLayout(LayoutKind.Sequential)]
      private struct RECT
      {
         public Int32 left;
         public Int32 top;
         public Int32 right;
         public Int32 bottom;
      }

      [StructLayout(LayoutKind.Sequential)]
      private struct SCROLLBARINFO
      {
         public UInt32 cbSize;
         public RECT rcScrollBar;
         public int dxyLineButton;
         public int xyThumbTop;
         public int xyThumbBottom;
         public int reserved;
         [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
         public UInt32[] rgstate;
      }

      private const uint OBJID_HSCROLL = 0xFFFFFFFA;
      private const uint OBJID_VSCROLL = 0xFFFFFFFB;

      private const uint STATE_SYSTEM_INVISIBLE = 0x00008000;

      private static Exception LastWin32Error()
      {
         return new Exception(string.Format(Strings.ErrorWin32, Marshal.GetLastWin32Error()));
      }

      public static bool IsVScrollBarVisible(Control control)
      {
         var scrollbarInfo = new SCROLLBARINFO();
         scrollbarInfo.cbSize = (UInt32)Marshal.SizeOf(scrollbarInfo);
         int result = GetScrollBarInfo(control.Handle, NativeMethods.OBJID_VSCROLL, ref scrollbarInfo);
         if (result == 0)
            throw LastWin32Error();
         else
            return scrollbarInfo.rgstate[0] != STATE_SYSTEM_INVISIBLE;
      }

   }
}
