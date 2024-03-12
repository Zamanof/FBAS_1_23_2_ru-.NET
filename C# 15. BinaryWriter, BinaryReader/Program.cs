
using System.Text;

string path = "file.dat";

string text = "Antananarivu is s capital of Madagascar";
int number = 3649;
double temperature = 36.6;

//using (FileStream file = new FileStream(path, FileMode.Create))
//{
//    using (BinaryWriter binaryWriter = new BinaryWriter(file, Encoding.Unicode))
//    {
//        binaryWriter.Write(text);
//        binaryWriter.Write(number);
//        binaryWriter.Write(temperature);
        
//    }
//}

//using (FileStream file = new FileStream(path, FileMode.Open))
//{
//    using (BinaryReader binaryReader = new BinaryReader(file, Encoding.Unicode))
//    {
//        Console.WriteLine(binaryReader.ReadString());
//        Console.WriteLine(binaryReader.ReadInt32());
//        Console.WriteLine(binaryReader.ReadDouble());
//    }
//}
