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

#include "UserInterface.h"
#include "NewTaskWindowDriver.h"

NewTaskWindowDriver::NewTaskWindowDriver()
{
   WD_REGISTER(ActivationCmb);
   WD_REGISTER(OkBtn);
   WD_REGISTER(CancelBtn);
}

void NewTaskWindowDriver::OnCallback(void* widget)
{
   WD_CALLBACK(ActivationCmb);
   WD_CALLBACK(OkBtn);
   WD_CALLBACK(CancelBtn);
}

void NewTaskWindowDriver::OnActivationCmb()
{
}

void NewTaskWindowDriver::OnOkBtn()
{
}

void NewTaskWindowDriver::OnCancelBtn()
{
   _Window.FlWindow->hide();
}