// LINQ Join

List<Group> groups = new() {
new Group() {Id = 1, Name="FBAS_1_23_2_ru", Faculty="Programming"},
new Group() {Id = 2, Name="FBMS_Nov_23_9_ru", Faculty="Programming"},
new Group() {Id = 2, Name="FBES_4215", Faculty="Programming"},
new Group() {Id = 3, Name="FBMS_4217", Faculty="Programming"},
new Group() {Id = 4, Name="FBEN_1226_az", Faculty="Cybersecurity"},
new Group() {Id = 5, Name="FBEN_3211_ru", Faculty="Cybersecurity"},
new Group() {Id = 6, Name="FBEN_1112_ru", Faculty="Design"},
new Group() {Id = 7, Name="FBEN_1211_ru", Faculty="Design"}

};


List<Student> students = new List<Student>
{

   new Student {

        FirstName = "Chancellor",
        LastName = "Andrews",
        Age = 30,
        GroupId = 5
    },
    new Student {

        FirstName = "Oscar",
        LastName = "Hartman",
        Age = 31,
        GroupId = 4
    },
    new Student {

        FirstName = "Griffith",
        LastName = "Holcomb",
        Age = 26,
        GroupId = 5
    },
    new Student {

        FirstName = "Quin",
        LastName = "Sykes",
        Age = 22,
        GroupId = 1
    },
    new Student {

        FirstName = "Quin",
        LastName = "Gentry",
        Age = 34,
        GroupId = 4
    },
    new Student {

        FirstName = "Abdul",
        LastName = "Morin",
        Age = 34,
        GroupId = 5
    },
    new Student {

        FirstName = "Donna",
        LastName = "Moran",
        Age = 33,
        GroupId = 4
    },
    new Student {

        FirstName = "Yetta",
        LastName = "Matthews",
        Age = 24,
        GroupId = 6
    },
    new Student {

        FirstName = "Dorothy",
        LastName = "Andrews",
        Age = 29,
        GroupId = 1
    },
    new Student {

        FirstName = "Curran",
        LastName = "Dotson",
        Age = 33,
        GroupId = 3
    },
    new Student {

        FirstName = "Audra",
        LastName = "Martin",
        Age = 31,
        GroupId = 4
    },
    new Student {

        FirstName = "Hayfa",
        LastName = "Oliver",
        Age = 36,
        GroupId = 3
    },
    new Student {

        FirstName = "Keith",
        LastName = "Bauer",
        Age = 27,
        GroupId = 6
    },
    new Student {

        FirstName = "Dara",
        LastName = "Gentry",
        Age = 30,
        GroupId = 3
    },
    new Student {

        FirstName = "Rose",
        LastName = "Frank",
        Age = 32,
        GroupId = 4
    },
    new Student {

        FirstName = "Carlos",
        LastName = "Suarez",
        Age = 33,
        GroupId = 4
    },
    new Student {

        FirstName = "Libby",
        LastName = "Fisher",
        Age = 33,
        GroupId = 4
    },
    new Student {

        FirstName = "Hammett",
        LastName = "Perry",
        Age = 24,
        GroupId = 5
    },
    new Student {

        FirstName = "Quin",
        LastName = "Pugh",
        Age = 38,
        GroupId = 2
    },
    new Student {

        FirstName = "Vincent",
        LastName = "Levy",
        Age = 27,
        GroupId = 4
    },
    new Student {

        FirstName = "Nina",
        LastName = "Dunn",
        Age = 27,
        GroupId = 7
    },
    new Student {

        FirstName = "Madaline",
        LastName = "Howell",
        Age = 22,
        GroupId = 1
    },
    new Student {

        FirstName = "Jordan",
        LastName = "Chapman",
        Age = 34,
        GroupId = 6
    },
    new Student {

        FirstName = "Cullen",
        LastName = "Kirby",
        Age = 21,
        GroupId = 5
    },
    new Student {

        FirstName = "Simone",
        LastName = "Petty",
        Age = 21,
        GroupId = 3
    },
    new Student {

        FirstName = "Ingrid",
        LastName = "Pugh",
        Age = 35,
        GroupId = 4
    },
    new Student {

        FirstName = "Maisie",
        LastName = "Osborne",
        Age = 32,
        GroupId = 6
    },
    new Student {

        FirstName = "Daria",
        LastName = "Williamson",
        Age = 24,
        GroupId = 2
    },
    new Student {

        FirstName = "Sage",
        LastName = "Schultz",
        Age = 26,
        GroupId = 3
    },
    new Student {

        FirstName = "Denise",
        LastName = "Meyers",
        Age = 27,
        GroupId = 4
    },
    new Student {

        FirstName = "Elton",
        LastName = "Steele",
        Age = 31,
        GroupId = 1
    },
    new Student {

        FirstName = "Ethan",
        LastName = "Carlson",
        Age = 38,
        GroupId = 5
    },
    new Student {

        FirstName = "Amery",
        LastName = "Knight",
        Age = 32,
        GroupId = 2
    },
    new Student {

        FirstName = "Beck",
        LastName = "Baker",
        Age = 29,
        GroupId = 5
    },
    new Student {

        FirstName = "Keely",
        LastName = "Johnson",
        Age = 38,
        GroupId = 5
    },
    new Student {

        FirstName = "Wade",
        LastName = "Stark",
        Age = 26,
        GroupId = 5
    },
    new Student {

        FirstName = "Alana",
        LastName = "Pratt",
        Age = 34,
        GroupId = 5
    },
    new Student {

        FirstName = "Grant",
        LastName = "Randall",
        Age = 21,
        GroupId = 4
    },
    new Student {

        FirstName = "Mollie",
        LastName = "Gomez",
        Age = 29,
        GroupId = 7
    },
    new Student {

        FirstName = "Nola",
        LastName = "Gross",
        Age = 32,
        GroupId = 4
    },
    new Student {

        FirstName = "Nehru",
        LastName = "Rodriquez",
        Age = 28,
        GroupId = 3
    },
    new Student {

        FirstName = "Harding",
        LastName = "Sanford",
        Age = 28,
        GroupId = 2
    },
    new Student {

        FirstName = "Gretchen",
        LastName = "Castro",
        Age = 31,
        GroupId = 1
    },
    new Student {

        FirstName = "Sylvester",
        LastName = "Bonner",
        Age = 21,
        GroupId = 6
    },
    new Student {

        FirstName = "Medge",
        LastName = "Holt",
        Age = 22,
        GroupId = 6
    },
    new Student {

        FirstName = "Darius",
        LastName = "Mcmillan",
        Age = 27,
        GroupId = 4
    },
    new Student {

        FirstName = "Rhona",
        LastName = "Duncan",
        Age = 33,
        GroupId = 5
    },
    new Student {

        FirstName = "Rashad",
        LastName = "Holder",
        Age = 39,
        GroupId = 6
    },
    new Student {

        FirstName = "Alexander",
        LastName = "Adams",
        Age = 27,
        GroupId = 3
    },
    new Student {

        FirstName = "Daquan",
        LastName = "Stephens",
        Age = 24,
        GroupId = 4
    }
};


var result = from g in groups
             join s in students on g.Id equals s.GroupId
             orderby s.FirstName
             select new { Firstname = s.FirstName, LastName = s.LastName, Age = s.Age, GroupName = g.Name };

foreach (var stud in result)
{
    Console.WriteLine($"{stud.Firstname} {stud.LastName} {stud.Age} - {stud.GroupName}");
}
Console.WriteLine(); 
var result2 = from r in result
              group r by r.GroupName;

//foreach (var res in result2)
//{
//    Console.WriteLine(res.Key);
//    foreach (var stud in res)
//    {
//        Console.WriteLine($"    {stud.Firstname} {stud.LastName} {stud.Age} - {stud.GroupName}");
//    }
//}

class Group
{
    public uint Id { get; set; }
    public string? Name { get; set; }
    public string? Faculty { get; set; }

    public override string ToString()
    {
        return $"{Id}. {Name} - {Faculty} ";
    }
}


class Student
{
    public uint Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public byte Age { get; set; }
    public uint GroupId { get; set; }
    static uint count = 1;

    public Student()
    {
        Id = count++;
    }

    public override string ToString()
    {
        return $"{Id}. {FirstName} {LastName} - {Age} - {GroupId} ";
    }
}