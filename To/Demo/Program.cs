using System;

namespace Demo
{
    public class Program
    {
        // san jiao xing de S
        // p = (a+b+c)/2
        // S = sqrt[p(p-a)(p-b)(p-c)]
        public static void Main(string[] args)
        {
            var a = Console.Read();
            var b = Console.Read();
            var c = Console.Read();
            var p = (a + b + c) / 2;
            var S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("S="+S);


        }
    }
}
