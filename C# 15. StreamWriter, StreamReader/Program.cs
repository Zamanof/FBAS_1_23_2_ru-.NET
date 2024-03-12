// StreamReader, StreamWriter

using System.Text;

string text = "Lorem ipsum dolor";
//using (FileStream file = new FileStream("file.txt", FileMode.Create))
//{
//    using (StreamWriter streamWriter = new StreamWriter(file, Encoding.Unicode))
//    {
//        foreach (var symbol in text)
//        {
//            streamWriter.Write($"{symbol} ");
//        }
//    }
//}


using (FileStream file = new FileStream("file.txt", FileMode.Open))
{
    using (StreamReader streamReader = new StreamReader(file, Encoding.Unicode))
    {
        string line = streamReader.ReadToEnd();
        Console.WriteLine(line);
    }
}

