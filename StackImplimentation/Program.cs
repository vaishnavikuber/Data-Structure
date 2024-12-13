using System;

namespace StackImplimentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack stack1 = new MyStack();
            stack1.push(17);
            stack1.push(23);
            stack1.push(45);
            stack1.display();
            stack1.peek();
            stack1.pop();
            stack1.display();
            
        }
    }
}
