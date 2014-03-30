using Antlr4.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgDev.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.ProgDev.Parser
{
   [TestClass]
   public sealed class ParserHandlerTest
   {
      /// <summary>
      /// VAR_GLOBAL with empty body.
      /// </summary>
      [TestMethod]
      public void Test_Global_Var_Decls_001()
      {
         string src = Resources.Global_Var_Decls_001.GetString();
         
         var result = ParseHandler.Parse(src);

         Assert.IsFalse(result.IsError);
         Assert.IsNull(result.ErrorMessage);
         Assert.IsNotNull(result.ParseTree);
         Assert.AreEqual(2, result.ParseTree.ChildCount);
         Assert.IsInstanceOfType(result.ParseTree.GetChild(0).Payload, typeof(CommonToken));
         Assert.AreEqual("VAR_GLOBAL", ((CommonToken)result.ParseTree.GetChild(0).Payload).Text);
         Assert.IsInstanceOfType(result.ParseTree.GetChild(1).Payload, typeof(CommonToken));
         Assert.AreEqual("END_VAR", ((CommonToken)result.ParseTree.GetChild(1).Payload).Text);
      }

      /// <summary>
      /// VAR_GLOBAL with one INT variable with no initializer.
      /// </summary>
      [TestMethod]
      public void Test_Global_Var_Decls_002()
      {
         string src = Resources.Global_Var_Decls_002.GetString();

         var result = ParseHandler.Parse(src);

         string a = result.ParseTree.ToStringTree();
         int b = 5;
      }
   }
}
