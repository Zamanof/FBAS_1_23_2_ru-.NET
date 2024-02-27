Auditory auditory = new();
//foreach (Student student in auditory)
//{
//    Console.WriteLine(student);
//}

auditory.Sort();
//auditory.Sort(new DateComparer());
//auditory.Sort(new LastnameComparer());

foreach (Student student in auditory)
{
    Console.WriteLine(student);
}

//Student student1 = new Student
//{
//    FirstName = "SpongeBob",
//    LastName = "SquarePants",
//    Email = "SpongeBob@SquarePants.ocean",
//    BirthDate = new DateTime(1986, 7, 16),
//    StudentCart = new StudentCart { Series = "SB", Id = 798123 }
//};

//Student? student2 = student1.Clone() as Student;
//Console.WriteLine(student1);
//Console.WriteLine(student2);
//student1.FirstName = "Sponge";
//Console.WriteLine(student1);
//Console.WriteLine(student2);
