using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgDev.IDE.Forms
{
   public static class FormsFactory
   {
      public static AboutForm NewAboutForm()
      {
         return new AboutForm(new AboutFormViewModel());
      }
   }
}
