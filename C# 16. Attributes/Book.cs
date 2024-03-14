[AuthorInfo("Nadir", "Zamanov@itstep.org")]
internal class Book
{
    public int Id { get; set; }
    public string? Name { get; set; }
    [AuthorInfo("Salam", "Salamzade@salam.org")]
    public string? Description { get; set; }
    public string? Author { get; set; }

}
