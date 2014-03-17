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
#include "SpEvent.h"

class FxEventArgs : public SpEventArgs
{
public:
   FxEventArgs();
   bool Handled;
};

class FxMenuItem
{
public:
   void Attach(Fl_Menu_Item* flMenuItem);

   SpEvent<SpEventArgs> Clicked;

private:
   static void StaticCallback(Fl_Widget*, void* ptr);
};

class FxWindow : public Fl_Double_Window
{
public:
   FxWindow(int W, int H, const char* l = 0);
   FxWindow(int X, int Y, int W, int H, const char* l = 0);
   virtual int handle(int event);
};

class FxReturnButton : public Fl_Return_Button
{
public:
   FxReturnButton(int X, int Y, int W, int H, const char* l = 0);
   virtual int handle(int event);

   SpEvent<SpEventArgs> Clicked;

private:
   static void StaticCallback(Fl_Widget*, void* ptr);
};

class FxButton : public Fl_Button
{
public:
   FxButton(int X, int Y, int W, int H, const char* l = 0);
   virtual int handle(int event);

   SpEvent<SpEventArgs> Clicked;

private:
   static void StaticCallback(Fl_Widget*, void* ptr);
};
