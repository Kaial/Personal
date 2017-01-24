using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
   /// <summary>
   /// basic stack implementation. 
   /// </summary>
   public class Stack<T>
   {
      private LinkedList<T> m_StackList;
      private int m_Count;
      private int m_Capacity = 0;
      /// <summary>
      /// creates a new stack with the passed in capacity. Will throw overflow exception if capactiy is exceeded. 
      /// </summary>
      /// <param name="capacity"></param>
      public Stack(int capacity) : this()
      {
         m_Capacity = capacity;
      }

      /// <summary>
      /// Creates an empty stack, with no capacity limit
      /// </summary>
      public Stack()
      {
         m_StackList = new LinkedList<T>();
      }

      /// <summary>
      /// push an item onto the stack
      /// </summary>
      /// <param name="item"></param>
      public void Push(T item)
      {
            if(m_Count + 1 > m_Capacity && m_Capacity != 0)
            {
                throw new OverflowException("Error exceeded stack capacity of " + m_Capacity);
            }            
            var newHead = new Node<T>(null, item);
            var newNext = m_StackList.First;
            newHead.Next = newNext;
            m_StackList.First = newHead;
            m_Count++;
      }
      /// <summary>
      /// pop an item off the stack, returns Default(T) if there are no more items on the stack
      /// </summary>
      /// <returns></returns>
      public T Pop()
      {
            if (m_Count <= 0)
                return default(T);
            var popItem = m_StackList.First;
            var nextHead = m_StackList.First.Next;
            m_StackList.First = nextHead;
            m_Count--;
            return popItem.Data;
      }
      /// <summary>
      /// peek at the item on top of the stack without popping it. 
      /// </summary>
      /// <returns></returns>
      public T Peek()
      {
            return m_StackList.First.Data;
      }
   }
}
