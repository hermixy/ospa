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
using System.Windows.Forms;

namespace ProgDev.IDE.Common.FlexForms
{
   public abstract class ViewModel<ControlType>
      where ControlType : Control
   {
      private Action<Action<ControlType>> Invoke = f => { };

      public ViewModel()
      {
         InitializeFieldsOfType<Field>();
         InitializeFieldsOfType<Signal>();
         AttachHandlers();
      }

      public void Start(ControlType form)
      {
         Invoke = action => action(form);
         
         // We store a reference to the view model in the form's Tag property so that the view model won't be garbage
         // collected.  Otherwise, there won't be any remaining references to the view model, since we don't require
         // the derived form to take care of storing the view model.
         form.Tag = this;

         Initialize();
      }

      protected abstract void Initialize();

      protected void Close()
      {
         Type controlType = typeof(ControlType);
         Type formType = typeof(Form);

         if (controlType == formType || controlType.IsSubclassOf(formType))
            Invoke(x => (x as Form).Close());
      }
      
      private void AttachHandlers()
      {
         var methods = GetType()
            .GetMethods()
            .Where(x => x.GetCustomAttributes(true).OfType<FlexAttribute>().Any());

         foreach (var methodInfo in methods)
         {
            var attributes = methodInfo.GetCustomAttributes(true);

            foreach (var handler in attributes.OfType<OnSignalAttribute>())
            {
               if (methodInfo.GetParameters().Length == 1)
               {
                  var callback = CreateCallbackWithArg<Signal>(methodInfo, handler.FieldName, typeof(void));
                  callback.Item1.Handle += (sender, e) => callback.Item2(e);
               }
               else
               {
                  var callback = CreateCallback<Signal>(methodInfo, handler.FieldName, typeof(void));
                  callback.Item1.Handle += (sender, e) => callback.Item2();
               }
            }

            foreach (var handler in attributes.OfType<OnChangeAttribute>())
            {
               var callback = CreateCallback<Field>(methodInfo, handler.FieldName, typeof(void));
               callback.Item1.Changed += (sender, e) => callback.Item2();
            }
         }
      }

      private Tuple<T, Func<object>> CreateCallback<T>(MethodInfo methodInfo, string fieldName, Type returnType)
      {
         if (methodInfo.ReturnType != returnType)
            throw new FlexException("Method must return: " + returnType.Name);
         if (methodInfo.GetParameters().Any())
            throw new FlexException("Method must not have any parameters.");

         var fieldInfo = GetType().GetFields().SingleOrDefault(x => x.Name == fieldName);
         if (fieldInfo == null)
            throw new FlexException("Cannot find a field named: " + fieldName);

         return Tuple.Create<T, Func<object>>(
            (T)fieldInfo.GetValue(this),
            () => methodInfo.Invoke(this, new object[0])
         );
      }

      private Tuple<T, Func<EventArgs, object>> CreateCallbackWithArg<T>(
         MethodInfo methodInfo, string fieldName, Type returnType)
      {
         if (methodInfo.ReturnType != returnType)
            throw new FlexException("Method must return: " + returnType.Name);
         if (methodInfo.GetParameters().Length != 1)
            throw new FlexException("Method must have one parameter of type EventArgs (or a derived class).");
         var paramType = methodInfo.GetParameters()[0].ParameterType;
         Type expectedType = typeof(EventArgs);
         if (paramType != expectedType && !paramType.IsSubclassOf(expectedType))
            throw new FlexException("Method must have one parameter of type EventArgs (or a derived class).");

         var fieldInfo = GetType().GetFields().SingleOrDefault(x => x.Name == fieldName);
         if (fieldInfo == null)
            throw new FlexException("Cannot find a field named: " + fieldName);

         return Tuple.Create<T, Func<EventArgs, object>>(
            (T)fieldInfo.GetValue(this),
            (e) => methodInfo.Invoke(this, new object[] { e })
         );
      }

      private void InitializeFieldsOfType<T>()
      {
         var type = typeof(T);

         foreach (var fieldInfo in GetType().GetFields())
         {
            if (fieldInfo.FieldType == type || fieldInfo.FieldType.IsSubclassOf(type))
               fieldInfo.SetValue(this, Activator.CreateInstance(fieldInfo.FieldType));
         }
      }
   }
}
