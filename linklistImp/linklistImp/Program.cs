using System;

namespace linklistImp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WWelcome to my linklist demo program by Amit Rana");
            LinkedList list = new LinkedList();
            /* list.Add(70);
             list.Add(30);
             list.Add(56);
             list.Display();*/

            /*list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Display();*/

            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Append(100);
            list.Insert(4, 12);
            list.Display();

            Node p = list.Pop();
            System.Console.WriteLine(p.data);
            list.Display();


            Console.WriteLine();
            list.RemoveLastNode();
            list.Display();

            System.Console.WriteLine(list.Search(70));
        }
    }
}
