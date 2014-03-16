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

#include <vector>
#include <memory>
#include <stdio.h> //temp

template<class WindowType>
class WindowDriver
{
public:
   WindowDriver() 
   {
   }
   
   virtual ~WindowDriver() 
   {
   }
   
   virtual void Show() 
   { 
      _Window.FlWindow->show(0, NULL); 
   }

private:
   class Registration
   {
   public:
      WindowDriver* Driver;
      void* Widget;
   };
   
   std::vector<Registration*> _Registrations;
   
protected:
   static void Callback(class Fl_Widget* widget, void* self)
   {
      Registration* r = static_cast<Registration*>(self);
      r->Driver->OnCallback(r->Widget);
   }

   template<class WidgetType>
   void Register(WidgetType* widget)
   {
      Registration* r = new Registration;
      r->Driver = this;
      r->Widget = widget;
      _Registrations.push_back(r);
      widget->callback(Callback, r);
   }
   
   virtual void OnCallback(void* widget)
   {
   }

   WindowType _Window;
};

template<class WindowDriverType>
class CallbackDefinition
{
public:
   WindowDriverType* WindowDriver;
   void* Widget;
};

// Optional macros for handling FLTK callbacks in member functions.

// Call this from the constructor.
#define WD_INIT() _WD_MemberCallback(NULL)

// Add these to the header, as the first thing inside the braces of the class.
#define WD_BEGIN_CALLBACKS(className) \
   std::vector<std::shared_ptr<CallbackDefinition< className >>> _WD_CallbackDefinitions; \
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
   if (widget == NULL) \
   { \
      auto cbDefPtr = _WD_NewCallbackDefinition(); \
      cbDefPtr->WindowDriver = this; \
      cbDefPtr->Widget = _Window. widgetName ; \
      _WD_CallbackDefinitions.push_back(cbDefPtr); \
      _Window. widgetName ->callback(_WD_StaticCallback, cbDefPtr.get()); \
   } \
   else if (widget == _Window. widgetName) \
   { \
      methodName (); \
      return; \
   }

#define WD_END_CALLBACKS() \
   }

