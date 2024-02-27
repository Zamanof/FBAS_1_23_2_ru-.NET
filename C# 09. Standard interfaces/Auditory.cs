using System.Collections;

internal class Auditory: IEnumerable
{
    Student[] students =
    {
        new Student
        {
            FirstName = "Napoleon",
            LastName = "Bonoparte",
            Email = "Napoleon01@empire.fr",
            BirthDate = new DateTime(1769, 8, 15),
            StudentCart = new StudentCart {Series = "AA", Id = 136487}
        },
        new Student
        {
            FirstName = "Gaius Iulius",
            LastName = "Caesar",
            Email = "GaCaes@empire.rm",
            BirthDate = new DateTime(100, 7, 12),
            StudentCart = new StudentCart {Series = "GS", Id = 484561}
        },
        new Student
        {
            FirstName = "SpongeBob",
            LastName = "SquarePants",
            Email = "SpongeBob@SquarePants.ocean",
            BirthDate = new DateTime(1986, 7, 16),
            StudentCart = new StudentCart {Series = "SB", Id = 798123}
        },
        new Student
        {
            FirstName = "Nadir",
            LastName = "Zamanov",
            Email = "Zamanov@itstep.org",
            BirthDate = new DateTime(1980, 10, 7),
            StudentCart = new StudentCart {Series = "ST", Id = 123321}
        }
    };

    public IEnumerator GetEnumerator()
    {
        return students.GetEnumerator();
    }

    public void Sort()
    {
        Array.Sort(students);
    }
    public void Sort(IComparer comparer)
    {
        Array.Sort(students, comparer);
    }
}
