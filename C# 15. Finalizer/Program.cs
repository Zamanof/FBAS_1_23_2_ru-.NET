using System;

namespace C__15.Finalizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foo foo = new Foo();
        }
    }
    class Foo
    {
        ~Foo() {
            Console.WriteLine("Finalizer is working");
        }
    }
}
