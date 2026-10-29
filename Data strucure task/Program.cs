using System;
using System.Collections.Generic;
using System.Text;

namespace Cse111Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
           StudentList list = new StudentList();
            list.AddFront(20);
            list.Print();
            list.AddFront(10);
            list.Print();
            list.AddEnd(30);
            list.Print();
            list.AddEnd(40);
            list.Print();
            list.Reverse();
            list.Print();
            list.Remove(20);
            list.Print();


        }
    }
}

