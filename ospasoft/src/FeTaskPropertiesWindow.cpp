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

#include "System.h"
#include "FeUserInterface.h"
#include "FeTaskPropertiesWindow.h"

#define ACT_CONTINUOUS  0
#define ACT_CYCLIC      1
#define ACT_MANUAL      2

FeTaskPropertiesWindow::FeTaskPropertiesWindow()
{
   W_SET_HANDLER(FeTaskPropertiesWindow, _View.OkBtn->Clicked, OnOkClicked);
   W_SET_HANDLER(FeTaskPropertiesWindow, _View.CancelBtn->Clicked, OnCancelClicked);
   W_SET_HANDLER(FeTaskPropertiesWindow, _View.ActivationCmb->SelectedIndexChanged, OnSelectedActivationChanged);

   _View.ActivationCmb->add("Continuous");
   _View.ActivationCmb->add("Cyclic");
   _View.ActivationCmb->add("Manual");
   _View.ActivationCmb->value(0);

   _View.LanguageCmb->add("Ladder diagram");
   _View.LanguageCmb->add("Function block diagram");
   _View.LanguageCmb->add("Structured text");
   _View.LanguageCmb->add("Instruction list");
   _View.LanguageCmb->add("Sequential function chart");
   _View.LanguageCmb->value(0);

   _View.IntervalTxt->hide();
   _View.MsLbl->hide();
}

void FeTaskPropertiesWindow::OnSelectedActivationChanged(SpEventArgs& e)
{
   if (_View.ActivationCmb->value() == ACT_CYCLIC)
   {
      _View.IntervalTxt->show();
      _View.MsLbl->show();
   }
   else
   {
      _View.IntervalTxt->hide();
      _View.MsLbl->hide();
   }
}

void FeTaskPropertiesWindow::OnOkClicked(SpEventArgs& e)
{
}

void FeTaskPropertiesWindow::OnCancelClicked(SpEventArgs& e)
{
   Close();
}
