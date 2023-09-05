using Realms;
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

                if (!File.Exists($"{kanjiToken.Codepoint}.txt"))
                {
                    File.WriteAllBytes($"resources/{kanjiToken.Codepoint}.txt", Encoding.UTF8.GetBytes(output.ToString()));
                }
            }
            CompileRealmFile();
        }

        public static void CompileRealmFile()
        {
            Console.WriteLine("Generate Realm Database");
            var config = new RealmConfiguration(Path.Combine(Directory.GetCurrentDirectory(), "kanjicards.realm"));
            Realm realm = Realm.GetInstance(config);

            string filepath = "resources";
            DirectoryInfo d = new DirectoryInfo(filepath);

            foreach (var file in d.GetFiles("*.txt"))
            {
                string[] txtCard = File.ReadAllLines(file.FullName);
                string txtKanji = txtCard[0];
                string txtKeyword = txtCard[1];
                string txtComponents = txtCard[2];
                string txtMnemonic = txtCard[3];

                var kanjiMnemonicCard = new KanjiMnemonicCard
                {
                    Kanji = txtKanji,
                    Radicals = txtComponents,
                    Keyword = txtKeyword,
                    Mnemonic = txtMnemonic,
                    Svg = "0" + txtKanji.Split(":")[1] + ".svg"
                };

                realm.Write(() =>
                {
                    realm.Add(kanjiMnemonicCard);
                });
            }
        }
    }
}