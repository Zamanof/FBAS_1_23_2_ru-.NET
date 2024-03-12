#region DirectoryInfo
//DirectoryInfo directory = new DirectoryInfo(".");
//Console.WriteLine(directory.FullName);
//Console.WriteLine(directory.CreationTime);
//FileInfo[] files = directory.GetFiles();
//foreach (FileInfo file in files)
//{
//    Console.WriteLine(file.FullName);
//}

//DirectoryInfo directory1 = new DirectoryInfo(@"C:\FBAS_1_23_2_ru");
//if (!directory1.Exists)
//{
//    directory1.Create();
//}

//DirectoryInfo directory2 = directory1.CreateSubdirectory("C#");
#endregion
string path = @"D:\FBAS_1_23_2_ru";
if (Directory.Exists(path))
{
    Console.WriteLine(Directory.GetCreationTime(path));
    //foreach (var item in Directory.GetLogicalDrives())
    //{
    //    Console.WriteLine($"\t{item}");
    //}

    foreach (var item in Directory.GetDirectories(path))
    {
        Console.WriteLine($"\t{item}");
    }
    Directory.Delete(path, true);
}
else
{
    Console.WriteLine("Directory not found");
    Directory.CreateDirectory(path);
}