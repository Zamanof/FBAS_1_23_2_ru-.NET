using C;
using C.nested;
using anta = Antanarivu;
using static System.Console;
using static C__05._Namespaces.Calculator;

namespace C__05._Namespaces;
internal class Program
{
    static void Main(string[] args)
    {
        Foo foo = new Foo();
        foo.Print();
        A.Foo foo1 = new A.Foo();
        foo1.Print();
        B.Foo foo3 = new B.Foo();
        foo3.Print();
        Bar bar = new Bar();
        bar.Print();

        anta.Madagascar madagascar = new();
        madagascar.Print();
        WriteLine("Salam Aleykum");
        WriteLine(Add(25, 66)); 
        
        SomeBody someBody = new();
        someBody.Some();
        
    }
}