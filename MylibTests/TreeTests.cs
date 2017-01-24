using System;
using System.Linq;
using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MylibTests
{
   [TestClass]
   public class TreeTests
   {
      [TestMethod]
      public void TestTreeCreation()
      {
         var root = new TreeNode<string>("Root", null);
         Assert.AreEqual(root.Parent, null);
         Assert.AreEqual(root.Data, "Root");
      }
      [TestMethod]
      public void TestAddChildData()
      {
         var root = new TreeNode<string>("Root", null);
         root.AddChild("Child");
         Assert.AreEqual(root.Children.Any(c => c.Data == "Child"), true);
      }
      [TestMethod]
      public void TestAddChildNode()
      {
         var root = new TreeNode<string>("Root", null);
         var childNode = new TreeNode<string>("Child");
         root.AddChild(childNode);
         Assert.AreEqual(root.Children.Contains(childNode), true);
      }
      //TODO: Add more test coverage, such as making sure the tree is not cyclical, checking for duplicate references etc..
   }
}
