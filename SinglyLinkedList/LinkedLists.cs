using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedList
{
    internal class LinkedLists
    {

        internal Node head;

        public void display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty\n");
            }
            else
            {
                Node temp=head;
                while (temp != null)
                {
                    Console.Write(temp.data);
                    
                    if (temp.next != null)
                    {
                        Console.Write("->");
                    }
                    temp = temp.next;

                }
            }
        }

        public void insertFirst(int data)
        {
            Node node= new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }

        public void insertLast(int data)
        {
            if (head == null)
            {
                insertFirst(data);
            }
            else
            {
                Node node = new Node(data);
                Node last = findLast();
                last.next = node;

            }

        }

        public void insertAfter(Node n,int data)
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");

            }
            else
            {
                Node newNode= new Node(data);
                newNode.next = n.next;
                n.next = newNode;
            }
        }

        public Node findLast()
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
                return null;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp=temp.next;
                }
                return temp;

            }
        }

        public int deleteFirst()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty, not data to delete");
                return 0;
            }
            else
            {            
                Node temp=head;                
                head = head.next;
                return temp.data;
            }
        }

        public int deleteLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty, not data to delete");
                return 0;
            }
            else
            {
                Node last = findLast();
                Node temp=head;
                while(temp.next != last)
                {
                    temp = temp.next;
                }
                temp.next = null;
                return last.data;
            }

        }

        


    }
}
