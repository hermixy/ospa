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

using ProgDev.BusinessLogic;
using ProgDev.Domain;
using ProgDev.FrontEnd.Common;
using ProgDev.FrontEnd.Common.FlexForms;
using ProgDev.Resources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgDev.FrontEnd.Forms
{
   public sealed class ProjectContentFormViewModel : FormViewModel
   {
      private readonly Action<IReadOnlyList<PouReference>> _OnOpenFiles;

      // List view
      public ListField<ListViewRow> List;
      public ListField<ListViewRow> SelectedList;
      public Signal ItemActivate;
      // Context menu
      public ComputedField<bool> ContextMenuEnabled;
      public ComputedField<bool> RenameEnabled;
      public Signal RenameClick;
      public Signal MoveClick;
      public Signal DeleteClick;
      public Signal DuplicateClick;
      
      public ProjectContentFormViewModel(Action<IReadOnlyList<PouReference>> onOpenFiles)
      {
         _OnOpenFiles = onOpenFiles;
      }

      protected override void Initialize()
      {
         Populate();
         Project.Events.Changed += () => Populate();
      }

      private void Populate()
      {
         List.Set(Project.Contents.Files.Select(x => new ListViewRow
         {
            Icon = Images.Pou16,
            GroupName = x.Folder,
            Cells = new List<string> { x.Name, x.Type.ToShortString() },
            Tag = x
         }));
      }

      [Compute("ContextMenuEnabled"), Depends("SelectedList")]
      private bool ComputeContextMenuEnabled()
      {
         return SelectedList.Any();
      }

      [Compute("RenameEnabled"), Depends("SelectedList")]
      private bool ComputeRenameEnabled()
      {
         return SelectedList.Count == 1;
      }

      [OnSignal("RenameClick")]
      private void OnRenameClick()
      {
         var file = (Project.File)SelectedList.Single().Tag;
         ShowChildDialog(FormsFactory.NewRenameFileForm(file));
      }

      [OnSignal("MoveClick")]
      private void OnMoveClick()
      {
         var files = SelectedList.Select(x => x.Tag).Cast<Project.File>();
         ShowChildDialog(FormsFactory.NewMoveFileForm(files));
      }

      [OnSignal("DeleteClick")]
      private void OnDeleteClick()
      {
         var files = SelectedList.Select(x => x.Tag).Cast<Project.File>();
         Project.Commands.DeleteFiles(files);
      }

      [OnSignal("DuplicateClick")]
      private void OnDuplicateClick()
      {
         var files = SelectedList.Select(x => x.Tag).Cast<Project.File>();
         Project.Commands.DuplicateFiles(files);
      }

      [OnSignal("ItemActivate")]
      private void OnItemActivate()
      {
         if (SelectedList.Any())
         {
            _OnOpenFiles(
               SelectedList
               .Select(x => x.Tag)
               .Cast<Project.File>()
               .Select(x => new PouReference(x.Folder, x.Name))
               .ToList());
         }
      }
   }
}
