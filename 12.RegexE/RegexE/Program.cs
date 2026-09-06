using System.Text.RegularExpressions;

namespace RegexE;

class Program
{
    static void Main(string[] args)
    {
        string pattern = @"\d{5}";
        Regex regex = new Regex(pattern);

        string text = "Hi , my number is 12345";

        MatchCollection matchCollection = regex.Matches(text);

        System.Console.WriteLine($"{matchCollection.Count} hits found: \n {text}");

        foreach (Match hit in matchCollection)
        {
            GroupCollection group = hit.Groups;
            System.Console.WriteLine($"{group[0].Value} found at {group[0].Index}");
        }
    }
}
