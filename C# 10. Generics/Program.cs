/*
 Generic
    - Class
    - Struct
    - Method
    - Interface
    - Delegate
    - Collection 
 */

// boxing - unboxing
//object obj = 5; // boxing 
//Console.WriteLine($"Boxing - {obj}");

//int number = (int)obj; // unboxing
//Console.WriteLine($"Unboxing - {number}");

// Generic

Some<int> some = new Some<int>();
some.Value = 365;
Some<double> some2 = new Some<double>();
some2.Value = 36.4;
some.Foo();
some2.Foo();
var result = some.Bar<string, char>("Salam", 'C');
Console.WriteLine(result);

class Some<T>
{
    public T Value { get; set; }
    public void Foo()
    {
        Console.WriteLine(Value.GetType());
    }

    public T2 Bar<T2, T3>(T2 value1, T3 value2)
    {
        Console.WriteLine(value1.GetType());
        Console.WriteLine(value2.GetType());
        return value1;
    } 
}
