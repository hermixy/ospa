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

using ProgDev.IDE.Common.FlexViews.Attributes;
using System;
using System.Linq;
using System.Reflection;

namespace ProgDev.IDE.Common.FlexViews
{
   public abstract class ViewModel : PropertyNotifier
   {
      public ViewModel()
      {
         InitializePropertiesOfType<Property>();
         InitializePropertiesOfType<Command>();
         AttachHandlers();
         AttachNotifiers();
      }

      private void AttachNotifiers()
      {
         var propertyInfos = GetType().GetProperties().Where(x => x.PropertyType.IsSubclassOf(typeof(Property)));
         foreach (var pi in propertyInfos)
         {
            var property = (Property)pi.GetValue(this);
            property.PropertyChanged += (sender, e) => Notify(pi.Name);
         }
      }

      private void AttachHandlers()
      {
         var methods = GetType()
            .GetMethods()
            .Where(x => x.GetCustomAttributes(true).OfType<FlexViewsAttribute>().Any());

         foreach (var methodInfo in methods)
         {
            var attributes = methodInfo.GetCustomAttributes(true);

            var canExecute = attributes.OfType<CanExecuteAttribute>().SingleOrDefault();
            if (canExecute != null)
            {
               var callback = CreateCallback<Command>(methodInfo, canExecute.CommandName, typeof(bool));
               callback.Item1.CanExecute = () => (bool)callback.Item2();
            }

            var execute = attributes.OfType<ExecuteAttribute>().SingleOrDefault();
            if (execute != null)
            {
               var callback = CreateCallback<Command>(methodInfo, execute.CommandName, typeof(void));
               callback.Item1.Execute = () => callback.Item2();
            }

            var onChange = attributes.OfType<OnChangeAttribute>().SingleOrDefault();
            if (onChange != null)
            {
               var callback = CreateCallback<Property>(methodInfo, execute.CommandName, typeof(void));
               callback.Item1.OnChange = () => callback.Item2();
            }
         }
      }

      private Tuple<T, Func<object>> CreateCallback<T>(MethodInfo methodInfo, string propertyName, Type returnType)
      {
         if (methodInfo.ReturnType != returnType)
            throw new FlexViewsException("Method must return: " + returnType.Name);
         if (methodInfo.GetParameters().Any())
            throw new FlexViewsException("Method must not have any parameters.");

         var propertyInfo = GetType().GetProperties().SingleOrDefault(x => x.Name == propertyName);
         if (propertyInfo == null)
            throw new FlexViewsException("Cannot find a property named: " + propertyName);

         return Tuple.Create<T, Func<object>>(
            (T)propertyInfo.GetValue(this),
            () => methodInfo.Invoke(this, new object[0])
         );
      }

      private void InitializePropertiesOfType<T>()
      {
         var type = typeof(T);

         foreach (var propertyInfo in GetType().GetProperties())
            if (propertyInfo.PropertyType == type || propertyInfo.PropertyType.IsSubclassOf(type))
               propertyInfo.SetValue(this, Activator.CreateInstance(propertyInfo.PropertyType));
      }
   }
}
