using MongoDB.Bson;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shodou
{
    public partial class KanjiMnemonicCard : IRealmObject
    {
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId Id { get; } = ObjectId.GenerateNewId();

        [MapTo("kanji")]
        public string Kanji { get; set; }

        [MapTo("radicals")]
        public string Radicals { get; set; }

        [MapTo("keyword")]
        public string Keyword { get; set; }

        [MapTo("mnemonic")]
        public string Mnemonic { get; set; }

        [MapTo("svg")]
        public string Svg { get; set; }
    }

}
