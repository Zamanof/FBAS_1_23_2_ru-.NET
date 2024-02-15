namespace C__05._Namespaces
{
    internal class Foo
    {
        public void Print()
        {
            Console.WriteLine("Foo 1");
        }
    }

    
}
namespace A
{
    public class Foo
    {
        public void Print()
        {
            Console.WriteLine("Foo 2");
        }
    }
}

namespace B
{
    public class Foo
    {
        public void Print()
        {
            Console.WriteLine("Foo 3");
        }
    }
}

namespace C
{
    class Bar
    {
        public void Print()
        {
            Console.WriteLine("Bar");
        }
    }
    namespace nested
    {
        class SomeBody
        {
            public void Some()
            {
                Console.WriteLine("Any");
            }
        }
    }
}

namespace Antanarivu
{
    public class Madagascar
    {
        public void Print()
        {
            Console.WriteLine("Kowalski");
        }
    }
}
