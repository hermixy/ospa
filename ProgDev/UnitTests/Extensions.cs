using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
   internal static class Extensions
   {
      public static string GetString(this byte[] self)
      {
         return Encoding.UTF8.GetString(self);
      }
   }
}
