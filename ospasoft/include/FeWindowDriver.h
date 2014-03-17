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
#include "SpEvent.h"
#include "FeRect.h"
#include "FeWindowDriverBase.h"
#include "FeCallbackDefinition.h"

/// Templated window driver which is attached to a FLTK window class specified in the `WindowType` template argument.
template<typename WindowType>
class FeWindowDriver : public FeWindowDriverBase
{
public:
   /// Constructor.
   FeWindowDriver()
   {
   }
   
   /// Destructor.
   virtual ~FeWindowDriver() 
   {
   }
   
   /// Shows the window.
   virtual void Show() 
   { 
      _Window.FlWindow->show(0, NULL); 
      SpEventArgs e;
      Shown.Fire(e);
   }

   /// Closes the window.  It may be shown again later.
   virtual void Close()
   {
      _Window.FlWindow->hide();
      SpEventArgs e;
      Closed.Fire(e);
   }

   /// Gets the screen-relative bounds of the window.
   /// \return Bounds.
   virtual FeRect Bounds() const
   {
      auto fl = _Window.FlWindow;
      return FeRect(fl->x(), fl->y(), fl->w(), fl->h());
   }

   /// Sets the screen-relative bounds of the window.
   /// \param rect New bounds.
   virtual void Bounds(const FeRect& rect)
   {
      _Window.FlWindow->resize(rect.X, rect.Y, rect.W, rect.H);
   }

   /// Moves the window so that it is centered within `parent`.
   /// \param parent Parent window in which to center this window.
   virtual void CenterIn(const FeWindowDriverBase& parent)
   {
      Bounds(Bounds().CenterIn(parent.Bounds()));
   }

protected:
   /// FLTK window object.
   mutable WindowType _Window;
};

/*** Optional macros for simplifying the mapping of FLTK callbacks to member functions. ******************************/

// Call this from the constructor.
#define WD_INIT() _WD_MemberCallback(this)

// Add these to the header, as the first thing inside the braces of the class.
#define WD_BEGIN_CALLBACKS(className) \
   private: \
   std::list<std::shared_ptr<FeCallbackDefinition< className >>> _WD_CallbackDefinitions; \
   static void _WD_StaticCallback(class Fl_Widget* widget, void* ptr) \
   { \
      auto cbDef = static_cast<FeCallbackDefinition< className >*>(ptr); \
      cbDef->WindowDriver->_WD_MemberCallback(cbDef->Widget); \
   } \
   std::shared_ptr<FeCallbackDefinition< className >> _WD_NewCallbackDefinition() \
   { \
      return std::make_shared<FeCallbackDefinition< className >>(); \
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
