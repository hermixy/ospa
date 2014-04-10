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
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ProgDev.IDE.Common.FlexForms
{
   public abstract class ViewModel
   {
   }

   public abstract class ViewModel<ControlType> : ViewModel
      where ControlType : Control
   {
      private Action<Action<ControlType>> Invoke = f => { };
      private IReadOnlyList<string> ComputedFieldEvaluationOrder = new string[0];

      public ViewModel()
      {
         ViewModelUtilities.InitializeFieldsOfType<Field>(this);
         ViewModelUtilities.InitializeFieldsOfType<Signal>(this);
         AttachHandlers();
      }

      public void Start(ControlType form)
      {
         // We store a reference to the view model in the form's Tag property so that the view model won't be garbage
         // collected.  Otherwise, there won't be any remaining references to the view model, since we don't require
         // the derived form to take care of storing the view model.
         form.Tag = this;

         Invoke = action => action(form);
         
         Reset();
      }

      public void Reset()
      {
         PollComputedFields();
         Initialize();
      }

      private string[] GetComputedFieldDependencies(MethodInfo methodInfo)
      {
         var attribute = methodInfo.GetCustomAttributes<DependsAttribute>().SingleOrDefault();
         if (attribute == null)
            return new string[0];
         else
            return attribute.FieldDependencies;
      }

      // Field name => Array of field names that are depended on
      private Dictionary<string, string[]> GetAllComputedFieldDependencies()
      {
         return GetType()
            .GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
            .Where(x => x.GetCustomAttributes<ComputeAttribute>().Any())
            .ToDictionary(
               x => x.GetCustomAttribute<ComputeAttribute>().FieldName,
               x => GetComputedFieldDependencies(x));
      }

      private void PollComputedFields()
      {
         // Fields will be removed from this dictionary one-by-one as they polled.  Any field not found in this 
         // dictionary can thus be assumed up-to-date and used.
         var depends = GetAllComputedFieldDependencies();

         while (depends.Any())
         {
            foreach (string computedFieldName in depends.Keys.ToList())
            {
               string[] computedFieldDepends = depends[computedFieldName];

               if (!computedFieldDepends.Any(x => depends.ContainsKey(x)))
               {
                  // This computed field either has no dependencies, or all of its dependencies have been polled
                  // already.  We can proceed to poll it.
                  ViewModelUtilities.GetField<IComputedField>(this, computedFieldName).Poll();

                  // Indicate that this field has been polled by removing it from the depends dictionary.
                  depends.Remove(computedFieldName);
               }
            }
         }
      }

      protected virtual void Initialize()
      {
      }

      protected void Close()
      {
         ViewModelUtilities.AssertType<ControlType, Form>();
         Invoke(x => (x as Form).Close());
      }

      protected DialogResult ShowChildDialog(Form child)
      {
         ViewModelUtilities.AssertType<ControlType, Form>();
         DialogResult result = default(DialogResult);
         Invoke(x => result = child.ShowDialog(x as Form));
         return result;
      }

      private void AttachHandlers()
      {
         var methods = GetType()
            .GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
            .Where(x => x.GetCustomAttributes<FlexAttribute>().Any());

         foreach (var methodInfo in methods)
         {
            var attributes = methodInfo.GetCustomAttributes();

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

            foreach (var handler in attributes.OfType<ComputeAttribute>())
            {
               var callback = CreateComputedCallback<IComputedField>(methodInfo, handler.FieldName);
               callback.Item1.Evaluator = callback.Item2;

               var triggers = attributes.OfType<DependsAttribute>().SingleOrDefault();
               if (triggers != null)
                  callback.Item1.Dependencies = 
                     triggers
                     .FieldDependencies
                     .Select(x => ViewModelUtilities.GetField<Field>(this, x));
            }
         }
      }

      private Tuple<T, Func<object>> CreateCallback<T>(MethodInfo methodInfo, string fieldName, Type returnType)
      {
         ViewModelUtilities.AssertReturnType(methodInfo, returnType);
         ViewModelUtilities.AssertParameterCount(methodInfo, 0);

         return Tuple.Create<T, Func<object>>(
            ViewModelUtilities.GetField<T>(this, fieldName),
            () => methodInfo.Invoke(this, new object[0])
         );
      }

      private Tuple<T, Func<EventArgs, object>> CreateCallbackWithArg<T>(MethodInfo methodInfo, string fieldName, 
         Type returnType)
      {
         ViewModelUtilities.AssertReturnType(methodInfo, returnType);
         ViewModelUtilities.AssertParameterCount(methodInfo, 1);
         ViewModelUtilities.AssertParameterType(methodInfo, 0, typeof(EventArgs));

         return Tuple.Create<T, Func<EventArgs, object>>(
            ViewModelUtilities.GetField<T>(this, fieldName),
            (e) => methodInfo.Invoke(this, new object[] { e })
         );
      }

      private Tuple<T, Func<object>> CreateComputedCallback<T>(MethodInfo methodInfo, string fieldName)
      {
         ViewModelUtilities.AssertParameterCount(methodInfo, 0);

         return Tuple.Create<T, Func<object>>(
            ViewModelUtilities.GetField<T>(this, fieldName),
            () => methodInfo.Invoke(this, new object[0])
         );
      }
   }
}
