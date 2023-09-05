using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Shodou.Editor
{
    public partial class EditorForm : Form
    {
        public string currentCodepoint = "";
        public EditorForm()
        {
            InitializeComponent();
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

        private void EditorForm_Load(object sender, EventArgs e)
        {
            string[] kanjiDictionary = File.ReadAllLines(@"topokanji\dependencies\1-to-N.txt");

            int pageCount = 0;

            // Fill each Kanji Token with Character and Codepoint
            foreach (string s in kanjiDictionary)
            {
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
                if (pageCount == 250) break;
            }
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

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            EditorForm_Load(this, EventArgs.Empty);
        }
    }
}