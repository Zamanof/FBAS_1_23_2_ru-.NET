
//Console.WriteLine("Enter first number: ");
//Int32.TryParse(Console.ReadLine(), out int first);
//Console.WriteLine("Enter second number: ");
//Int32.TryParse(Console.ReadLine(), out int second);
//Console.WriteLine("1. Add\n2. Subtract\n3. Multiplie\n4. Divide");
//Console.WriteLine("Choice operation: ");

//Int32.TryParse(Console.ReadLine(), out int choice);

//switch (choice)
//{
//    case 1:
//        Console.WriteLine(first + second);
//        break;
//    case 2:
//        Console.WriteLine(first - second);
//        break;
//    case 3:
//        Console.WriteLine(first * second);
//        break;
//    case 4:
//        if(second != 0) Console.WriteLine(first / second);
//        else Console.WriteLine("Cannot divide by Zero");
//        break;
//}

//string ch = "Hi";

//switch (ch)
//{
//    case "Salam":
//        Console.WriteLine("Salam");
//        break;
//    case "Hi":
//        Console.WriteLine("Hi"); 
//        break;
//}


//Console.WriteLine("Enter month number");
//Int32.TryParse(Console.ReadLine(), out int monthNumber);

//switch (monthNumber)
//{
//    case (int)Month.JANUARY:
//        goto case (int)Month.DECEMBER;
//    case (int)Month.MARCH:
//        goto case (int)Month.DECEMBER;
//    case (int)Month.MAY:
//        goto case (int)Month.DECEMBER;
//    case (int)Month.JULY:
//        goto case (int)Month.DECEMBER;
//    case (int)Month.AUGUST:
//        goto case (int)Month.DECEMBER;
//    case (int)Month.OCTOBER:
//        goto case (int)Month.DECEMBER;
//    case (int)Month.DECEMBER:
//        Console.WriteLine("31");
//        break;
//    case (int)Month.FEBRUARY:
//        Console.WriteLine("28 or 29");
//        break;
//    case (int)Month.APRIL:
//        goto case (int)Month.NOVEMBER;
//    case (int)Month.JUNE:
//        goto case (int)Month.NOVEMBER;
//    case (int)Month.SEPTEMBER:
//        goto case (int)Month.NOVEMBER;
//    case (int)Month.NOVEMBER:
//        Console.WriteLine("30");
//        break;
//    default:
//        Console.WriteLine("Incorrect month number");
//        break;
//}


//string result = Convert.ToInt32(Console.ReadLine()) switch
//{
//    0 => "Zero",
//    1 => "One",
//    2 => "Two",
//    _ => "Empty"
//};
//Console.WriteLine(result);

enum Month
{
    JANUARY = 1,
    FEBRUARY,
    MARCH,
    APRIL,
    MAY,
    JUNE,
    JULY,
    AUGUST,
    SEPTEMBER,
    OCTOBER,
    NOVEMBER,
    DECEMBER
}