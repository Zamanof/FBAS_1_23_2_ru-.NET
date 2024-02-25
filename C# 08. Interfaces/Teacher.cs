// От классов наследуются,
// Интерфейсы реализуют

// Наследовани от класса это отнощение "является"(is)
// Реализация интерфейса это в основном "умеет" (can do)

// Интерфейса это контракт который надо соблюдать



class Teacher : Human, IWalk, IThink, ITeach
{
    public void Teach()
    {
        Console.WriteLine("I can teach");
    }

    public void Think()
    {
        Console.WriteLine("I think like Human");
    }

    public void Walk()
    {
        Console.WriteLine("I have two legs. And I walk");
    }
}


