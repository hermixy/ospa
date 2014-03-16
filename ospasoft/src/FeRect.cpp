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

#include "FeRect.h"

FeRect::FeRect(int x, int y, int w, int h)
   : X(x), Y(y), W(w), H(h)
{
}

bool FeRect::operator ==(const FeRect& other) const
{
   return X == other.X && Y == other.Y && W == other.W && H == other.H;
}

FeRect FeRect::InflateBy(int left, int top, int right, int bottom) const
{
   FeRect inflated;
   inflated.X = X - left;
   inflated.Y = Y - top;
   inflated.W = W + left + right;
   inflated.H = H + top + bottom;
   return inflated;
}

FeRect FeRect::CenterIn(const FeRect& outer) const
{
   FeRect centered;
   centered.X = outer.W / 2 - W / 2 + outer.X;
   centered.Y = outer.H / 2 - H / 2 + outer.Y;
   centered.W = W;
   centered.H = H;
   return centered;
}
