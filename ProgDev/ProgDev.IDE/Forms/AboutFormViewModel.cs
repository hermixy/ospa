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

using ProgDev.IDE.Common.FlexForms;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProgDev.IDE.Forms
{
   public sealed class AboutFormViewModel : FormViewModel
   {
      public Field<string> VersionText;
      public Signal GitHubClick;
      public Signal FarmFreshClick;
      public Signal FatCowClick;
      public Signal CreativeCommonsClick;
      public Signal DockPanelClick;
      public Signal AntlrClick;
      public Signal CloseClick;

      protected override void Initialize()
      {
         VersionText.Value = string.Format(Strings.AboutVersionFormat, Application.ProductVersion);
      }

      [OnSignal("CloseClick")]
      public void OnCloseClick()
      {
         Close();
      }

      [OnSignal("GitHubClick")]
      public void OnGitHubClick()
      {
         Process.Start("https://github.com/electroly/ospa");
      }

      [OnSignal("FarmFreshClick")]
      public void OnFarmFreshClick()
      {
         Process.Start("http://www.fatcow.com/free-icons");
      }

      [OnSignal("FatCowClick")]
      public void OnFatCowClick()
      {
         Process.Start("http://www.fatcow.com/");
      }

      [OnSignal("CreativeCommonsClick")]
      public void OnCreativeCommonsClick()
      {
         Process.Start("http://creativecommons.org/licenses/by/3.0/us/");
      }

      [OnSignal("DockPanelClick")]
      public void OnDockPanelClick()
      {
         Process.Start("http://dockpanelsuite.com/");
      }

      [OnSignal("AntlrClick")]
      public void OnAntlrClick()
      {
         Process.Start("http://www.antlr.org/");
      }
   }
}
