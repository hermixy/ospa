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

#include "FxToolkit.h"

#define FX_BEGIN_HANDLE(className, superclassName) \
   int className ::handle(int event) \
   { \
      if (event < 0) \
         return superclassName ::handle(-event); \
      switch (event) \
      { \
         default: \
            return superclassName ::handle(event);

#define FX_HANDLE_EVENT(fltkEventType, spEventObj) \
         case fltkEventType : \
         { \
            FxEventArgs e; \
            spEventObj .Fire(e); \
            if (e.Handled) \
               return 1; \
            else \
               return handle(-event); \
         }

#define FX_END_HANDLE() \
      } \
   }

#define FX_CALLBACK(className, spEventObj) \
   void className ::StaticCallback(Fl_Widget*, void* ptr) \
   { \
      className * self = static_cast< className *>(ptr); \
      SpEventArgs e; \
      self-> spEventObj .Fire(e); \
   }

#define FX_CONSTRUCTOR(className, superclassName) \
   className :: className(int X, int Y, int W, int H, const char* l) \
   : superclassName (X, Y, W, H, l) \
   { \
   }

#define FX_CONSTRUCTOR_CB(className, superclassName) \
   className :: className(int X, int Y, int W, int H, const char* l) \
   : superclassName (X, Y, W, H, l) \
   { \
      callback(StaticCallback, this); \
   }

FxEventArgs::FxEventArgs() : Handled(false) {}

//
// FxMenuItem
//
void FxMenuItem::Attach(Fl_Menu_Item* flMenuItem)
{
   flMenuItem->callback(StaticCallback, this);
}

void FxMenuItem::StaticCallback(Fl_Widget*, void* ptr)
{
   SpEventArgs e;
   ((FxMenuItem*)ptr)->Clicked.Fire(e);
}

//
// FxWindow
//
FxWindow::FxWindow(int W, int H, const char* l) 
: Fl_Double_Window(W, H, l) 
{
}

FX_CONSTRUCTOR(FxWindow, Fl_Double_Window)
FX_BEGIN_HANDLE(FxWindow, Fl_Double_Window)
FX_END_HANDLE()

//
// FxReturnButton
//
FX_CONSTRUCTOR_CB(FxReturnButton, Fl_Return_Button)
FX_BEGIN_HANDLE(FxReturnButton, Fl_Return_Button)
FX_END_HANDLE()
FX_CALLBACK(FxReturnButton, Clicked)

//
// FxButton
//
FX_CONSTRUCTOR_CB(FxButton, Fl_Button)
FX_BEGIN_HANDLE(FxButton, Fl_Button)
FX_END_HANDLE()
FX_CALLBACK(FxButton, Clicked)

//
// FxTabs
//
FX_CONSTRUCTOR_CB(FxTabs, Fl_Tabs)
FX_BEGIN_HANDLE(FxTabs, Fl_Tabs)
FX_END_HANDLE()
FX_CALLBACK(FxTabs, ValueChanged)
