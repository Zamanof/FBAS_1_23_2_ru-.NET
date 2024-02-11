using System.Text;

string name = "Nadir";
name = "Rasul";

//for (int i = 0; i < 100; i++)
//{
//    name += "a";
//}

StringBuilder sb = new StringBuilder(name);
for (int i = 0; i < 100; i++)
{
    sb.Append("a");
    Console.WriteLine($"Capacity = {sb.Capacity}");
    Console.WriteLine($"Length = {sb.Length}");
    Console.WriteLine();
}
//Console.WriteLine(name);
name = sb.ToString();
Console.WriteLine(sb);
Console.WriteLine(name);