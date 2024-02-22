internal class Derived: Base
{
    public string SomeProperty { get; set; }
    public Derived()
    {
        SomeProperty = "Salam";
        Console.WriteLine("Derived class default constructor");
    }

    public Derived(string some, int field1, int field2) 
        : base(field1, field2)
    {
        SomeProperty = some;
        Console.WriteLine("Derived class parametrized constructor");
    }

    public void DerivedFoo()
    {
        base.Foo();
    }

    public new void Foo()
    {
        Console.WriteLine("Derived Foo");
    }
}
