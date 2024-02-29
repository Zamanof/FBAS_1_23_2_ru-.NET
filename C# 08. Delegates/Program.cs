// delegates

// delegate return_datatype delegate_name(parameters)
//public delegate int MyIntDelegate(int numb1, int numb2);


#region delegates

//double numb1 = default, numb2 = default;
//Console.WriteLine("Enter first number: ");
//double.TryParse(Console.ReadLine(), out numb1);
//Console.WriteLine("Enter second number: ");
//double.TryParse(Console.ReadLine(), out numb2);

//char operation = default;
//Console.WriteLine("Choice operation +, -, *, /: ");
//char.TryParse(Console.ReadLine(), out operation);
//CalculatorDelegate calculator = null;
//switch ((operators)operation)
//{
//    case operators.ADD:
//        calculator = Add;
//        break;
//    case operators.SUBTRACT:
//        calculator = Subtract;
//        break;
//    case operators.MULTIPLE:
//        calculator = Multiple;
//        break;
//    case operators.DIVIDE:
//        calculator = Divide;
//        break;
//    default:
//        Console.WriteLine("Incorrect operation!!!");
//        break;
//}

////if (calculator is not null)
////{
////    Console.WriteLine(calculator(numb1, numb2));
////}

//if (calculator is not null)
//{
//    Console.WriteLine(calculator.Invoke(numb1, numb2));
//}


//double.TryParse(Console.ReadLine(), out numb1);

//double Add(double left, double right)
//{
//    return left + right;
//}
//double Subtract(double left, double right)
//{
//    return left - right;
//}

//double Multiple(double left, double right)
//{
//    return left * right;
//}

//double Divide(double left, double right)
//{
//    if (right != 0) return left / right;
//    throw new DivideByZeroException();
//}
//public delegate double CalculatorDelegate(double left, double right);
//enum operators { ADD = '+', SUBTRACT = '-', MULTIPLE = '*', DIVIDE = '/' }
#endregion


#region Multicast delegates
//double numb1 = 15, numb2 = 20;
////CalculatorDelegate calculators = Add;
//GenericCalcDelegate<double> calculators = Add;
//calculators += Subtract;
//calculators += Divide;
//calculators += Multiple;

//GenericCalcDelegate<int> fooDelegate = Foo;
//Console.WriteLine(fooDelegate(5, 2));

////foreach (CalculatorDelegate calculator in calculators.GetInvocationList())
////{
////    Console.WriteLine(calculator(numb1, numb2));
////}

////foreach (GenericCalcDelegate<double> calculator in calculators.GetInvocationList())
////{
////    Console.WriteLine(calculator(numb1, numb2));
////}

////var del = calculators.GetInvocationList();
////Console.WriteLine(del[0].Method); 
////Console.WriteLine(del[0].DynamicInvoke(2, 3)); 
//double Add(double left, double right)
//{
//    return left + right;
//}
//double Subtract(double left, double right)
//{
//    return left - right;
//}

//double Multiple(double left, double right)
//{
//    return left * right;
//}

//double Divide(double left, double right)
//{
//    if (right != 0) return left / right;
//    throw new DivideByZeroException();
//}

//int Foo(int a, int b)
//{
//    return a % b;
//}
//public delegate double CalculatorDelegate(double left, double right);

//// Generic delegates
//public delegate T GenericCalcDelegate<T>(T left, T right);

#endregion

// Action<T>, Func<T>, Predicate<T>, Comparison<T>
using System.Threading.Channels;

List<int> numbers = new List<int>() { 1, 119, 5, 865, 45, 66, 111, 22, 33, 44 };
#region Action
//int[] arr = new int[25];
//Random random = new Random();
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = random.Next(10, 99);
//}
//foreach (int i in arr)
//{
//    Console.Write($"{i} ");
//}
//Console.WriteLine();

////Opertions(arr, ShowSquare);
//Opertions(arr, ShowNegative);
//Action<int, double> action1 = Foo1;
//action1.Invoke(2, 63.6);
//void Opertions(int[] ints, Action<int> action)
//{
//    foreach (var item in ints)
//    {
//        action(item);
//    }
//    Console.WriteLine();
//}

//void ShowSquare(int num)
//{
//    Console.Write($"{num * num} ");
//}

//void ShowNegative(int num)
//{
//    Console.Write($"{-num} ");
//}

//void Foo1(int a, double b)
//{
//    Console.WriteLine(a * b);
//}

#endregion

#region Func
// Func<T>

//var evens = filterNumbers(numbers, isEven);
//var odds = filterNumbers(numbers, isOdd);
////evens.ForEach(Console.WriteLine);
//odds.ForEach(Console.WriteLine);


//List<int> filterNumbers(List<int> ints, Func<int, bool> func)
//{
//    var lst = new List<int>();
//    foreach (var item in ints)
//    {
//        if(func(item)) lst.Add(item);
//    }
//    return lst;
//}
//bool isEven(int numb)
//{
//    return numb% 2 == 0;
//}

//bool isOdd(int numb)
//{
//    return numb % 2 != 0;
//}

#endregion

#region Predicate
// Predicate<T>

//ShowNumbers(numbers, GreaterThanHundred);
//void ShowNumbers(List<int> ints, Predicate<int> pred)
//{
//    foreach (var item in ints)
//    {
//        if(pred(item)) Console.WriteLine(item);
//    }
//}

//bool GreaterThanHundred(int numb)
//{
//    return numb > 100;
//}

#endregion

#region Comparison

//List<Human> humans = new()
//{
//    new Human{Name="Salam", Age = 18},
//    new Human{Name="Vahid", Age = 15},
//    new Human{Name="Akif", Age = 35},
//    new Human{Name="Fuad", Age = 32},
//    new Human{Name="Hakim", Age = 11},
//};

////humans.Sort(NameComparison);

//humans.ForEach(Console.WriteLine);


//int NameComparison(Human left, Human right)
//{
//    return left.Name.CompareTo(right.Name);
//}

//int AgeComparison(Human left, Human right)
//{
//    //return left.Age.CompareTo(right.Age);
//    if (left.Age > right.Age) return 1;
//    else if (left.Age < right.Age) return -1;
//    else return 0;
//}
//class Human
//{
//    public string? Name { get; set; }
//    public int Age { get; set; }
//    public override string ToString()
//    {
//        return $"{Name} - {Age}";
//    }
//}
#endregion
