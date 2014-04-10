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

using System;
using System.Linq;
using System.Reflection;

namespace ProgDev.IDE.Common.FlexForms
{
   public static class ViewModelUtilities
   {
      public static void InitializeFieldsOfType<T>(ViewModel viewModel)
      {
         var type = typeof(T);

         foreach (var fieldInfo in viewModel.GetType().GetFields())
         {
            if (fieldInfo.FieldType == type || fieldInfo.FieldType.IsSubclassOf(type))
               fieldInfo.SetValue(viewModel, Activator.CreateInstance(fieldInfo.FieldType));
         }
      }

      public static T GetField<T>(ViewModel viewModel, string fieldName)
      {
         var fieldInfo = viewModel.GetType().GetFields().SingleOrDefault(x => x.Name == fieldName);
         if (fieldInfo == null)
            throw new FlexException("Cannot find a field named: " + fieldName);
         return (T)fieldInfo.GetValue(viewModel);
      }

      public static void AssertReturnType(MethodInfo methodInfo, Type returnType)
      {
         if (methodInfo.ReturnType != returnType)
            throw new FlexException("Method must return: " + returnType.Name);
      }

      public static void AssertParameterCount(MethodInfo methodInfo, int count)
      {
         if (methodInfo.GetParameters().Length != count)
            throw new FlexException("Method must have " + count + " parameter(s).");
      }

      public static void AssertParameterType(MethodInfo methodInfo, int parameterIndex, Type expectedType)
      {
         var paramType = methodInfo.GetParameters()[parameterIndex].ParameterType;
         if (paramType != expectedType && !paramType.IsSubclassOf(expectedType))
         {
            throw new FlexException("Method must have one parameter of type " + expectedType.Name
               + " (or a derived class).");
         }
      }

      public static void AssertType<ActualType, ExpectedType>()
      {
         Type actualType = typeof(ActualType);
         Type expectedType = typeof(ExpectedType);
         if (actualType != expectedType && !actualType.IsSubclassOf(expectedType))
            throw new InvalidOperationException("Unexpected type.  Expected: " + expectedType.Name);
      }
   }
}
