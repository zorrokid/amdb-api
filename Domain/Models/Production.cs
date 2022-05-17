namespace Domain.Models;

public class Production
{
    public string Name { get; }
    public string LanguageCode { get; }

    public Production(string name, string languageCode) =>
        (Name, LanguageCode) = (name, languageCode);
}