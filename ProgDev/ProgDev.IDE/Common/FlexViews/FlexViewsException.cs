using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgDev.IDE.Common.FlexViews
{
   public sealed class FlexViewsException : Exception
   {
      public FlexViewsException(string message)
         : base(message)
      {
      }
   }
}
