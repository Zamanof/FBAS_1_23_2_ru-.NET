// in reference
// ?. - null conditional
// ?? - null coalesing

#region in reference
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
//Nullable<int> code = null;
int? dataBaseCodeValue = 26;
int? code = dataBaseCodeValue;
Console.WriteLine(code + 52);


#endregion
