int number = 5;
int[] arr = new int[] { 2, 9, 5, 8, 6, 7 };
Console.WriteLine($"number before call Foo {number}");
Console.Write("array before call Foo: ");
ShowArray(arr);

int numb = default;
int numb2;
Console.WriteLine($"numb before call Foo {numb}");
Foo(number, arr, ref numb, out int numb1);
Foo(number, arr, ref numb, out numb2);
int.TryParse(Console.ReadLine(), out int some);
Console.WriteLine(some);


Console.WriteLine($"number after call Foo {number}");
Console.Write("array after call Foo: ");
ShowArray(arr);
Console.WriteLine($"numb after call Foo {numb}");
Console.WriteLine($"numb1 after call Foo {numb1}");
Console.WriteLine($"numb2 after call Foo {numb2}");
void Foo(int number, int[] arr, ref int number1, out int number2)
{
    number += 5;
    arr[0] = number;
    number2 = arr[3];
    number1 = arr[4];
}

void ShowArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

bool TryParse(string value, out int result)
{
    try
    {
        result = Convert.ToInt32(value);
        return true;
    }
    catch (Exception)
    {
        result = default;
        return false;
    }

}

// Передача параметров  в методы
// ref, out, in
// Задание: прочитать про in