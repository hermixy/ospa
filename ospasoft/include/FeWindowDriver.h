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

#include <list>
#include <memory>
#include "FeRect.h"
#include "SpEvent.h"

class FeWindowDriverBase
{
public:
   virtual ~FeWindowDriverBase() {}
   virtual void Show() = 0;
   virtual void Close() = 0;
   virtual FeRect Bounds() const = 0;
   virtual void Bounds(const FeRect& rect) = 0;
   virtual void CenterIn(const FeWindowDriverBase& parent) = 0;

   SpEvent<SpEventArgs> Shown;
   SpEvent<SpEventArgs> Closed;
};

template<typename WindowType>
class FeWindowDriver : public FeWindowDriverBase
{
public:
   FeWindowDriver()
   {
   }
   
   virtual ~FeWindowDriver() 
   {
   }
   
   virtual void Show() 
   { 
      _Window.FlWindow->show(0, NULL); 
      SpEventArgs e;
      Shown.Fire(e);
   }

   virtual void Close()
   {
      _Window.FlWindow->hide();
      SpEventArgs e;
      Closed.Fire(e);
   }

   virtual FeRect Bounds() const
   {
      auto fl = _Window.FlWindow;
      return FeRect(fl->x(), fl->y(), fl->w(), fl->h());
   }

   virtual void Bounds(const FeRect& rect)
   {
      _Window.FlWindow->resize(rect.X, rect.Y, rect.W, rect.H);
   }

   virtual void CenterIn(const FeWindowDriverBase& parent)
   {
      Bounds(Bounds().CenterIn(parent.Bounds()));
   }

protected:
   mutable WindowType _Window;
};

/*** Optional macros for simplifying the mapping of FLTK callbacks to member functions. ******************************/

template<typename WindowDriverType>
class CallbackDefinition
{
public:
   WindowDriverType* WindowDriver;
   void* Widget;
};

// Call this from the constructor.
#define WD_INIT() _WD_MemberCallback(this)

// Add these to the header, as the first thing inside the braces of the class.
#define WD_BEGIN_CALLBACKS(className) \
   private: \
   std::list<std::shared_ptr<CallbackDefinition< className >>> _WD_CallbackDefinitions; \
   static void _WD_StaticCallback(class Fl_Widget* widget, void* ptr) \
   { \
      auto cbDef = static_cast<CallbackDefinition< className >*>(ptr); \
      cbDef->WindowDriver->_WD_MemberCallback(cbDef->Widget); \
   } \
   std::shared_ptr<CallbackDefinition< className >> _WD_NewCallbackDefinition() \
   { \
      return std::make_shared<CallbackDefinition< className >>(); \
   } \
   void _WD_MemberCallback(void* widget) \
   {

#define WD_CALLBACK(widgetName, methodName) \
   if (widget == this) \
   { \
      auto cbDefPtr = _WD_NewCallbackDefinition(); \
      cbDefPtr->WindowDriver = this; \
      cbDefPtr->Widget = _Window. widgetName ; \
      _WD_CallbackDefinitions.push_front(cbDefPtr); \
      _Window. widgetName ->callback(_WD_StaticCallback, cbDefPtr.get()); \
   } \
   else if (widget == _Window. widgetName) \
   { \
      methodName (); \
      return; \
   }

#define WD_END_CALLBACKS() \
   }
