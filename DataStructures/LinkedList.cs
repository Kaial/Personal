using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//my implementation of a linked list
namespace DataStructures
{
   /// <summary>
   /// A basic singly linked list implementation. Access and search is O(n). Insert and delete is O(1).
   /// </summary>
    public class LinkedList<T>
    {
      private Node<T> m_First;
      /// <summary>
      /// creates an empty linked list
      /// </summary>
      public LinkedList()
      {
         m_First = null;
      }
      /// <summary>
      /// creates a new linked list and sets the first element to the passed in initial data
      /// </summary>
      /// <param name="initialData">initial data for the start of the list</param>
      public LinkedList(T initialData)
      {
         m_First = new Node<T>(null, initialData);
      }
      /// <summary>
      /// inserts the new node after the passed in node
      /// </summary>
      /// <param name="node"></param>
      /// <param name="newNode"></param>
      public void InsertAfter(Node<T> node, Node<T> newNode)
      {
         node.Next = newNode;
      }
      /// <summary>
      /// Inserts the passed in node to the beginning of the list
      /// </summary>
      /// <param name="list"></param>
      /// <param name="newNode"></param>
      public void InsertBeginning(LinkedList<T> list, Node<T> newNode)
      {
         var oldFirst = list.First;
         list.First = newNode;
         newNode.Next = oldFirst;
      }
      /// <summary>
      /// removes the next node after the passed in node. 
      /// </summary>
      /// <param name="node"></param>
      public void RemoveAfter(Node<T> node)
      {
         var nodeToRemove = node.Next;
         var nodeAfterRemove = nodeToRemove.Next;
         node.Next = nodeAfterRemove;
      }
      /// <summary>
      /// removes the first node in the list. 
      /// </summary>
      /// <param name="list"></param>
      public void RemoveBeginning(LinkedList<T> list)
      {
         var nodeToRemove = list.First;
         list.First = nodeToRemove.Next;
      }

      /// <summary>
      /// The first node in the list. Null if list is empty
      /// </summary>
      public Node<T> First
      {
         get
         {
            return m_First;
         }
         set
         {
            m_First = value;
         }
      }
   }
   /// <summary>
   /// Represents a node in the linked list, with a generic data object. 
   /// </summary>
   public class Node<T>
   {
      public Node(Node<T> next, T data)
      {
         Next = next;
         Data = data;
      }
      /// <summary>
      /// The next node
      /// </summary>
      public Node<T> Next { get; set; }
      /// <summary>
      /// This nodes data
      /// </summary>
      public T Data { get; set; }
   }
}
