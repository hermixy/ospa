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

#pragma once

#include "FeWindowDriver.h"

class FeProgramWindowDriver : public FeWindowDriver<class ProgramWindow>
{
   WD_BEGIN_CALLBACKS(FeProgramWindowDriver)
   WD_CALLBACK(NewProgramMnu, OnNewProgramClicked)
   WD_CALLBACK(AboutMnu, OnAboutClicked)
   WD_END_CALLBACKS()

public:
   FeProgramWindowDriver();

private:
   void OnNewProgramClicked();
   void OnAboutClicked();

   std::shared_ptr<class FeAboutWindowDriver> _FeAboutWindowDriver;
};
