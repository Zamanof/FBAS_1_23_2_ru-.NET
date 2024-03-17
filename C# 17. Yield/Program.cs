// yield return, yield break

var strings = GetResults();
//strings.MoveNext();
//Console.WriteLine(strings.Current);
//strings.MoveNext();
//Console.WriteLine(strings.Current);
//strings.MoveNext();
//Console.WriteLine(strings.Current);

//var result = GetValues();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
string name = "Salam";

foreach (var i in MyRange(5, 1, 3))
{
    //Console.Write(name[i]);
    Console.WriteLine(i);
}

IEnumerator<string> GetResults()
{
    yield return "Salam";
    yield return "Hi";
    yield return "Goodbye";
}

IEnumerable<string> GetValues()
{
    var result = new List<string>() { "Hi", "Goodbye", "Salam", "Hello"};
    //yield return "Salam";
    //yield return "Hi";
    //yield return "Goodbye";
    for (int i = 0; i < result.Count; i++)
    {
        yield return result[i].ToUpper();
    }
}

IEnumerable<int> MyRange(int start, int? end = null, int steps = 1)
{
    if (start > end && steps > 0) yield break;
    if (end == null) { end = start; start = 0; }

    for (int i = start; i != end; i += steps)
    {
        yield return i;
    }
}
