using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(CoreLibraryTest.TestClass.Hello());
            Console.WriteLine(CoreLibraryTest.Standard.TestClass.Hello());
        }
    }
}