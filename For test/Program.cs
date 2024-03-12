namespace For_test
{
    class MyClass
    {
        ~MyClass(){
            Console.WriteLine("Finalizer");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
        }
    }
}