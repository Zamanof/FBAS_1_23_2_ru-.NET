namespace C__05._Namespaces
{
    internal static class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static double Divide(int a, int b)
        {
            if (a == 0)
            {
                Console.WriteLine("Can not divide by Zero");
                return 0;
            }
            return (double)a / b;
        }
        public static int Multiple(int a, int b)
        {
            return a * b;
        }
    }
}
