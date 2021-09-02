using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // you can inherit abstract to abstract and also implement interface in abstract class.
            DataAccess a = new Information();
            Console.WriteLine(a.Count());
            a.Connect();
            a.testInterface();
        }
    }
}


