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

/// Rectangle defined using integer values.
class FeRect
{
public:
   /// Left offset.
   int X;

   /// Top offset.
   int Y;

   /// Width.
   int W;

   /// Height.
   int H;

   /// Constructor.
   /// \param x Left offset.
   /// \param y Top offset.
   /// \param w Width.
   /// \param h Height.
   FeRect(int x = 0, int y = 0, int w = 0, int h = 0);

   /// Equals operator.
   /// \param other Object to compare against.
   /// \return True iff `other` equals `this`.
   bool operator ==(const FeRect& other) const;

   /// Creates a new rectangle inflated by a specified number of pixels on each side.
   /// \param left   Number of pixels by which to extend upward.
   /// \param top    Number of pixels by which to extend to the top.
   /// \param right  Number of pixels by which to extend to the right.
   /// \param bottom Number of pixels by which to extend downward.
   /// \return A new `FeRect`.
   FeRect InflateBy(int left, int top, int right, int bottom) const;

   /// Creates a new rectangle with the same width/height, but centered within `outer`.
   /// \param outer Outer rectangle in which to center `this`.
   /// \return A new `FeRect`.
   FeRect CenterIn(const FeRect& outer) const;
};
