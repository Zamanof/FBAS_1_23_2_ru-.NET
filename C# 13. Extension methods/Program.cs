// Extension methods

string word = "Lorem ipsum dolor sit amet";
Console.WriteLine(word.CountWords());
Console.WriteLine(word.CountSpaces());
Console.WriteLine(word.CountVowels());

//string numb = "164641";
var number = Console.ReadLine()?.StringToInt();
Console.WriteLine(number + 5);

static class StringExtension
{
    public static int CountWords(this string str)
    {
        if( string.IsNullOrEmpty( str ))
        {
            return 0;
        }
        return str.Split(' ').Length;
    }

    public static int CountSpaces(this string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return 0;
        }
        return str.Count(s => s == ' ');
    }

    public static int CountVowels(this string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return 0;
        }
        return str.Count(s => s == 'a' || s== 'o' || s == 'u' || s == 'i' || s == 'e');
    }


    public static int StringToInt(this string str)
    {
        int number = default;
        if (string.IsNullOrEmpty(str)) { throw new Exception("string empty"); }
        else if (!str.All(s => s >= '0' && s <= '9'))
        {
            throw new Exception("not all symbols number");
        }
        else
        {
            number = int.Parse(str);
        }
        return number;

    }
}
