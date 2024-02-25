// От классов наследуются,
// Интерфейсы реализуют

// Наследовани от класса это отнощение "является"(is)
// Реализация интерфейса это в основном "умеет" (can do)

// Интерфейса это контракт который надо соблюдать



class Cat : Animal, IWalk, IThink, ISound
{
    public void Sound()
    {
        throw new NotImplementedException();
    }

    public void Think()
    {
        Console.WriteLine("I think about ball of wool");
    }

    public void Walk()
    {
        Console.WriteLine("I have four legs. And I walk");
    }
}


