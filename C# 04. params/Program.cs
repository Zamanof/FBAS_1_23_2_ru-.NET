// отправка в метод "бесконечное" число параметров
Console.WriteLine(Summ(new int[] { 2, 68, 9, 44, 9}));
Console.WriteLine(SummParams(2, 68, 9, 44, 9));


int Summ(int[] ints)
{
    int result = 0;
    for (int i = 0; i < ints.Length; i++)
    {
        result += ints[i];
    }
    return result;
}

int SummParams(params int[] ints)
{
    int result = 0;
    for (int i = 0; i < ints.Length; i++)
    {
        result += ints[i];
    }
    return result;
}
