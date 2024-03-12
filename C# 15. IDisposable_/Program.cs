using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__15.IDisposable_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Foo foo = new Foo();
            //foo.Dispose();
            Foo bar = new Foo();
            bar.Bar();
        }
    }
    class Foo : IDisposable
    {
        private bool _isDisposed = false;
        private void Cleaning(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Managed resources are cleaned");
                }
                Console.WriteLine("UnManaged resources are cleaned");
                _isDisposed = true;
            }
        }
        public void Dispose()
        {
            Cleaning(true);
            GC.SuppressFinalize(this);
        }
        public void Bar()
        {
            Console.WriteLine("Something operations");
            throw new NotImplementedException();
        }
        ~Foo() { Cleaning(false); }
    }
}
