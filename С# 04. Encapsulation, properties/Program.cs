#region Encapsulation Get Set
//Human human = new();
//human.SetAge(1500);
//Console.WriteLine(human.GetAge());
//class Human
//{
//    public string name;
//    public string surname;
//    private int _age;

//    public int GetAge()
//    {
//        return _age;
//    }
//    public void SetAge(int age)
//    {
//        if (age < 0 || age > 150) 
//        {
//            throw new ArgumentOutOfRangeException("0 ~ 150");
//        }
//        _age = age;
//    }

//}
#endregion

#region Properties (full, auto)

Human human = new();
human.Age = 20;
Console.WriteLine(human.Age);
human.Name = "Test";
Console.WriteLine(human.Name);
Console.WriteLine(human.Name.Length);
human.BirthDate = new DateTime(1980,10, 7);
Console.WriteLine(human.BirthDate.ToShortDateString());

partial class Human
{
    // auto property
    public string Name { get; set; } = "John";
    public string Surname { get;} = "Doe";
    public string GroupName {  private get;  set; } = "Doe";

    // full property
    private int age;
    public int Age
    {
        get { return age; }
        set 
        {
            if (value < 0 || value > 150)
                throw new ArgumentOutOfRangeException("Out of range 0~150");
            age = value; 
        }
    }
    
    //public int get_Age()
    //{
    //    return age;
    //}
    //public void set_Age(int value)
    //{

    //}


}
#endregion
