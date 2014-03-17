// OSPASOFT
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

#include "FeUserInterface.h"
#include "FeTaskPropertiesWindow.h"
#include "FeAboutWindow.h"
#include "FeProgramWindow.h"

FeProgramWindow::FeProgramWindow()
:  _TaskPropertiesWindow(std::make_shared<FeTaskPropertiesWindow>()),
   _AboutWindow(std::make_shared<FeAboutWindow>())
{
   W_SET_HANDLER(FeProgramWindow, _View.AboutMnu.Clicked, OnAboutClicked);
}

void FeProgramWindow::OnAboutClicked(SpEventArgs& e)
{
   _AboutWindow->CenterIn(*this);
   _AboutWindow->Show();
}
