using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
   public class BinaryTreeNode<T>
   {
      public BinaryTreeNode<T> LeftChild { get; set; }
      public BinaryTreeNode<T> RightChild { get; set; }

      public BinaryTreeNode<T> Parent { get; set; }    
      public T Data { get; set; }

      public BinaryTreeNode(T data, BinaryTreeNode<T> leftChild, BinaryTreeNode<T> rightChild, BinaryTreeNode<T> parent)
      {
         Data = data;
         LeftChild = leftChild;
         RightChild = rightChild;
         Parent = parent;
         if (LeftChild != null)
            LeftChild.Parent = this;
         if (RightChild != null)
            RightChild.Parent = this;
      }

      public BinaryTreeNode(T data)
      {
         Data = data;
      } 
   }
}
