using StandardDemo;
using System;

namespace CoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Parser p = new Parser("{'prop': 'value'}");
            string v = p.GetValue("prop");
            Console.WriteLine(v);
        }
    }
}
