FrontEndDeveloper frontEnd = new FrontEndDeveloper
{
    FirstName = "Aleks",
    LastName = "Fergusson"
};
BackEndDeveloper backEnd = new BackEndDeveloper
{
    FirstName = "Carlo",
    LastName = "Anchelotti"
};
FullStackDeveloper fullStack = new FullStackDeveloper
{
    FirstName = "Gurban",
    LastName = "Gurbanov"
};

BackEndDeveloperAnnouncement(backEnd, new string[] { "C#", "Python", "PhP" });
BackEndDeveloperAnnouncement(fullStack, new string[] { "C#", "C++", "NodeJs" });

FrontEndDeveloperAnnouncement(frontEnd);
FrontEndDeveloperAnnouncement(fullStack);

FullStackDeveloperAnnouncement(fullStack, new string[] { "C#", "Python", "PhP", "C++", "NodeJs" });

void BackEndDeveloperAnnouncement(IBackEndDeveloper developer, string[] languages)
{
    Console.WriteLine($"I am {((Human)developer).FirstName} {((Human)developer).LastName}");
    developer.knowBackEndLanguage(languages);
}

void FrontEndDeveloperAnnouncement(IFrontEndDeveloper developer)
{
    Console.WriteLine($"I am {((Human)developer).FirstName} {((Human)developer).LastName}");
    developer.KnowHTML();
    developer.KnowCSS();
    developer.KnowJS();
}

void FullStackDeveloperAnnouncement(IFullStackDeveloper developer, string[] languages)
{
    Console.WriteLine($"I am {((Human)developer).FirstName} {((Human)developer).LastName}");
    developer.KnowHTML();
    developer.KnowCSS();
    developer.KnowJS();
    developer.knowBackEndLanguage(languages);
}
