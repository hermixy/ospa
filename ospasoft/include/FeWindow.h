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

#include <functional>
#include <list>
#include <memory>
#include "SpEvent.h"
#include "FeRect.h"
#include "FeWindowBase.h"
#include "FeCallbackDefinition.h"

/// Templated window which is attached to a FLTK window class specified in the `ViewType` template argument.
template<typename ViewType>
class FeWindow : public FeWindowBase
{
public:
   /// Constructor.
   FeWindow()
   {
   }
   
   /// Destructor.
   virtual ~FeWindow() 
   {
   }
   
   /// Shows the window.
   virtual void Show() 
   { 
      _Window.FlWindow->show(0, NULL); 
   }

   /// Closes the window.  It may be shown again later.
   virtual void Close()
   {
      _Window.FlWindow->hide();
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
   virtual void CenterIn(const FeWindowBase& parent)
   {
      Bounds(Bounds().CenterIn(parent.Bounds()));
   }

protected:
   /// FLTK window object.
   mutable ViewType _Window;
};

#define W_SET_HANDLER(className, widgetEvent, methodName) \
   widgetEvent .SetHandler(HANDLER( className , methodName ))
