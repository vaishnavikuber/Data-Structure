using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedList
{
    public class Node
    {
        internal Node next;
        internal int data;

        public Node(int d)
        {
            data = d;
            next = null;

        }
    }
}
