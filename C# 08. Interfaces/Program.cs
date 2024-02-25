// От классов наследуются,
// Интерфейсы реализуют

// Наследовани от класса это отнощение "является"(is)
// Реализация интерфейса это в основном "умеет" (can do)

// Интерфейса это контракт который надо соблюдать

IWalk[] walk = new IWalk[]
{
    new Teacher(),
    new Cat()
};

IThink[] thinks = new IThink[]
{
    new Teacher(),
    new Cat()
};

Foo(thinks[0]);
Foo(thinks[1]);
void Foo(IThink think)
{
    think.Think();
}


