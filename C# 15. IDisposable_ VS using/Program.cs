//Foo foo = new Foo();
//foo.Bar();
//foo.Dispose();
//try
//{
//    foo.Bar();
//}
//finally
//{
//    foo.Dispose();
//}


//using (Foo fooNew = new Foo())
//{
//    fooNew.Bar();
//}

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
    public void Bar()
    {
        Console.WriteLine("Something operations");
        //throw new NotImplementedException();
    }
    public void Dispose()
    {
        Cleaning(true);
        GC.SuppressFinalize(this);
    }
 
}
