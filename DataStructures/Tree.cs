using System.Collections.Generic;

namespace DataStructures
{
   /// <summary>
   /// A rudimentary tree implementation utilizing C# generics. 
   /// </summary>
   public class TreeNode<T>
   {
      
      public TreeNode(T data, TreeNode<T> parent)
      {
         Data = data;
         Parent = parent;
         Children = new List<TreeNode<T>>();
      }

      public TreeNode(T data) : this(data, null)
      {
         
      } 

      public TreeNode<T> Parent { get; set; } 
      public List<TreeNode<T>> Children { get; set; }
      public T Data { get; set; }

      public void AddChild(TreeNode<T> child)
      {
         child.Parent = this;
         Children.Add(child);
      }

      public void AddChild(T data)
      {
         var newChild = new TreeNode<T>(data, this);
         Children.Add(newChild);
      }
   }
}
