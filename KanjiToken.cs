using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shodou
{
    internal class KanjiToken
    {
        public char KanjiChar;
        public string Codepoint;
        public List<string> KanjiComponents;

        public KanjiToken(char kanji, string codepoint, List<string> kanjiComponents)
        {
            this.KanjiChar = kanji;
            this.Codepoint = codepoint;
            this.KanjiComponents = kanjiComponents;
        }
    }
}
