using System.Collections;

internal class LastnameComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        if (x is Student && y is Student)
        {
            return String.Compare((x as Student).LastName, (y as Student).LastName);
        }
        throw new NotImplementedException();
    }
}
