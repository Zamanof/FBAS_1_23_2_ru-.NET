// Exceptions
int numb1 = 3;
int numb2 = 0;
int result = default;
//result = numb1 / numb2;
try
{
    //result = numb1 / numb2;
    result = Foo(numb1, numb2);
    Console.WriteLine(result);
}
catch (MyException ex)
{
    Console.WriteLine("Catch in Main - MyException");
    Console.WriteLine(ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Catch in Main - DivideByZeroException");
    Console.WriteLine();
    Console.WriteLine($"Message: {ex.Message}");
    Console.WriteLine();
    Console.WriteLine($"Target site: {ex.TargetSite}");
    Console.WriteLine();
    Console.WriteLine($"Trace: {ex.StackTrace}");
}
// exception filters
catch (Exception ex) when (ex.InnerException != null)
{
    Console.WriteLine("Catch in Main - Exception ex with filter");
    Console.WriteLine();
    Console.WriteLine($"Message: {ex.Message}");
    Console.WriteLine();
    Console.WriteLine($"Target site: {ex.TargetSite}");
    Console.WriteLine();
    Console.WriteLine($"Trace: {ex.StackTrace}");
    Console.WriteLine();
    Console.WriteLine(ex.InnerException.Message);
}

catch (Exception ex)
{
    Console.WriteLine("Catch in Main - Exception ex without filter");
    Console.WriteLine();
    Console.WriteLine($"Message: {ex.Message}");
    Console.WriteLine();
    Console.WriteLine($"Target site: {ex.TargetSite}");
    Console.WriteLine();
    Console.WriteLine($"Trace: {ex.StackTrace}");
    Console.WriteLine();
}
finally
{
    Console.WriteLine("Final block");
}

int Foo(int a, int b)
{
    int result = default;
    int[] arr = new int[3];
    try
    {
        result = a / b;
        Console.WriteLine(arr[5]);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Catch in foo");
        //Console.WriteLine(ex.Message);
        //throw;
        //throw new Exception("Salam Aleykum");
        throw new MyException("This is Spartaaa");
    }

    return result;
}
