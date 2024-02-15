// in reference
// ?. - null conditional
// ?? - null coalesing
// ! - null forgiving https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/null-forgiving

#region in reference
// https://www.c-sharpcorner.com/article/c-sharp-7-2-in-parameter-and-performance/
//MyStruct myStruct = new MyStruct();
//myStruct.Value = 25;
//myStruct.Value1 = 30;

//Foo(myStruct);
//void Foo(in MyStruct myStruct)
//{
//    Console.WriteLine(myStruct.Value);
//    Console.WriteLine(myStruct.Value1);
//}
//struct MyStruct
//{
//    public int Value;
//    public int Value1 { get; set; }
//}
#endregion

#region ?.
// https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-
//string name = "SALAM";

//if (name != null)
//{
//    name = name.ToLower();
//    Console.WriteLine(name);
//}

//if (name is not null)
//{
//    name = name.ToLower();
//    Console.WriteLine(name);
//}

//name = name?.ToLower()!;
//Console.WriteLine(name);
#endregion

#region ??
// https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/null-coalescing-operator
string str = null;

//if (str is null)
//{
//    str = "Empty";
//}

string str1 = str == null ? "Empty" : str;

string str2 = str ?? "Empty";

Console.WriteLine(str1);
Console.WriteLine(str2);
#endregion

#region Nullable type
// https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/nullable-value-types
// Nullable<int> code = null;
int? dataBaseCodeValue = 26;
int? code = dataBaseCodeValue;
Console.WriteLine(code + 52);


#endregion
