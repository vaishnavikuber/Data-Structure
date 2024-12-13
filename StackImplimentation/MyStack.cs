using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace StackImplimentation
{
    internal class MyStack
    {

        internal Node top;

        public MyStack()
        {
            top = null;
        }

        public void push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = top;
            }
            top = node;
            Console.WriteLine($"{node.data} pushed into stack");

        }

        public void pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack underflow!!!");
            }
            else
            {
                int poppedData = top.data;
                top = top.next;
                Console.WriteLine($"popped data : {poppedData}");
            }
        }

        public void peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                int value = top.data;
                Console.WriteLine($"The first element is : {top.data}");
            }
        }
        public void display()
        {
            if(top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Node temp = top;
                while(temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }

    }
}
