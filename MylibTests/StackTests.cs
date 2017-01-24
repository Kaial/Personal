using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace MylibTests
{
   [TestClass]
   public class StackTests
   {
      [TestMethod]
      public void TestPush()
      {
         Stack<string> stack = new Stack<string>();
         string item = "item";
         try
         {
            stack.Push(item);
         }
         catch (Exception)
         {
            throw new AssertFailedException();
         }
      }

      [TestMethod]
      public void TestPop()
      {
         var stack = new Stack<string>();
         var item = "first";
         stack.Push(item);
         Assert.AreEqual(stack.Pop(), item);
      }

      [TestMethod]
      public void TestPeek()
      {
         var stack = new Stack<string>();
         var item = "first";
         stack.Push(item);
         Assert.AreEqual(stack.Peek(), item);
      }

      [TestMethod]
      public void TestCapacity()
      {
         var stack = new Stack<string>(2);
         try
         {
            stack.Push("one");
            stack.Push("two");
            stack.Push("fail");
         }
         catch (OverflowException)
         {
            return;
         }
         throw new AssertFailedException();
      }
   }
}
