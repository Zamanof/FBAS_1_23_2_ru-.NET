Random random = new Random();
int[] ints = new int[10];
for (int i = 0; i < ints.Length; i++)
{
    ints[i] = random.Next(10, 99);
}

// Ranges
// lst[2:5]
//int[] ints2 = ints[2..5];

foreach (var item in ints)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

//foreach (var item in ints2)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

// indicies
Console.WriteLine(ints[^1]);
Console.WriteLine(ints[^3]);
ints[0] = 1_236_483;