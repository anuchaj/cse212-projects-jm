public class Translator
{
    public static void Run()
    {
        var englishToGerman = new Translator();
        englishToGerman.AddWord("House", "Haus");
        englishToGerman.AddWord("Car", "Auto");
        englishToGerman.AddWord("Plane", "Flugzeug");

        Console.WriteLine(englishToGerman.Translate("Car"));   // Auto
        Console.WriteLine(englishToGerman.Translate("Plane")); // Flugzeug
        Console.WriteLine(englishToGerman.Translate("Train")); // ???
    }

    private Dictionary<string, string> _words = new();

    /// <summary>
    /// Add the translation from 'from_word' to 'to_word'
    /// </summary>
    public void AddWord(string fromWord, string toWord)
    {
        // Add the word and its translation to the dictionary
        _words[fromWord] = toWord;
    }

    /// <summary>
    /// Translates the from word into the word that this stores as the translation
    /// </summary>
    public string Translate(string fromWord)
    {
        // Check if the word exists in the dictionary
        if (_words.ContainsKey(fromWord))
        {
            return _words[fromWord];
        }

        // Return ??? if no translation exists
        return "???";
    }
}