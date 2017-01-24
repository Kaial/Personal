using System;
using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MylibTests
{
   [TestClass]
   public class LinkedListTests
   {
      [TestMethod]
      public void TestInsertAfter()
      {
         var list = new LinkedList<string>("first");
         var newNode = new Node<string>(null,"second");
         list.InsertAfter(list.First, newNode);
         Assert.AreEqual(list.First.Next, newNode);
      }

      [TestMethod]
      public void TestInsertBeginning()
      {
         var list = new LinkedList<string>("first");
         var newNode = new Node<string>(null, "second");
         list.InsertBeginning(list, newNode);
         Assert.AreEqual(list.First, newNode);
      }

      [TestMethod]
      public void TestRemoveAfter()
      {
         var list = new LinkedList<string>("first");
         var third = new Node<string>(null, "third");
         var second = new Node<string>(third, "second");
         list.First.Next = second;
         list.RemoveAfter(list.First);
         Assert.AreEqual(list.First.Next, third);
      }

      [TestMethod]
      public void TestRemoveBeginning()
      {
         var list = new LinkedList<string>("first");
         list.RemoveBeginning(list);
         Assert.AreEqual(list.First, null);
         list = new LinkedList<string>("first");
         var second = new Node<string>(null, "second");
         list.First.Next = second;
         list.RemoveBeginning(list);
         Assert.AreEqual(list.First, second);
      }
      
   }
}
