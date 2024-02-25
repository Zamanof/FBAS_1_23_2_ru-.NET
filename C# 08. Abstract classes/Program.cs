//Lamina lamina = new();

Tac ticToe = new Tac();
//ticToe.Think();
//ticToe.Walk();

//Foo(ticToe);
//Foo(new Arbok());

Ekans ekans = new Arbok();

Lamina[] laminas =
{
    new Arbok(),
    ticToe,
    ekans

};

foreach (var i in laminas)
{
    i.Walk();
}


void Foo(Lamina lamina)
{
    lamina.Walk();
}

abstract class Lamina
{
    public abstract void Walk();
    public void Think()
    {
        Console.WriteLine("Yes we can think. Because we are not animal. We are Lamina");
    }
}

class Tac : Lamina
{
    public override void Walk()
    {
        Console.WriteLine("I am king of laminas");
    }
}

abstract class Ekans: Lamina
{
    public abstract void Bite();
}

class Arbok : Ekans
{
    public override void Bite()
    {
        Console.WriteLine("I can bite like bee");
    }

    public override void Walk()
    {
        Console.WriteLine("I can't walk") ;
    }
}