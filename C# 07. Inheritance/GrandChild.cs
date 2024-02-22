internal class GrandChild : Derived
{
    public GrandChild()
        : base("Hi", 26, 54)
    {
        Console.WriteLine("GrandChild class default constructor");
    }

    public GrandChild(string some, int field1, int field2) 
        : base(some, field1, field2)
    {
        Console.WriteLine("Derived class parametrized constructor");
    }
    public void GrandChildFoo()
    {
        Foo();
    }
}
