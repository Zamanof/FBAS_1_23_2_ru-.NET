internal class Base
{
    public int Field1 { get; set; }
    private int Field2;
    public Base()
    {
        Field1 = 1;
        Field2 = 2;
        Console.WriteLine("Base class Default constructor");
    }
    public Base(int field1, int field2)
    {
        Field1 = field1;
        Field2 = field2;
        Console.WriteLine("Base class Parametrized constructor");
    }

    public void Show ()
    {
        Console.WriteLine($"Field1 = {Field1} -  Field2 = {Field2}");
    }
    protected void Foo()
    {
        Console.WriteLine("Protected method Foo");
        Bar();
    }

    private void Bar()
    {
        Console.WriteLine("Private method Foo");
    }
}
