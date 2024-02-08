Random random = new Random();
//int[] arr = new int[10];
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = random.Next(10, 99);
//}

//// $"{item} "   - интерполяция строк
//foreach (int item in arr)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();
//var arr2 = arr.Reverse();
//foreach (int item in arr2)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

//Array.Sort(arr);
//Array.Reverse(arr);
//foreach (int item in arr)
//{
//    Console.Write($"{item} ");
//}

//int[] myArray = { 2, 5, 96, 1 };
//Console.WriteLine(myArray.Length);
//Console.WriteLine(myArray.Rank);



// Multidimension arrays

//int[,] multiArray = new int[3, 3];
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        multiArray[i, j] = random.Next(10, 99);
//    }
//}

//Console.WriteLine(multiArray[1, 2]);

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write($"{multiArray[i, j]}\t");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine($"Rank - {multiArray.Rank}");


// jagged array
//int[][] jArr = new int[5][];
//jArr[0] = new int[2];
//jArr[1] = new int[3];
//jArr[2] = new int[1];
//jArr[3] = new int[10];
//jArr[4] = new int[5];

//for (int i = 0; i < jArr.Length; i++)
//{
//    for (int j = 0; j < jArr[i].Length; j++)
//    {
//        jArr[i][j] = random.Next(10, 99);
//    }
//}

//for (int i = 0; i < jArr.Length; i++)
//{
//    for (int j = 0; j < jArr[i].Length; j++)
//    {
//        Console.Write($"{jArr[i][j]} ");
//    }
//    Console.WriteLine();
//}


// string vs StringBuilder