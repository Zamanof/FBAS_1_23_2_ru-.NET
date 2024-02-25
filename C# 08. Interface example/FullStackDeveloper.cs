internal class FullStackDeveloper : Human, IFullStackDeveloper
{
    public void knowBackEndLanguage(string[] languages)
    {
        Console.WriteLine("I know: ");
        foreach (var language in languages)
        {
            Console.WriteLine($"\t- {language}");
        }
    }

    public void KnowCSS()
    {
        Console.WriteLine("I know CSS");
    }

    public void KnowHTML()
    {
        Console.WriteLine("I know HTML");
    }

    public void KnowJS()
    {
        Console.WriteLine("I know JS");
    }
}
