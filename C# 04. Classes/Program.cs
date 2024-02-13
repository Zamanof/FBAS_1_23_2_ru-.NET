Human human = new Human();
//Console.WriteLine(Human.count);
//Console.WriteLine(human);

human.Foo();




// Class
// internal - Доступен только в сборке где определен этот класс (по умолчанию)
// public - Доступен любому коду в любых сборках
class Human 
{
    // private - поля и методы доступны внутри класса и вложенных классах
    // protected - поля и методы доступны методам вложенного или дочернего класса
    // internal - поля и методы доступны толко в методах нашей сборки
    // protected internal - поля и методы доступны только тем методам вложенного или дочернего класса в нашей сборке
    // public - поля и методы доступны всем методам во всех сборках

    public string name;
    public string surname;
    public int age;

    public static int count;
    public const int field1 = 25;
    public readonly int field2;

    static Human()
    {
        count = 5;
    }
    public Human():
        this("John", "Doe", 18)
        {}
    public Human(string name, string surname, int age)
        : this(name, surname, age, 0)
    { }
    public Human(string name, string surname, int age, int field2 = 0)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.field2 = field2;
        count += 1;
    }
    public void Foo()
    {
        Kirqudu.Bambarbiya(this);
    }
    public override string ToString()
    {
        return $@"Name: {name}
Surname: {surname}
Age: {age}";
    }

}

class Kirqudu
{
    public static void Bambarbiya(Human human)
    {
        Console.WriteLine("Bambarbiya kirqudu");
        Console.WriteLine(human);
    }
}