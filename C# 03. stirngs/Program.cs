//string str = "Hello";
//string str2 = new string('_', 10);
//Console.WriteLine(str2);

//char[] chars = new char[] { 'S', 'a', 'l', 'a', 'm' };
//string str3 = new string(chars);
//Console.WriteLine(str3);

//string str4 = "Hello";
//string str5 = "Hello";
//Console.WriteLine(str4 == str5);
//Console.WriteLine(str4.Equals(str5));

//string name = "nadir";
//Console.WriteLine(name[2..4]);
////Console.WriteLine(name[^1]);
////name = name.ToUpper();
////Console.WriteLine(name);
//name = name.ToUpper()[0] + name[1..];
//Console.WriteLine(name);



//string name1 = "Nadir";
//string code = $$"""
//    string name = {{name1}};
//    name += " Zamanov";
//    Console.WriteLine(name);
//    """;

//Console.WriteLine(code);

string lorem = "Neque porro quisquam est " +
    "qui dolorem ipsum quia dolor sit amet, " +
    "consectetur, adipisci velit";

// @ - verbatim
string lorem2 = @"Neque porro quisquam est 
qui dolorem ipsum quia dolor sit amet, 
consectetur, adipisci velit";

string path = $@"C:\Users\zamanov\Downloads\{2}";
Console.WriteLine(lorem);
Console.WriteLine(lorem2);