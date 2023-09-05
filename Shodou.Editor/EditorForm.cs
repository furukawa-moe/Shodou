using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Shodou.Editor
{
    public partial class EditorForm : Form
    {
        public string currentCodepoint = "";
        public int KanjiFileStartOffset = 0;
        public int KanjiFileCount = 250;
        public int KanjiPageNumber = 1;

        public EditorForm(bool darkMode)
        {
            InitializeComponent();
            if(darkMode) { SetWindowDarkMode(); }
            
        }

        public void ApplyCurrentKanji(string codepoint)
        {
            currentCodepoint = codepoint;
            currentKanjiOpenInEditor.Enabled = true;
            string[] importedKanji = File.ReadAllLines(@$"resources\{codepoint}.txt");
            Clipboard.SetText(importedKanji[0].Split(":")[0]);
            currentKanjiKeyword.Text = importedKanji[1];
            currentKanjiComponents.Text = importedKanji[2];
            currentKanjiMnemonic.Text = importedKanji[3];
            currentKanjiCharacter.DocumentText = File.ReadAllText($@"kanjivg\kanji\0{codepoint}.svg");
        }

        public void SetWindowDarkMode()
        {
            UnnecessaryAndStupidNativeHookForDarkModeThatWillBreak.UseImmersiveDarkMode(this.Handle, true);
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ForeColor = Color.White;
            fileToolStripMenuItem.BackColor = Color.Black;
            fileToolStripMenuItem.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(32, 32, 32);
            this.ForeColor = Color.White;
            flowLayoutPanel1.BackColor = this.BackColor;
            flowLayoutPanel1.ForeColor = this.ForeColor;
            currentKanjiKeyword.BackColor = Color.FromArgb(25, 25, 25);
            currentKanjiKeyword.ForeColor = this.ForeColor;
            currentKanjiKeyword.BorderStyle = BorderStyle.None;
            currentKanjiMnemonic.BackColor = Color.FromArgb(25, 25, 25);
            currentKanjiMnemonic.ForeColor = this.ForeColor;
            currentKanjiMnemonic.BorderStyle = BorderStyle.None;
            statusStrip1.BackColor = Color.FromArgb(51, 51, 51);
            statusStrip1.ForeColor = Color.White;
            currentKanjiOpenInEditor.BackColor = Color.FromArgb(25,25,25);
            currentKanjiOpenInEditor.ForeColor = Color.White;
            currentKanjiOpenInEditor.FlatStyle = FlatStyle.Flat;
            currentKanjiOpenInEditor.FlatAppearance.BorderColor = Color.Black;
            currentKanjiComponents.BackColor = Color.FromArgb(25, 25, 25);
            currentKanjiComponents.ForeColor = Color.White;
            currentKanjiComponents.BorderStyle = BorderStyle.None;
            splitContainer1.BackColor = Color.FromArgb(43, 43, 43);
            splitContainer1.ForeColor = Color.White;
            splitter2.BackColor = Color.FromArgb(43, 43, 43);
            splitter3.BackColor = Color.FromArgb(43, 43, 43);
        }

        private void EditorForm_Load(object sender, EventArgs e)
        {
            RefreshKanjiList(KanjiFileStartOffset, KanjiFileCount);
        }

        private void currentKanjiOpenInEditor_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = @$"resources\{currentCodepoint}.txt";
            psi.UseShellExecute = true;
            Process.Start(psi);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void RefreshKanjiList(int startOffset, int count)
        {
            int startOffsetCounter = 0;

            flowLayoutPanel1.Controls.Clear();

            string[] kanjiDictionary = File.ReadAllLines(@"topokanji\dependencies\1-to-N.txt");

            int pageCount = 0;

            // Fill each Kanji Token with Character and Codepoint
            foreach (string s in kanjiDictionary)
            {
                if (startOffsetCounter < startOffset)
                {
                    startOffsetCounter++;
                    continue;
                }
                int itemHasMnemonic = 0;
                int componentsHaveMnemonics = 0;

                KanjiItem item = new KanjiItem(s[0], ((int)s[0]).ToString("x"), KanjiItem.KanjiStatus.None);
                // Open the item and see if it has mnemonics
                string[] importedKanji = File.ReadAllLines(@$"resources\{item.Codepoint}.txt");
                if (importedKanji[1] != "missing keyword" && importedKanji[3] != "missing mnemonic") itemHasMnemonic = 1;
                if (importedKanji[2] == "")
                {
                    componentsHaveMnemonics = 2;
                }
                else
                {
                    int componentWithMnemonicCount = 0;

                    string[] splitComponentsString = importedKanji[2].Split("/");
                    splitComponentsString = splitComponentsString.Skip(1).ToArray();
                    int index = 0;
                    foreach (string component in splitComponentsString)
                    {
                        splitComponentsString[index] = component.Split(":")[1];
                        index++;
                    }
                    foreach (string component in splitComponentsString)
                    {
                        string[] importedComponent = File.ReadAllLines(@$"resources\{component}.txt");
                        if (importedComponent[1] != "missing keyword" && importedComponent[3] != "missing mnemonic") componentWithMnemonicCount++;
                    }

                    if (componentWithMnemonicCount == splitComponentsString.Count())
                    {
                        componentsHaveMnemonics = 2;
                    }
                    else if (componentWithMnemonicCount < splitComponentsString.Count() && componentWithMnemonicCount > 0)
                    {
                        componentsHaveMnemonics = 1;
                    }
                    else
                    {
                        componentsHaveMnemonics = 0;
                    }
                }

                if (itemHasMnemonic == 0 && componentsHaveMnemonics == 0) { item.ApplyKanjiStatus(item, KanjiItem.KanjiStatus.NoSelfMnemonicNoComponentMnemonic); }
                if (itemHasMnemonic == 1 && componentsHaveMnemonics == 0) { item.ApplyKanjiStatus(item, KanjiItem.KanjiStatus.SelfMnemonicNoComponentMnemonic); }
                if (itemHasMnemonic == 0 && componentsHaveMnemonics == 1) { item.ApplyKanjiStatus(item, KanjiItem.KanjiStatus.NoSelfMnemonicSomeComponentMnemonic); }
                if (itemHasMnemonic == 1 && componentsHaveMnemonics == 1) { item.ApplyKanjiStatus(item, KanjiItem.KanjiStatus.SelfMnemonicSomeComponentMnemonic); }
                if (itemHasMnemonic == 0 && componentsHaveMnemonics == 2) { item.ApplyKanjiStatus(item, KanjiItem.KanjiStatus.NoSelfMnemonicAllComponentMnemonic); }
                if (itemHasMnemonic == 1 && componentsHaveMnemonics == 2) { item.ApplyKanjiStatus(item, KanjiItem.KanjiStatus.SelfMnemonicAllComponentMnemonic); }

                flowLayoutPanel1.Controls.Add(item);
                pageCount++;
                if (pageCount == KanjiFileCount) break;
            }

            if (!String.IsNullOrEmpty(currentCodepoint))
            {
                ApplyCurrentKanji(currentCodepoint);
            }
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshKanjiList(KanjiFileStartOffset, KanjiFileCount);
        }

        private void movePageLeftBtn_ButtonClick(object sender, EventArgs e)
        {
            if (KanjiFileStartOffset >= 250)
            {
                KanjiFileStartOffset -= 250;
                KanjiPageNumber--;
                kanjiPageIndicator.Text = $"Page {KanjiPageNumber}";
                RefreshKanjiList(KanjiFileStartOffset, KanjiFileCount);
            }
        }

        private void movePageRightBtn_ButtonClick(object sender, EventArgs e)
        {
            if (KanjiFileStartOffset <= 7500 && KanjiPageNumber < 10)
            {
                KanjiFileStartOffset += 250;
                KanjiPageNumber++;
                kanjiPageIndicator.Text = $"Page {KanjiPageNumber}";
                RefreshKanjiList(KanjiFileStartOffset, KanjiFileCount);
            }
        }
    }
}