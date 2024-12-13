using System;

namespace SinglyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedLists list = new LinkedLists();
            list.display();
            list.insertFirst(10);
            list.display();
            list.insertFirst(20);
            list.insertLast(30);
            list.insertAfter(list.head.next,40);
            
            list.display();

            Node lastNode=list.findLast();
            Console.WriteLine($"\n{lastNode.data}");

            int dataDeleted = list.deleteFirst();
            Console.WriteLine($"\ndata deleted : { dataDeleted}");
            list.display();

            int deletedLastData=list.deleteLast();
            Console.WriteLine($"\ndata deleted : {deletedLastData}");
            list.display();
            
        }
    }
}
