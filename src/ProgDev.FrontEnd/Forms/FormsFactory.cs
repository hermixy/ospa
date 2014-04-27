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
using ProgDev.FrontEnd.Controllers;
using ProgDev.FrontEnd.Controls;
using ProgDev.Resources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgDev.FrontEnd.Forms
{
   public static class FormsFactory
   {
      public static AppForm NewAppForm(string filePath = null)
      {
         AppForm appForm = null; // will assign below
         Func<Project.File, EditorForm> doOpenFile = null; // will assign below
         var openEditorController = new OpenEditorController(x => doOpenFile(x));
         var projectContentFormViewModel = new ProjectContentFormViewModel(openEditorController);
         var projectContentForm = new ProjectContentForm(projectContentFormViewModel);
         var findForm = new SearchResultsForm();
         appForm = new AppForm(new AppFormViewModel(filePath), projectContentForm, findForm, out doOpenFile);
         return appForm;
      }

      public static MessageForm NewErrorForm(string message)
      {
         return new MessageForm(message, Strings.ErrorTitle, icon: Images.Error32);
      }
      
      public static AboutForm NewAboutForm()
      {
         return new AboutForm(new AboutFormViewModel());
      }

      public static NewFileForm NewNewFileForm(string name)
      {
         return new NewFileForm(new NewFileFormViewModel(name));
      }

      public static RenameFileForm NewRenameFileForm(Project.File file)
      {
         return new RenameFileForm(new RenameFileFormViewModel(file));
      }

      public static MoveFileForm NewMoveFileForm(IEnumerable<Project.File> files)
      {
         return new MoveFileForm(new MoveFileFormViewModel(files.ToList()));
      }

      public static EditorForm NewEditorForm(Project.File file)
      {
         switch (file.Language)
         {
            // Graphical languages
            case PouLanguage.FunctionBlockDiagram: //TODO: Use FBD editor control
               return new EditorForm(new SplitEditorControl(new CodeEditorControl(), new CodeEditorControl()), file);
            case PouLanguage.LadderDiagram: //TODO: Use LD editor control
               return new EditorForm(new SplitEditorControl(new CodeEditorControl(), new CodeEditorControl()), file);
            case PouLanguage.SequentialFunctionChart: //TOOD: Use SFC editor control
               return new EditorForm(new SplitEditorControl(new CodeEditorControl(), new CodeEditorControl()), file);
            // Textual languages
            case PouLanguage.InstructionList:
               return new EditorForm(new CodeEditorControl(), file);
            case PouLanguage.StructuredText:
               return new EditorForm(new CodeEditorControl(), file);
            // Invalid value
            default:
               throw new ArgumentOutOfRangeException("file");
         }
      }
   }
}
