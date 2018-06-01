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
        public int Count;
        public CircularDoublyLinkedList()
        {
            Head = new Node<T>();
        }
        public CircularDoublyLinkedList(T value)
        {
            Head = new Node<T>(value);
        }
    }
}
