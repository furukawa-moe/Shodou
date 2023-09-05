using System.Text;
using System.Text.RegularExpressions;

namespace Shodou
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            string[] kanjiDictionary = File.ReadAllLines("topokanji/dependencies/1-to-N.txt");

            List<KanjiToken> kanjiTokens = new List<KanjiToken>();

            // Fill each Kanji Token with Character, Codepoint and Radicals
            foreach (string s in kanjiDictionary)
            {
                kanjiTokens.Add(new KanjiToken(s[0], ((int)s[0]).ToString("x"), new List<char>()));
                string[] splitString = s.Split(" ");
                if (splitString[1] == "0")
                {
                    continue;
                }

                foreach (char component in splitString[1])
                {
                    kanjiTokens.Last().KanjiComponents.Add(component);
                }
            }

            // Search through KanjiTokens and collect radicals
            Dictionary<char, string> kanjiRadicals = new Dictionary<char, string>();

            foreach (KanjiToken kanjiToken in kanjiTokens)
            {
                foreach (char component in kanjiToken.KanjiComponents)
                {
                    if (!kanjiRadicals.ContainsKey(component))
                    {
                        kanjiRadicals.Add(component, ((int)component).ToString("x"));
                    }
                }
            }

            Console.WriteLine($"Complete! Loaded {kanjiTokens.Count} kanji ({kanjiRadicals.Count} radicals)");

            // Let's check out the mnemonic files and see what matches the kanji we found
            // Create it if it doesn't exist already
            Directory.CreateDirectory("resources");
            foreach (KanjiToken kanjiToken in kanjiTokens)
            {
                StringBuilder output = new StringBuilder();
                output.Append(kanjiToken.KanjiChar + $":{kanjiToken.Codepoint}\nmissing keyword\n");
                foreach (char component in kanjiToken.KanjiComponents)
                {
                    if (kanjiRadicals.TryGetValue(component, out string cp))
                    {
                        output.Append("/" + component + ":" + cp);
                    }
                }
                
                output.Append("\nmissing mnemonic\n");

                string kanjiSvgImage = File.ReadAllText($"kanjivg/kanji/0{kanjiToken.Codepoint}.svg");
                kanjiSvgImage = "<svg xmlns=\"" + kanjiSvgImage.Split("<svg xmlns=\"")[1].Replace(System.Environment.NewLine, "").Replace("\t", "");
                output.Append(kanjiSvgImage);

                if (!File.Exists($"{kanjiToken.Codepoint}.txt"))
                {
                    File.WriteAllBytes($"resources/{kanjiToken.Codepoint}.txt", Encoding.UTF8.GetBytes(output.ToString()));
                }
            }
        }
    }
}