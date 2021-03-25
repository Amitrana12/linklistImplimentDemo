using System;

namespace linklistImp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WWelcome to my linklist demo program by Amit Rana");
            Node head = new Node(56);
            head.next = new Node(30);
            head.next.next = new Node(70);
        }
    }
}
