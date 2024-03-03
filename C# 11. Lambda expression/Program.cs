using System.Collections.Generic;


//List<int> list = new() { 1, 32, 6, 11, 12, 16, 13, 112, 1687 };
//// lambda expression - (paramter(s)) => return value
//// delegate (int n) { return n % 2 == 0;} ->  (n) => numb%2 == 0;

//var evens = list.Where((n)=> n % 2 == 0).ToList();
//var odds = list.Where(n => n % 2 != 0).ToList();
//var greateFive = Filter(list, n => { 
//    // some other code
//    // some other code
//    // some other code
//    // some other code
//    return n > 5; 
//} ).ToList();
//foreach (var item in evens)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();
//foreach (var item in odds)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

//foreach (var item in greateFive)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

Func<int, int, int> f = (a, b) => a + b;
Func<int, int, int> foo = delegate (int a, int b) { return a + b; } ;
Console.WriteLine(f(5, 10));
Console.WriteLine(foo(5, 10));
Console.WriteLine(f.Invoke(5, 10));
Console.WriteLine(foo.Invoke(5, 10));

//IEnumerable<int> Filter(List<int> ints, Func<int, bool> predicate)
//{
//    var tmp = new List<int>();
//    foreach (var item in ints)
//    {
//        if (predicate(item)) tmp.Add(item);
//    }
//    return tmp;
//}

