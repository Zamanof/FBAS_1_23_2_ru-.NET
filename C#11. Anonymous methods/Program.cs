using System.Collections.Generic;

List<int> list = new() { 1, 32, 6, 11, 12, 16, 13, 112, 1687 };

//var evens = list.Where(isEven).ToList();
var evens = list.Where(delegate(int numb) { return numb % 2 == 0; }).ToList();
var odds = list.Where(delegate(int numb) { return numb % 2 != 0; }).ToList();
var greateFive = Filter(list, delegate (int numb) { return numb > 5; }).ToList();
foreach (var item in evens)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
foreach (var item in odds)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

foreach (var item in greateFive)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

IEnumerable<int> Filter(List<int> ints, Func<int, bool> predicate)
{
    var tmp = new List<int>();
    foreach (var item in ints)
    {
        if (predicate(item)) tmp.Add(item);
    }
    return tmp;
}

//bool isEven(int numb)
//{
//    return numb % 2 == 0;
//}
