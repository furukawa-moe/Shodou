namespace Shodou.Editor
{
    partial class KanjiItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label = new Label();
            SuspendLayout();
            // 
            // label
            // 
            label.BackColor = Color.Transparent;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Font = new Font("Noto Sans JP", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(0, 0);
            label.Margin = new Padding(0);
            label.Name = "label";
            label.Size = new Size(64, 64);
            label.TabIndex = 4;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.UseMnemonic = false;
            label.Click += label_Click;
            // 
            // KanjiItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label);
            Margin = new Padding(0);
            Name = "KanjiItem";
            Size = new Size(64, 64);
            ResumeLayout(false);
        }

        #endregion

        private Label label;
    }
}
