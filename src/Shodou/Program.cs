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

                if (!File.Exists($"resources/{kanjiToken.Codepoint}.txt"))
                {
                    File.WriteAllBytes($"resources/{kanjiToken.Codepoint}.txt", Encoding.UTF8.GetBytes(output.ToString()));
                }
            }
            CompileFlatFile();
        }

        // Created out of boredom
        public static void CompileFlatHtmlFile()
        {
            Console.WriteLine("Generate Flat Database");
            string filepath = "resources";
            DirectoryInfo d = new DirectoryInfo(filepath);

            StringBuilder output = new StringBuilder();

            output.Append("<html><body>");
            foreach (string filename in File.ReadAllLines("topokanji/dependencies/1-to-N.txt"))
            {
                var file = new FileInfo($"resources/{((int)filename[0]).ToString("x")}.txt");
                string[] txtCard = File.ReadAllLines(file.FullName);
                string txtKanji = txtCard[0];
                string txtKeyword = txtCard[1];
                string txtComponents = txtCard[2];
                string txtMnemonic = txtCard[3];
                string txtSvg = File.ReadAllText(@$"kanjivg/kanji/0{txtKanji.Split(":")[1]}.svg");
                txtSvg = txtSvg.Replace("\n", "").Replace("\r", "");

                output.Append($"<div class=\"card\" id=\"{txtKanji.Split(":")[1]}\">\n");
                output.Append("<p class=\"txt-kanji\">" + txtKanji.Split(":")[0] + "</p>\n");
                output.Append("\n" + txtSvg + "\n");
                output.Append("<p class=\"txt-keyword\">" + txtKeyword + "</p>\n");
                output.Append("<p class=\"txt-mnemonic\">" + txtMnemonic + "</p>\n<p>Components: \n");
                foreach (string s in txtComponents.Split("/"))
                {
                    if (s == "") continue;
                    output.Append($"<a class=\"txt-component\" href=\"#{s.Split(":")[1]}\">{s.Split(":")[0]}</a> ");
                }
                output.Append("</p></div>\n<hr>\n");
            }
            output.Append("</body></html>");

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"kanjicards_flat.html"))
            {
                file.WriteLine(output.ToString());
            }
        }

        public static void CompileFlatFile()
        {
            Console.WriteLine("Generate Flat Database");
            string filepath = "resources";
            DirectoryInfo d = new DirectoryInfo(filepath);

            StringBuilder output = new StringBuilder();

            foreach (string filename in File.ReadAllLines("topokanji/dependencies/1-to-N.txt"))
            {
                var file = new FileInfo($"resources/{((int)filename[0]).ToString("x")}.txt");
                string[] txtCard = File.ReadAllLines(file.FullName);
                string txtKanji = txtCard[0];
                string txtKeyword = txtCard[1];
                string txtComponents = txtCard[2];
                string txtMnemonic = txtCard[3];
                string txtSvg = File.ReadAllText(@$"kanjivg/kanji/0{txtKanji.Split(":")[1]}.svg");
                txtSvg = txtSvg.Replace("\n", " ").Replace("\r", " ");
                txtSvg = txtSvg.Replace("  ", " ");
                // this is gonna be GROSS
                // Ommit the full copyright notice in the interest of file size. This should help a little.
                txtSvg = txtSvg.Remove(txtSvg.IndexOf("<!--"), 692);
                txtSvg = txtSvg.Replace(@"-->", "<!--Copyright (C) 2009/2010/2011 Ulrich Apel, Dist. under CC-BY-SA 3.0-->");

                output.Append("[card]\n");
                output.Append("kanji=" + txtKanji.Split(":")[0] + "\n");
                output.Append("keyword=" + txtKeyword + "\n");
                output.Append("mnemonic=" + txtMnemonic + "\n");
                output.Append("components=");
                foreach (string s in txtComponents.Split("/"))
                {
                    if (s == "") continue;
                    output.Append($"{s.Split(":")[0]}");
                }
                output.Append("\nimage=" + txtSvg + "\n\n");
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"kanjicards_flat.txt"))
            {
                file.WriteLine(output.ToString());
            }
        }

        // Probably won't end up doing this - we will import the cards somewhere else where we can write out the svg resources and worry about where we store them over there
        public static void CompileRealmFile()
        {
            if(File.Exists("kanjicards.realm")) File.Delete("kanjicards.realm");

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