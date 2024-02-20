// indexer
// datatype this[argument_type] {get; set;}

using System.Threading.Channels;

//Garage garage = new(3);
//garage[0] = new Car { Model = "Nissan", Price = 50001 };
//garage[1] = new Car { Model = "Audi", Price = 5002 };

//for (int i = 0; i < garage.Count; i++)
//{
//    Console.WriteLine(garage[i]);
//}
//Console.WriteLine(garage["Nissan"]);
//Console.WriteLine(garage["Audi"]);
//garage["Audi"] = new Car { Model = "Audi", Price = 50002 };
//Console.WriteLine(garage["Audi"]);
//Console.WriteLine(garage["Salam"]);

MultiArray multiArray = new(5, 5);
for(int i = 0; i < 5; i++)
{
    for(int j = 0; j < 5; j++)
    {
        multiArray[i, j] = i * 5 + j;
    }
}

for (int i = 0; i < 5; i++, Console.WriteLine())
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{multiArray[i, j]}\t");
    }
}
class Car
{
    public string? Model { get; set; }
    public double Price { get; set; }
    public override string ToString()
    {
        return $"{Model} - {Price}$";
    }
}

class Garage
{
    Car[] cars;
    public Garage(int count)
    {
        cars = new Car[count];
    }
    public int Count
    {
        get { return cars.Length; }
    }

    public Car this[int index]
    {
        get
        {
            if (index >= 0 && index < cars.Length)
            {
                return cars[index];
            }
            throw new IndexOutOfRangeException();
        }
        set
        {
            cars[index] = value;
        }
    }

    public Car this[string model]
    {
        get
        {
            if(Enum.IsDefined(typeof(Models), model))
            {
                return cars[(int)Enum.Parse(typeof(Models), model)];
            }
            return new Car();
        }
        set
        {
            cars[(int)Enum.Parse(typeof(Models), model)] = value;
        }
    }
}

class MultiArray
{
    private int[,] array;
    public int Rows { get; set; }
    public int Columns { get; set; }

    public MultiArray(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        array = new int[rows, columns];
    }
    public int this[int row, int column]
    {
        get => array[row, column];
        set => array[row, column] = value;
    }
}

enum Models { Nissan, Audi,  Toyota, NAZ, Lamborghini}