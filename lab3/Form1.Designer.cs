namespace lab3
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opf = new System.Windows.Forms.OpenFileDialog();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.intellisense = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sortBtn = new System.Windows.Forms.Button();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.namesList = new System.Windows.Forms.ListBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.boldBtn = new System.Windows.Forms.ToolStripButton();
            this.italicBtn = new System.Windows.Forms.ToolStripButton();
            this.underlineBtn = new System.Windows.Forms.ToolStripButton();
            this.textColorBtn = new System.Windows.Forms.ToolStripButton();
            this.backColorText = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // opf
            // 
            this.opf.FileName = "openFileDialog1";
            this.opf.Filter = "Text files |*.txt";
            this.opf.Title = "Wybierz plik tekstowy";
            this.opf.FileOk += new System.ComponentModel.CancelEventHandler(this.opf_FileOk);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox.Location = new System.Drawing.Point(3, 3);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(808, 436);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "";
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_PreviewKeyDown);
            // 
            // intellisense
            // 
            this.intellisense.FormattingEnabled = true;
            this.intellisense.Location = new System.Drawing.Point(207, 96);
            this.intellisense.Name = "intellisense";
            this.intellisense.Size = new System.Drawing.Size(104, 95);
            this.intellisense.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.Controls.Add(this.sortBtn);
            this.splitContainer1.Panel1.Controls.Add(this.addNewBtn);
            this.splitContainer1.Panel1.Controls.Add(this.namesList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.ContextMenuStrip = this.contextMenuStrip;
            this.splitContainer1.Panel2.Controls.Add(this.toolStripContainer1);
            this.splitContainer1.Size = new System.Drawing.Size(1027, 470);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 3;
            this.splitContainer1.TabStop = false;
            // 
            // sortBtn
            // 
            this.sortBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sortBtn.Location = new System.Drawing.Point(117, 439);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 2;
            this.sortBtn.TabStop = false;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // addNewBtn
            // 
            this.addNewBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addNewBtn.Location = new System.Drawing.Point(12, 439);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(75, 23);
            this.addNewBtn.TabIndex = 1;
            this.addNewBtn.TabStop = false;
            this.addNewBtn.Text = "Add New";
            this.addNewBtn.UseVisualStyleBackColor = true;
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // namesList
            // 
            this.namesList.AllowDrop = true;
            this.namesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namesList.FormattingEnabled = true;
            this.namesList.Location = new System.Drawing.Point(0, 0);
            this.namesList.Name = "namesList";
            this.namesList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.namesList.Size = new System.Drawing.Size(203, 433);
            this.namesList.TabIndex = 0;
            this.namesList.TabStop = false;
            this.namesList.DragDrop += new System.Windows.Forms.DragEventHandler(this.namesList_DragDrop);
            this.namesList.DragEnter += new System.Windows.Forms.DragEventHandler(this.namesList_DragEnter);
            this.namesList.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.namesList_PreviewKeyDown);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(100, 26);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.addToolStripMenuItem.Text = "Add ";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.ContextMenuStrip = this.contextMenuStrip;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.intellisense);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBox);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(814, 442);
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Enabled = false;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            this.toolStripContainer1.RightToolStripPanel.Enabled = false;
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(814, 467);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldBtn,
            this.italicBtn,
            this.underlineBtn,
            this.textColorBtn,
            this.backColorText,
            this.toolStripComboBox});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(283, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.DragDrop += new System.Windows.Forms.DragEventHandler(this.toolStrip1_DragDrop);
            this.toolStrip1.DragEnter += new System.Windows.Forms.DragEventHandler(this.toolStrip1_DragEnter);
            this.toolStrip1.DragOver += new System.Windows.Forms.DragEventHandler(this.toolStrip1_DragOver);
            this.toolStrip1.DragLeave += new System.EventHandler(this.toolStrip1_DragLeave);
            // 
            // boldBtn
            // 
            this.boldBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldBtn.Image = global::lab3.Properties.Resources.Bold;
            this.boldBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldBtn.Name = "boldBtn";
            this.boldBtn.Size = new System.Drawing.Size(23, 22);
            this.boldBtn.Text = "Bold";
            this.boldBtn.Click += new System.EventHandler(this.boldBtn_Click);
            // 
            // italicBtn
            // 
            this.italicBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicBtn.Image = global::lab3.Properties.Resources.Italic;
            this.italicBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicBtn.Name = "italicBtn";
            this.italicBtn.Size = new System.Drawing.Size(23, 22);
            this.italicBtn.Text = "Italic";
            this.italicBtn.Click += new System.EventHandler(this.italicBtn_Click);
            // 
            // underlineBtn
            // 
            this.underlineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineBtn.Image = global::lab3.Properties.Resources.Underline;
            this.underlineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineBtn.Name = "underlineBtn";
            this.underlineBtn.Size = new System.Drawing.Size(23, 22);
            this.underlineBtn.Text = "Underline";
            this.underlineBtn.Click += new System.EventHandler(this.underlineBtn_Click);
            // 
            // textColorBtn
            // 
            this.textColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textColorBtn.Image = global::lab3.Properties.Resources.FontColor;
            this.textColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textColorBtn.Name = "textColorBtn";
            this.textColorBtn.Size = new System.Drawing.Size(23, 22);
            this.textColorBtn.Text = "Change text color";
            this.textColorBtn.Click += new System.EventHandler(this.textColorBtn_Click);
            // 
            // backColorText
            // 
            this.backColorText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backColorText.Image = global::lab3.Properties.Resources.BackColor;
            this.backColorText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backColorText.Name = "backColorText";
            this.backColorText.Size = new System.Drawing.Size(23, 22);
            this.backColorText.Text = "Change back color";
            this.backColorText.Click += new System.EventHandler(this.backColorText_Click);
            // 
            // toolStripComboBox
            // 
            this.toolStripComboBox.DropDownHeight = 90;
            this.toolStripComboBox.IntegralHeight = false;
            this.toolStripComboBox.MaxDropDownItems = 5;
            this.toolStripComboBox.Name = "toolStripComboBox";
            this.toolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox.DropDownClosed += new System.EventHandler(this.toolStripComboBox_DropDownClosed);
            // 
            // sfd
            // 
            this.sfd.Filter = "Text file |*.txt";
            this.sfd.FileOk += new System.ComponentModel.CancelEventHandler(this.sfd_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 494);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intellisense";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog opf;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.ListBox intellisense;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox namesList;
        private System.Windows.Forms.Button addNewBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton boldBtn;
        private System.Windows.Forms.ToolStripButton italicBtn;
        private System.Windows.Forms.ToolStripButton underlineBtn;
        private System.Windows.Forms.ToolStripButton textColorBtn;
        private System.Windows.Forms.ToolStripButton backColorText;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox;
    }
}

