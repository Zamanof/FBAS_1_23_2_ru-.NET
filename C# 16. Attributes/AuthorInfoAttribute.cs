[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property) ]
internal class AuthorInfoAttribute: Attribute
{
    public string? Name { get; set; } = "Empty";
    public string? Email { get; set; } = "Empty@gmail.com";
    public AuthorInfoAttribute(){}

    public AuthorInfoAttribute(string? name, string? email)
    {
        Name = name;
        Email = email;
    }

    public override string ToString()
    {
        return $"{Name}: {Email}";
    }
}
