using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

Book book = new Book() {
    Author= new Author("Jopseph", "Albahari"),
    Title = "C# 12 in a NUtshell",
    Description = "Full guide for C# language",
    Price = 50
};

List<Book> books = new() {
    book,
    new Book() {
    Author= new Author {FirstName = "Jeffrey", LastName="Richter" },
    Title = "C# Vis CLR",
    Description = "Full guide for C# language",
    Price = 50.65
}
};

#region BinaryFormatter
// BinaryFormatter
//BinaryFormatter formatter = new BinaryFormatter();

//using (FileStream file = new FileStream("book.bin", FileMode.OpenOrCreate))
//{
//    formatter.Serialize(file, book);
//}


//using (FileStream file = new FileStream("book.bin", FileMode.Open))
//{
//    var result = (Book)formatter.Deserialize(file);
//    result.Id = Guid.NewGuid();
//    Console.WriteLine(result);
//}

// List to file
//using (FileStream file = new FileStream("books.bin", FileMode.OpenOrCreate))
//{
//    formatter.Serialize(file, books);
//}


//using (FileStream file = new FileStream("books.bin", FileMode.Open))
//{
//    var result = (List<Book>)formatter.Deserialize(file);
//    foreach (var item in result)
//    {
//        Console.WriteLine(item);
//    }
//}
#endregion

#region XML Serialization
//XmlSerializer serializer = new XmlSerializer(typeof(Book));

//using (FileStream file = new FileStream("book.xml", FileMode.OpenOrCreate))
//{
//    serializer.Serialize(file, book);
//}

//using (FileStream file = new FileStream("book.xml", FileMode.Open))
//{

//    var result = (Book)serializer.Deserialize(file);
//    Console.WriteLine(result);
//}

//XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));

//using (FileStream file = new FileStream("books.xml", FileMode.OpenOrCreate))
//{

//    serializer.Serialize(file, books);
//}

//using (FileStream file = new FileStream("books.xml", FileMode.Open))
//{

//    var result = (List<Book>)serializer.Deserialize(file);
//    foreach (var item in result)
//    {
//        Console.WriteLine(item);
//    }
//}

#endregion

#region JSON Serialization
//using (FileStream file = new FileStream("book.json", FileMode.OpenOrCreate))
//{
//    JsonSerializerOptions options = new JsonSerializerOptions();
//    options.WriteIndented = true;
//    //var json = JsonSerializer.Serialize(book, options);
//    //Console.WriteLine(json);
//    JsonSerializer.Serialize(file, book, options);
//}

//using (FileStream file = new FileStream("book.json", FileMode.Open))
//{
//    var result = JsonSerializer.Deserialize<Book>(file);
//    Console.WriteLine(result);
//}

//using (FileStream file = new FileStream("books.json", FileMode.OpenOrCreate))
//{
//    JsonSerializerOptions options = new JsonSerializerOptions();
//    options.WriteIndented = true;

//    JsonSerializer.Serialize(file, books, options);
//}

//using (FileStream file = new FileStream("books.json", FileMode.Open))
//{
//    var result = JsonSerializer.Deserialize<List<Book>>(file);

//    foreach (var item in result)
//    {
//        Console.WriteLine(item);
//    }
//}



#endregion

