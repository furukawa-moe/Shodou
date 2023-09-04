namespace Shodou
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 2)
            {
                Console.WriteLine("Provide a path to Aozora Bunko Kanji Frequency List and latest KanjiVG kanji folder.");
                Environment.Exit(1);
            }

            string[] kanjiDictionary = File.ReadAllLines(args[0]);

            List<KanjiToken> kanjiTokens = new List<KanjiToken>();

            // Fill each Kanji Token with Character and Codepoint
            foreach (string s in kanjiDictionary)
            {
                kanjiTokens.Add(new KanjiToken(s.Split("0x")[0].Trim().Last(), "0" + s.Split("0x")[1], new List<string>()));
            }

            // Search KanjiVG for those codepoints to extract components
            foreach (KanjiToken kanjiToken in kanjiTokens)
            {
                string kanjiVGentry;

                try
                {
                    kanjiVGentry = File.ReadAllText(Path.Combine(args[1], $"{kanjiToken.Codepoint}.svg"));
                }
                catch { continue; }

                int lastIndex = 0;

                while (true)
                {
                    lastIndex = kanjiVGentry.IndexOf("kvg:element=\"", lastIndex + 1);
                    if (lastIndex == -1) break;
                    kanjiToken.KanjiComponents.Add(kanjiVGentry[lastIndex + 13].ToString());
                }

                kanjiToken.KanjiComponents.RemoveAt(0);
            }

            // Search through KanjiTokens and collect radicals
            Dictionary<string, string> kanjiRadicals = new Dictionary<string, string>();

            foreach (KanjiToken kanjiToken in kanjiTokens)
            {
                foreach (var item in kanjiToken.KanjiComponents)
                {
                    if (!kanjiRadicals.ContainsKey(item))
                    {
                        kanjiRadicals.Add(item, "");
                    }
                }
            }

            foreach (KanjiToken kanjiToken in kanjiTokens)
            {
                if (kanjiRadicals.ContainsKey(kanjiToken.KanjiChar.ToString()))
                {
                    if (kanjiToken.KanjiComponents.Count > 0)
                    {
                        kanjiRadicals.Remove(kanjiToken.KanjiChar.ToString());
                    }
                }
            }

            Console.WriteLine($"Complete! Loaded {kanjiTokens.Count} kanji ({kanjiRadicals.Count} radicals)");
        }
    }
}