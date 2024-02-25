internal class BackEndDeveloper : Human, IBackEndDeveloper
{
    public void knowBackEndLanguage(string[] languages)
    {
        Console.WriteLine("I know: ");
        foreach (var language in languages)
        {
            Console.WriteLine($"\t- {language}");
        }
    }
}
