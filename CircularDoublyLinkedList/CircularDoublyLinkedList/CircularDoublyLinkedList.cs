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
                Count++;
            }
            else
            {
                Node<T> newNode = new Node<T>(value);

                newNode.Next = Head;
                newNode.Previous = Tail;

                Head.Previous = newNode;
                Tail.Next = newNode;
                Tail = Tail.Next;
                Count++;
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
            else if(position == 0)
            {
                AddToFront(value);
                return true;
            }
            else if (position == Count - 1)
            {
                AddToEnd(value);
                return true;
            }
            else
            {
                Node<T> current = Head;
                Node<T> current2 = Head;
                for(int i = 0; i < position - 1; i++)
                {
                    Head = Head.Next;
                }
                current.Next.Next = current.Next;
                current.Next.Value = value;
                current.Next.Next.Previous = current.Next;
                for(int i = 0; i < position; i++)
                {
                    Tail = Tail.Next;
                }
                current2.Next.Next = current2.Next;
                current2.Next.Value = value;
                current2.Next.Next.Previous = current2.Next;
                Tail = current2;
                Head = current;
                return true;
            }
        }
        public bool RemoveFromFront()
        {
            if(IsEmpty())
            {
                return false;
            }
            else if (Count == 1)
            {
                Head = null;
                Count--;
                return true;
            }
            else
            {
                Head = Head.Next;
                Head.Previous = Tail;
                Tail.Next = Tail.Next.Next;
                Tail.Next.Previous = Tail;
                Count--;
                return true;
            }
        }
        public bool RemoveFromEnd()
        {
            if(IsEmpty())
            {
                return false;
            }
            else if (Count == 1)
            {
                RemoveFromFront();
            }
        }
        public bool IsEmpty()
        {
            return Head == null;
        }
    }
}
