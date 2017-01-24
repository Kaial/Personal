using System;
using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MylibTests
{
   [TestClass]
   public class BinaryTreeTests
   {
      [TestMethod]
      public void TestTreeCreation()
      {
         var root = new BinaryTreeNode<string>("Root", null, null, null);
         Assert.AreEqual(root.Data, "Root");
         Assert.AreEqual(root.LeftChild, null);
         Assert.AreEqual(root.RightChild, null);
         Assert.AreEqual(root.Parent, null);
      }
      [TestMethod]
      public void TestTreeCreationWithChildren()
      {
         var root = new BinaryTreeNode<string>("Root", new BinaryTreeNode<string>("Left"), new BinaryTreeNode<string>("Right"), null);
         Assert.AreEqual(root.Data, "Root");
         Assert.AreEqual(root.LeftChild.Data, "Left");
         Assert.AreEqual(root.RightChild.Data, "Right");
         Assert.AreEqual(root.Parent, null);
      }
   }
}
