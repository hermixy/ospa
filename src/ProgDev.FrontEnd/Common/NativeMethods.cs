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
using System.Runtime.InteropServices;

namespace ProgDev.FrontEnd.Common
{
   public static class NativeMethods
   {
      [DllImport("user32.dll", SetLastError = true, EntryPoint = "GetScrollBarInfo")]
      public static extern int GetScrollBarInfo(IntPtr hWnd, uint idObject, ref SCROLLBARINFO psbi);

      [StructLayout(LayoutKind.Sequential)]
      public struct RECT
      {
         public Int32 left;
         public Int32 top;
         public Int32 right;
         public Int32 bottom;
      }

      [StructLayout(LayoutKind.Sequential)]
      public struct SCROLLBARINFO
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

      public const uint OBJID_HSCROLL = 0xFFFFFFFA;
      public const uint OBJID_VSCROLL = 0xFFFFFFFB;

      public const uint STATE_SYSTEM_INVISIBLE = 0x00008000;

   }
}
