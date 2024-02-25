using System.Collections;

SomeClass some = new SomeClass();
//some.SomeMethod(15, 5);


//ISomeInterface some1 = new SomeClass();
//some1.SomeMethod();
Foo(some);

void Foo(ISomeInterface some)
{
    ((SomeClass)some).SomeMethod(4, 6);
}
interface ISomeInterface
{
    void SomeMethod();
}

interface IAnyInterface
{
    void SomeMethod();
}

class SomeClass : ISomeInterface
{
    public void SomeMethod(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    void ISomeInterface.SomeMethod()
    {
        throw new NotImplementedException();
    }
    
}
