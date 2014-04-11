// OSPA ProgDev
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

using System.Collections;
using System.Collections.Generic;

namespace ProgDev.IDE.Common.FlexForms
{
   public sealed class ListField<T> : Field, IList<T>, IEnumerable<T>
   {
      private readonly List<T> _List = new List<T>();

      public void AddRange(IEnumerable<T> items)
      {
         _List.AddRange(items);
         Notify();
      }

      public void Set(IEnumerable<T> newList)
      {
         _List.Clear();
         _List.AddRange(newList);
         Notify();
      }

      public int IndexOf(T item)
      {
         return _List.IndexOf(item);
      }

      public void Insert(int index, T item)
      {
         _List.Insert(index, item);
         Notify();
      }

      public void RemoveAt(int index)
      {
         _List.RemoveAt(index);
         Notify();
      }

      public T this[int index]
      {
         get
         {
            return _List[index];
         }
         set
         {
            _List[index] = value;
            Notify();
         }
      }

      public void Add(T item)
      {
         _List.Add(item);
         Notify();
      }

      public void Clear()
      {
         _List.Clear();
         Notify();
      }

      public bool Contains(T item)
      {
         return _List.Contains(item);
      }

      public void CopyTo(T[] array, int arrayIndex)
      {
         _List.CopyTo(array, arrayIndex);
      }

      public int Count
      {
         get { return _List.Count; }
      }

      public bool IsReadOnly
      {
         get { return false; }
      }

      public bool Remove(T item)
      {
         bool removed = _List.Remove(item);
         if (removed)
            Notify();
         return removed;
      }

      public IEnumerator<T> GetEnumerator()
      {
         return _List.GetEnumerator();
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
         return ((IEnumerable)_List).GetEnumerator();
      }
   }
}
