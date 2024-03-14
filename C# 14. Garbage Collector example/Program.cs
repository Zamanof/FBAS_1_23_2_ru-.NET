Console.WriteLine(GC.MaxGeneration);
GarbageHelper garbageHelper = new GarbageHelper();
Console.WriteLine($"Generation {GC.GetGeneration(garbageHelper)}");
garbageHelper.MakeGarbage();
Console.WriteLine($"Memory: {GC.GetTotalMemory(false)} bytes");
GC.Collect();
Console.WriteLine($"Generation {GC.GetGeneration(garbageHelper)}");
GC.Collect();
Console.WriteLine($"Generation {GC.GetGeneration(garbageHelper)}");
GC.Collect();
GC.Collect();
class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public byte Age { get; set; }
}

class GarbageHelper
{
    public void MakeGarbage()
    {
        for (int i = 0; i < 1000; i++)
        {
            Person person = new Person();
        }
    }
}