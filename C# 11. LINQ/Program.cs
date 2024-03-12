// LINQ - Language Integrated Query

// LINQ To Object
// LINQ To Dataset
// LINQ To SQL
// LINQ To Xml
// LINQ To Entities
// PLINQ - Parlel LINQ

int[] arr = { 1, 32, -6, 11, 12, 16,- 13, 112, 1687 , 7, 8 , 9, 52, -31, 654, -23};

IEnumerable<int> query = from i in arr 
                         select i;

//foreach (var item in query)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

//arr[5] = 2;


// where 
//query = from i in arr
//        where i < 0
//        select i;



// orderby ascending descending

//query = from i in arr
//        where i > 0
//        orderby i descending
//        select i;

//foreach (var item in query)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

// group by
//var group = from i in arr
//            where i > 0
//            group i by i % 2;

//foreach (var item in group)
//{
//    Console.WriteLine(item.Key);
//    foreach (var value in item)
//    {
//        Console.WriteLine($"    {value}");
//    }
//}

// into

var query_into = from i in arr
                 where i > 0
                 group i by i % 2 into result
                 from j in result
                 where j % 3 == 0
                 group j by j % 10;

foreach (var item in query_into)
{
    Console.WriteLine(item.Key);
    foreach (var value in item)
    {
        Console.WriteLine($"    {value}");
    }
}