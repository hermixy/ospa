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

#include <FL/Fl.H>
#include <FL/Fl_Double_Window.H>
#include <FL/Fl_Return_Button.H>
#include <FL/Fl_Menu_Item.H>
#include <FL/Fl_Tabs.H>
#include "SpEvent.h"

/// Event arguments object containing a `Handled` flag.
class FxEventArgs : public SpEventArgs
{
public:
   FxEventArgs();
   bool Handled;
};

/// Extended version of `Fl_Menu_Item`.
class FxMenuItem
{
public:
   /// Attaches to an `Fl_Menu_Item`.
   void Attach(Fl_Menu_Item* flMenuItem);

   /// Fired when the user clicks the menu item.
   SpEvent<SpEventArgs> Clicked;

private:
   static void StaticCallback(Fl_Widget*, void* ptr);
};

/// Extended version of `Fl_Double_Window`.
class FxWindow : public Fl_Double_Window
{
public:
   /// Constructor.
   /// \param W Width.
   /// \param H Height.
   /// \param l Label.
   FxWindow(int W, int H, const char* l = 0);

   /// Constructor.
   /// \param X Left coordinate.
   /// \param Y Top coordinate.
   /// \param W Width.
   /// \param H Height.
   /// \param l Label.
   FxWindow(int X, int Y, int W, int H, const char* l = 0);

   /// Handles an FLTK event.
   /// \param event Event type.
   /// \return 0 = unhandled, 1 = handled
   virtual int handle(int event);
};

/// Extended version of `Fl_Return_Button`.
class FxReturnButton : public Fl_Return_Button
{
public:
   /// Constructor.
   /// \param X Left coordinate.
   /// \param Y Top coordinate.
   /// \param W Width.
   /// \param H Height.
   /// \param l Label.
   FxReturnButton(int X, int Y, int W, int H, const char* l = 0);

   /// Handles an FLTK event.
   /// \param event Event type.
   /// \return 0 = unhandled, 1 = handled
   virtual int handle(int event);

   /// Fired when the user clicks the button.
   SpEvent<SpEventArgs> Clicked;

private:
   static void StaticCallback(Fl_Widget*, void* ptr);
};

/// Extended version of `Fl_Button`.
class FxButton : public Fl_Button
{
public:
   /// Constructor.
   /// \param X Left coordinate.
   /// \param Y Top coordinate.
   /// \param W Width.
   /// \param H Height.
   /// \param l Label.
   FxButton(int X, int Y, int W, int H, const char* l = 0);

   /// Handles an FLTK event.
   /// \param event Event type.
   /// \return 0 = unhandled, 1 = handled
   virtual int handle(int event);

   /// Fired when the user clicks the button.
   SpEvent<SpEventArgs> Clicked;

private:
   static void StaticCallback(Fl_Widget*, void* ptr);
};

/// Extended version of `Fl_Tabs`.
class FxTabs : public Fl_Tabs
{
public:
   /// Constructor.
   /// \param X Left coordinate.
   /// \param Y Top coordinate.
   /// \param W Width.
   /// \param H Height.
   /// \param l Label.
   FxTabs(int X, int Y, int W, int H, const char* l = 0);

   /// Handles an FLTK event.
   /// \param event Event type.
   /// \return 0 = unhandled, 1 = handled
   virtual int handle(int event);

   /// Fired when the user selects a different tab.
   SpEvent<SpEventArgs> SelectedTabChanged;

private:
   static void StaticCallback(Fl_Widget*, void* ptr);
};
