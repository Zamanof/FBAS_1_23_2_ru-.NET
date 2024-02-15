// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/deconstruct

//int numb;
//bool check;
//string name;

//var returnValues = Foo();
//numb = returnValues.Item1;
//check = returnValues.Item2;
//name = returnValues.Item3;
////(numb, check, name) = Foo();
//Console.WriteLine($"numb = {numb}");
//Console.WriteLine($"check = {check}");
//Console.WriteLine($"name = {name}");


//(int numb, _, string name) = Foo();
//Console.WriteLine($"numb = {numb}");

//Console.WriteLine($"name = {name}");


//(int, bool, string) Foo()
//{
//    return (35, true, "Salam");
//}

Car car = new("Zapi", 1967);
string? model = car.Model;
int year = car.Year;
Console.WriteLine($"model: {model} year: {year}");

var (mod, yr) = car;
Console.WriteLine($"model: {mod} year: {yr}");

class Car
{
    public string? Model { get; set; }
    public int Year { get; set; }
    public Car(string Model, int Year)
    {
        this.Model = Model;
        this.Year = Year;
    }
    public void Deconstruct(out string? model, out int year)
    {
        model = Model;
        year = Year;
    }
}