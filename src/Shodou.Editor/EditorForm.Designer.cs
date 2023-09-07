namespace Shodou.Editor
{
    partial class EditorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFolderToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            splitter2 = new Splitter();
            statusStrip1 = new StatusStrip();
            movePageLeftBtn = new ToolStripSplitButton();
            movePageRightBtn = new ToolStripSplitButton();
            kanjiPageIndicator = new ToolStripStatusLabel();
            splitter6 = new Splitter();
            currentKanjiMnemonic = new Label();
            splitter5 = new Splitter();
            currentKanjiComponents = new LinkLabel();
            splitter4 = new Splitter();
            currentKanjiKeyword = new Label();
            splitter3 = new Splitter();
            currentKanjiCharacter = new WebBrowser();
            currentKanjiWiktionaryLink = new LinkLabel();
            splitter1 = new Splitter();
            currentKanjiOpenInEditor = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFolderToolStripMenuItem, refreshToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            fileToolStripMenuItem.ForeColor = SystemColors.ControlText;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openFolderToolStripMenuItem
            // 
            openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            openFolderToolStripMenuItem.Size = new Size(139, 22);
            openFolderToolStripMenuItem.Text = "Open Folder";
            openFolderToolStripMenuItem.Click += openFolderToolStripMenuItem_Click;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(139, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(139, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = SystemColors.ControlLight;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            splitContainer1.Panel1.Controls.Add(splitter2);
            splitContainer1.Panel1.Controls.Add(statusStrip1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(splitter6);
            splitContainer1.Panel2.Controls.Add(currentKanjiMnemonic);
            splitContainer1.Panel2.Controls.Add(splitter5);
            splitContainer1.Panel2.Controls.Add(currentKanjiComponents);
            splitContainer1.Panel2.Controls.Add(splitter4);
            splitContainer1.Panel2.Controls.Add(currentKanjiKeyword);
            splitContainer1.Panel2.Controls.Add(splitter3);
            splitContainer1.Panel2.Controls.Add(currentKanjiCharacter);
            splitContainer1.Panel2.Controls.Add(currentKanjiWiktionaryLink);
            splitContainer1.Panel2.Controls.Add(splitter1);
            splitContainer1.Panel2.Controls.Add(currentKanjiOpenInEditor);
            splitContainer1.Size = new Size(800, 426);
            splitContainer1.SplitterDistance = 606;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 2);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(606, 402);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // splitter2
            // 
            splitter2.BackColor = SystemColors.ControlLight;
            splitter2.Dock = DockStyle.Top;
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(606, 2);
            splitter2.TabIndex = 1;
            splitter2.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.Control;
            statusStrip1.Items.AddRange(new ToolStripItem[] { movePageLeftBtn, movePageRightBtn, kanjiPageIndicator });
            statusStrip1.Location = new Point(0, 404);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(606, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // movePageLeftBtn
            // 
            movePageLeftBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            movePageLeftBtn.DropDownButtonWidth = 0;
            movePageLeftBtn.Image = (Image)resources.GetObject("movePageLeftBtn.Image");
            movePageLeftBtn.ImageTransparentColor = Color.Magenta;
            movePageLeftBtn.Name = "movePageLeftBtn";
            movePageLeftBtn.Size = new Size(20, 20);
            movePageLeftBtn.Text = "<";
            movePageLeftBtn.ToolTipText = "Previous Page";
            movePageLeftBtn.ButtonClick += movePageLeftBtn_ButtonClick;
            // 
            // movePageRightBtn
            // 
            movePageRightBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            movePageRightBtn.DropDownButtonWidth = 0;
            movePageRightBtn.Image = (Image)resources.GetObject("movePageRightBtn.Image");
            movePageRightBtn.ImageTransparentColor = Color.Magenta;
            movePageRightBtn.Name = "movePageRightBtn";
            movePageRightBtn.Size = new Size(20, 20);
            movePageRightBtn.Text = ">";
            movePageRightBtn.ToolTipText = "Next Page";
            movePageRightBtn.ButtonClick += movePageRightBtn_ButtonClick;
            // 
            // kanjiPageIndicator
            // 
            kanjiPageIndicator.Name = "kanjiPageIndicator";
            kanjiPageIndicator.Size = new Size(42, 17);
            kanjiPageIndicator.Text = "Page 1";
            // 
            // splitter6
            // 
            splitter6.BackColor = SystemColors.ControlLight;
            splitter6.Dock = DockStyle.Bottom;
            splitter6.Location = new Point(0, 402);
            splitter6.Name = "splitter6";
            splitter6.Size = new Size(191, 2);
            splitter6.TabIndex = 12;
            splitter6.TabStop = false;
            // 
            // currentKanjiMnemonic
            // 
            currentKanjiMnemonic.Dock = DockStyle.Fill;
            currentKanjiMnemonic.Location = new Point(0, 268);
            currentKanjiMnemonic.Name = "currentKanjiMnemonic";
            currentKanjiMnemonic.Size = new Size(191, 136);
            currentKanjiMnemonic.TabIndex = 5;
            // 
            // splitter5
            // 
            splitter5.BackColor = SystemColors.ControlLight;
            splitter5.Dock = DockStyle.Top;
            splitter5.Location = new Point(0, 266);
            splitter5.Name = "splitter5";
            splitter5.Size = new Size(191, 2);
            splitter5.TabIndex = 11;
            splitter5.TabStop = false;
            // 
            // currentKanjiComponents
            // 
            currentKanjiComponents.Dock = DockStyle.Top;
            currentKanjiComponents.Location = new Point(0, 169);
            currentKanjiComponents.Name = "currentKanjiComponents";
            currentKanjiComponents.Size = new Size(191, 97);
            currentKanjiComponents.TabIndex = 4;
            currentKanjiComponents.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // splitter4
            // 
            splitter4.BackColor = SystemColors.ControlLight;
            splitter4.Dock = DockStyle.Top;
            splitter4.Location = new Point(0, 167);
            splitter4.Name = "splitter4";
            splitter4.Size = new Size(191, 2);
            splitter4.TabIndex = 10;
            splitter4.TabStop = false;
            // 
            // currentKanjiKeyword
            // 
            currentKanjiKeyword.Dock = DockStyle.Top;
            currentKanjiKeyword.Location = new Point(0, 144);
            currentKanjiKeyword.Name = "currentKanjiKeyword";
            currentKanjiKeyword.Size = new Size(191, 23);
            currentKanjiKeyword.TabIndex = 3;
            currentKanjiKeyword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // splitter3
            // 
            splitter3.BackColor = SystemColors.ControlLight;
            splitter3.Dock = DockStyle.Top;
            splitter3.Location = new Point(0, 142);
            splitter3.Name = "splitter3";
            splitter3.Size = new Size(191, 2);
            splitter3.TabIndex = 9;
            splitter3.TabStop = false;
            // 
            // currentKanjiCharacter
            // 
            currentKanjiCharacter.AllowWebBrowserDrop = false;
            currentKanjiCharacter.Dock = DockStyle.Top;
            currentKanjiCharacter.IsWebBrowserContextMenuEnabled = false;
            currentKanjiCharacter.Location = new Point(0, 25);
            currentKanjiCharacter.Name = "currentKanjiCharacter";
            currentKanjiCharacter.ScrollBarsEnabled = false;
            currentKanjiCharacter.Size = new Size(191, 117);
            currentKanjiCharacter.TabIndex = 2;
            currentKanjiCharacter.WebBrowserShortcutsEnabled = false;
            // 
            // currentKanjiWiktionaryLink
            // 
            currentKanjiWiktionaryLink.Dock = DockStyle.Top;
            currentKanjiWiktionaryLink.Location = new Point(0, 2);
            currentKanjiWiktionaryLink.Name = "currentKanjiWiktionaryLink";
            currentKanjiWiktionaryLink.Size = new Size(191, 23);
            currentKanjiWiktionaryLink.TabIndex = 7;
            currentKanjiWiktionaryLink.TextAlign = ContentAlignment.MiddleLeft;
            currentKanjiWiktionaryLink.LinkClicked += currentKanjiWiktionaryLink_LinkClicked;
            // 
            // splitter1
            // 
            splitter1.BackColor = SystemColors.ControlLight;
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(191, 2);
            splitter1.TabIndex = 8;
            splitter1.TabStop = false;
            // 
            // currentKanjiOpenInEditor
            // 
            currentKanjiOpenInEditor.Dock = DockStyle.Bottom;
            currentKanjiOpenInEditor.Enabled = false;
            currentKanjiOpenInEditor.Location = new Point(0, 404);
            currentKanjiOpenInEditor.Name = "currentKanjiOpenInEditor";
            currentKanjiOpenInEditor.Size = new Size(191, 22);
            currentKanjiOpenInEditor.TabIndex = 6;
            currentKanjiOpenInEditor.Text = "Open in Editor";
            currentKanjiOpenInEditor.UseVisualStyleBackColor = true;
            currentKanjiOpenInEditor.Click += currentKanjiOpenInEditor_Click;
            // 
            // EditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "EditorForm";
            Text = "Shodou Source View";
            Load += EditorForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private SplitContainer splitContainer1;
        private StatusStrip statusStrip1;
        private Splitter splitter2;
        private FlowLayoutPanel flowLayoutPanel1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label currentKanjiKeyword;
        private WebBrowser currentKanjiCharacter;
        private LinkLabel currentKanjiComponents;
        private Label currentKanjiMnemonic;
        private Button currentKanjiOpenInEditor;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripSplitButton movePageLeftBtn;
        private ToolStripSplitButton movePageRightBtn;
        private ToolStripStatusLabel kanjiPageIndicator;
        private ToolStripMenuItem openFolderToolStripMenuItem;
        private LinkLabel currentKanjiWiktionaryLink;
        private Splitter splitter1;
        private Splitter splitter5;
        private Splitter splitter4;
        private Splitter splitter3;
        private Splitter splitter6;
    }
}