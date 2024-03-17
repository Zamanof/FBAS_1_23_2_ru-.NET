using System.Text.RegularExpressions;


#region Classic
// Classic variants for checking
//string password = "1";
//string mail = "salam@google";
//List<bool> criteries = new List<bool>() {false, false, false };
//for (int i = 0; i < password.Length; i++)
//{
//    if (password[i] >= 'A' && password[i] <= 'Z')
//    {
//        criteries[0] = true;
//    }
//    if (password[i] >= 'a' && password[i] <= 'z')
//    {
//        criteries[1] = true;
//    }
//    if (password[i] >= '0' && password[i] <= '9')
//    {
//        criteries[2] = true;
//    }
//}
//Console.WriteLine(criteries.All(x=> x==true));

//var upper = password.Any(x => x >= 'A' && x<= 'Z');
//Console.WriteLine(upper);
#endregion

// RegEx - Regular expression - регулярные выражения
/*
.           - любой один символ
\w          - любой алфавитно-цифровой символ
\W          - любой не алфавитно-цифровой символ
\s          - любой пробелный символ
\S          - любой непробелный символ
\d          - любая десятичная цифра
\D          - любой символ которая недесятичная цифра
[символы]   - любой символ из множества заданная внутри скобок
[^символы]  - любой символ кроме символов из множества заданной внутри скобок
*           - шаблон повторяеться 0 или более раз
+           - шаблон повторяеться 1 или более раз
?           - шаблон повторяеться 0 или 1 раз
{n, m}      - шаблон повторяеться не менее n и не более m раз
{n,}        - шаблон повторяеться не менее n раз
{n}         - шаблон повторяеться ровно n раз
^           - шаблон находится в начале текста
$           - шаблон находится в конце текста
*/

//string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$";
//string mailPattern = @"^((?!\.)[\w\-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W])$";
//string password = "qQerty1234";
//string mail = "salam@google";
//Regex regex = new Regex(passwordPattern);
//Regex regex2 = new Regex(mailPattern);
//Console.WriteLine(regex.IsMatch(password));
//Console.WriteLine(regex2.IsMatch(mail));


//string sen = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In libero arcu, venenatis sed posuere ut, pellentesque id odio. Donec dapibus mauris sed metus lacinia fringilla. Mauris condimentum luctus arcu vel tempus. Ut ut mi in velit rutrum molestie eu nec leo. Integer posuere elementum metus ac lobortis. Proin ut urna lorem. Cras eu egestas neque. Nullam dictum tempus leo non facilisis. Curabitur in ex feugiat nunc venenatis feugiat non lacinia odio. Aenean vulputate ex et urna auctor dapibus.";

//Console.WriteLine(sen);
//Console.WriteLine();
//Console.WriteLine(Regex.Replace(sen, @"\sIn\s", " Out ", RegexOptions.IgnoreCase));