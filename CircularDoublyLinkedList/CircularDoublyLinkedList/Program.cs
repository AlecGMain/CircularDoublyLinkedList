using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularDoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularDoublyLinkedList<int> list = new CircularDoublyLinkedList<int>(2);
            list.AddToFront(4);
            list.AddToEnd(34);
            list.AddAt(2, 56);
            list.RemoveFromFront();
        }
    }
}
