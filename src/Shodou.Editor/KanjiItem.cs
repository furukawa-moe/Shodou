using Shodou.Editor.Properties;
using System.Drawing.Drawing2D;

namespace Shodou.Editor
{
    public partial class KanjiItem : UserControl
    {
        public char Character { get; }
        public string Codepoint { get; }

        public KanjiItem(char kanji, string codepoint, KanjiStatus status)
        {
            InitializeComponent();
            label.Text = kanji.ToString();
            Character = kanji;
            Codepoint = codepoint;
            ApplyKanjiStatus(this, status);
        }

        public void ApplyKanjiStatus(KanjiItem kanji, KanjiStatus status)
        {
            switch (status)
            {
                case KanjiStatus.NoSelfMnemonicNoComponentMnemonic:
                    this.BackgroundImage = Resources._0A;
                    break;
                case KanjiStatus.NoSelfMnemonicSomeComponentMnemonic:
                    this.BackgroundImage = Resources._0B;
                    break;
                case KanjiStatus.NoSelfMnemonicAllComponentMnemonic:
                    this.BackgroundImage = Resources._0C;
                    break;
                case KanjiStatus.SelfMnemonicNoComponentMnemonic:
                    this.BackgroundImage = Resources._1A;
                    break;
                case KanjiStatus.SelfMnemonicSomeComponentMnemonic:
                    this.BackgroundImage = Resources._1B;
                    break;
                case KanjiStatus.SelfMnemonicAllComponentMnemonic:
                    this.BackgroundImage = Resources._1C;
                    break;
            }
        }
        public InterpolationMode InterpolationMode { get; set; }

        protected override void OnPaintBackground(PaintEventArgs paintEventArgs)
        {
            paintEventArgs.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            base.OnPaintBackground(paintEventArgs);
        }

        private void label_Click(object sender, EventArgs e)
        {
            ((EditorForm)ParentForm).ApplyCurrentKanji(Codepoint);
        }

        public enum KanjiStatus
        {
            NoSelfMnemonicNoComponentMnemonic,
            NoSelfMnemonicSomeComponentMnemonic,
            NoSelfMnemonicAllComponentMnemonic,
            SelfMnemonicNoComponentMnemonic,
            SelfMnemonicSomeComponentMnemonic,
            SelfMnemonicAllComponentMnemonic,
            None
        }
    }
}
