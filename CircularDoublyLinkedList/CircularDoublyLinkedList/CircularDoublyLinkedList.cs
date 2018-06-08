using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularDoublyLinkedList
{
    class CircularDoublyLinkedList<T>
    {
        public Node<T> Head;
        public Node<T> Tail;
        public int Count;

        public CircularDoublyLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public CircularDoublyLinkedList(T value)
        {
            Head = new Node<T>(value);
            Tail = new Node<T>(value);
            Head.Previous = Head;
            Head.Next = Head;
            Tail = Head;
        }
        public void AddToEnd(T value)
        {
            if (Count == 0)
            {
                //make head and tail
                Head = new Node<T>(value);
                Tail = new Node<T>(value);
                Head.Previous = Head;
                Head.Next = Head;
                Tail = Head;
            }
            else
            {
                Node<T> newNode = new Node<T>(value);

                newNode.Next = Head;
                newNode.Previous = Tail;

                Head.Previous = newNode;
                Tail.Next = newNode;
                Tail = Tail.Next;
                
            }
        }
        public void AddToFront(T value)
        {
            if(Count == 0)
            {
                Head = new Node<T>(value);
                Tail = new Node<T>(value);
                Head.Previous = Head;
                Head.Next = Head;
                Tail = Head;
            }
            else
            {
                Node<T> newNode = new Node<T>(value);
                newNode.Next = Head;
                newNode.Previous = Tail;

                Head.Previous = newNode;
                Tail.Next = newNode;
                Head = Head.Previous;
            }
        }
        public bool AddAt(int position,T value)
        {
            if(Count < position)
            {
                return false;
            }
            else
            {

            }
        }
    }
}
