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

using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows.Forms;

namespace ProgDev.FrontEnd.Common
{
   public static class TaskDialogFactory
   {
      public static TaskDialog NewTaskDialog(Form owner, string caption, TaskDialogStandardIcon icon, 
         string instructionText, TaskDialogStandardButtons standardButtons, string detail = null)
      {
         var taskDialog = new TaskDialog
         { 
            OwnerWindowHandle = owner.Handle,
            Caption = caption,
            Icon = icon,
            InstructionText = instructionText,
            StandardButtons = standardButtons,
         };

         if (detail != null)
            taskDialog.Text = detail;
         
         // This addresses an issue with the Windows API Code Pack which prevents icons from displaying in the Task 
         // Dialog.
         taskDialog.Opened += (sender, e) =>
         {
            taskDialog.Icon = taskDialog.Icon;
            taskDialog.FooterIcon = taskDialog.FooterIcon;
         };
         
         return taskDialog;
      }
   }
}
