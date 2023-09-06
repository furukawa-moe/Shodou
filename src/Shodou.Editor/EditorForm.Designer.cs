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
            refreshToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            splitter2 = new Splitter();
            statusStrip1 = new StatusStrip();
            movePageLeftBtn = new ToolStripSplitButton();
            movePageRightBtn = new ToolStripSplitButton();
            kanjiPageIndicator = new ToolStripStatusLabel();
            currentKanjiOpenInEditor = new Button();
            currentKanjiMnemonic = new Label();
            currentKanjiComponents = new Label();
            currentKanjiKeyword = new Label();
            currentKanjiCharacter = new WebBrowser();
            splitter3 = new Splitter();
            openFolderToolStripMenuItem = new ToolStripMenuItem();
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
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(180, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
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
            splitContainer1.Panel2.Controls.Add(currentKanjiOpenInEditor);
            splitContainer1.Panel2.Controls.Add(currentKanjiMnemonic);
            splitContainer1.Panel2.Controls.Add(currentKanjiComponents);
            splitContainer1.Panel2.Controls.Add(currentKanjiKeyword);
            splitContainer1.Panel2.Controls.Add(currentKanjiCharacter);
            splitContainer1.Panel2.Controls.Add(splitter3);
            splitContainer1.Size = new Size(800, 426);
            splitContainer1.SplitterDistance = 584;
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
            flowLayoutPanel1.Size = new Size(584, 402);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // splitter2
            // 
            splitter2.BackColor = SystemColors.ControlLight;
            splitter2.Dock = DockStyle.Top;
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(584, 2);
            splitter2.TabIndex = 1;
            splitter2.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.Control;
            statusStrip1.Items.AddRange(new ToolStripItem[] { movePageLeftBtn, movePageRightBtn, kanjiPageIndicator });
            statusStrip1.Location = new Point(0, 404);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(584, 22);
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
            // currentKanjiOpenInEditor
            // 
            currentKanjiOpenInEditor.Dock = DockStyle.Bottom;
            currentKanjiOpenInEditor.Enabled = false;
            currentKanjiOpenInEditor.Location = new Point(0, 403);
            currentKanjiOpenInEditor.Name = "currentKanjiOpenInEditor";
            currentKanjiOpenInEditor.Size = new Size(213, 23);
            currentKanjiOpenInEditor.TabIndex = 6;
            currentKanjiOpenInEditor.Text = "Open in Editor";
            currentKanjiOpenInEditor.UseVisualStyleBackColor = true;
            currentKanjiOpenInEditor.Click += currentKanjiOpenInEditor_Click;
            // 
            // currentKanjiMnemonic
            // 
            currentKanjiMnemonic.BorderStyle = BorderStyle.Fixed3D;
            currentKanjiMnemonic.Dock = DockStyle.Fill;
            currentKanjiMnemonic.Location = new Point(0, 243);
            currentKanjiMnemonic.Name = "currentKanjiMnemonic";
            currentKanjiMnemonic.Size = new Size(213, 183);
            currentKanjiMnemonic.TabIndex = 5;
            currentKanjiMnemonic.Text = "(none)";
            currentKanjiMnemonic.TextAlign = ContentAlignment.TopCenter;
            // 
            // currentKanjiComponents
            // 
            currentKanjiComponents.BorderStyle = BorderStyle.Fixed3D;
            currentKanjiComponents.Dock = DockStyle.Top;
            currentKanjiComponents.Location = new Point(0, 164);
            currentKanjiComponents.Name = "currentKanjiComponents";
            currentKanjiComponents.Size = new Size(213, 79);
            currentKanjiComponents.TabIndex = 4;
            currentKanjiComponents.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // currentKanjiKeyword
            // 
            currentKanjiKeyword.BorderStyle = BorderStyle.Fixed3D;
            currentKanjiKeyword.Dock = DockStyle.Top;
            currentKanjiKeyword.Location = new Point(0, 141);
            currentKanjiKeyword.Name = "currentKanjiKeyword";
            currentKanjiKeyword.Size = new Size(213, 23);
            currentKanjiKeyword.TabIndex = 3;
            currentKanjiKeyword.Text = "(none)";
            currentKanjiKeyword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // currentKanjiCharacter
            // 
            currentKanjiCharacter.AllowWebBrowserDrop = false;
            currentKanjiCharacter.Dock = DockStyle.Top;
            currentKanjiCharacter.IsWebBrowserContextMenuEnabled = false;
            currentKanjiCharacter.Location = new Point(0, 2);
            currentKanjiCharacter.Name = "currentKanjiCharacter";
            currentKanjiCharacter.ScrollBarsEnabled = false;
            currentKanjiCharacter.Size = new Size(213, 139);
            currentKanjiCharacter.TabIndex = 2;
            currentKanjiCharacter.WebBrowserShortcutsEnabled = false;
            // 
            // splitter3
            // 
            splitter3.BackColor = SystemColors.ControlLight;
            splitter3.Dock = DockStyle.Top;
            splitter3.Location = new Point(0, 0);
            splitter3.Name = "splitter3";
            splitter3.Size = new Size(213, 2);
            splitter3.TabIndex = 1;
            splitter3.TabStop = false;
            // 
            // openFolderToolStripMenuItem
            // 
            openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            openFolderToolStripMenuItem.Size = new Size(180, 22);
            openFolderToolStripMenuItem.Text = "Open Folder";
            openFolderToolStripMenuItem.Click += openFolderToolStripMenuItem_Click;
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
        private Splitter splitter3;
        private FlowLayoutPanel flowLayoutPanel1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label currentKanjiKeyword;
        private WebBrowser currentKanjiCharacter;
        private Label currentKanjiComponents;
        private Label currentKanjiMnemonic;
        private Button currentKanjiOpenInEditor;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripSplitButton movePageLeftBtn;
        private ToolStripSplitButton movePageRightBtn;
        private ToolStripStatusLabel kanjiPageIndicator;
        private ToolStripMenuItem openFolderToolStripMenuItem;
    }
}