internal class Student: IComparable, ICloneable
{
    public string? FirstName { get; set; }
    public string? LastName { get; set;}
    public string? Email { get; set; }
    public DateTime BirthDate { get; set; }
    public StudentCart? StudentCart { get; set; }

    public object Clone()
    {
        Student tmp = (Student)this.MemberwiseClone();
        tmp.StudentCart = new StudentCart
        {
            Series = this.StudentCart.Series,
            Id = this.StudentCart.Id
        };
        return tmp;
    }

    public int CompareTo(object? obj)
    {
        if (obj is Student)
        {
            return FirstName.CompareTo((obj as Student).FirstName);
        }

        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $@"
Name:           {FirstName}
Surname:        {LastName}
BirthDate:      {BirthDate.ToShortDateString()}
StudentCart:    {StudentCart}

";

    }
}