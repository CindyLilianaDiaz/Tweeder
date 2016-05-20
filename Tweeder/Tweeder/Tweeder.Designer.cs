namespace Tweeder
{
    partial class Tweeder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tweeder));
            this.tweederMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handleLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.numberTweetsTextBox = new System.Windows.Forms.TextBox();
            this.numberTweetsLabel = new System.Windows.Forms.Label();
            this.searchByUserButton = new System.Windows.Forms.Button();
            this.searchByHashtagButton = new System.Windows.Forms.Button();
            this.tweetsListBox = new System.Windows.Forms.ListBox();
            this.tweederMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tweederMenuStrip
            // 
            this.tweederMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.tweederMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.tweederMenuStrip.Name = "tweederMenuStrip";
            this.tweederMenuStrip.Size = new System.Drawing.Size(1012, 24);
            this.tweederMenuStrip.TabIndex = 0;
            this.tweederMenuStrip.Text = "tweederMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // handleLabel
            // 
            this.handleLabel.AutoSize = true;
            this.handleLabel.Location = new System.Drawing.Point(33, 59);
            this.handleLabel.Name = "handleLabel";
            this.handleLabel.Size = new System.Drawing.Size(135, 13);
            this.handleLabel.TabIndex = 1;
            this.handleLabel.Text = "Twitter Handle or HashTag";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(36, 96);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(303, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // numberTweetsTextBox
            // 
            this.numberTweetsTextBox.Location = new System.Drawing.Point(439, 96);
            this.numberTweetsTextBox.Name = "numberTweetsTextBox";
            this.numberTweetsTextBox.Size = new System.Drawing.Size(49, 20);
            this.numberTweetsTextBox.TabIndex = 1;
            // 
            // numberTweetsLabel
            // 
            this.numberTweetsLabel.AutoSize = true;
            this.numberTweetsLabel.Location = new System.Drawing.Point(436, 59);
            this.numberTweetsLabel.Name = "numberTweetsLabel";
            this.numberTweetsLabel.Size = new System.Drawing.Size(52, 13);
            this.numberTweetsLabel.TabIndex = 4;
            this.numberTweetsLabel.Text = "# Tweets";
            // 
            // searchByUserButton
            // 
            this.searchByUserButton.Location = new System.Drawing.Point(584, 93);
            this.searchByUserButton.Name = "searchByUserButton";
            this.searchByUserButton.Size = new System.Drawing.Size(125, 23);
            this.searchByUserButton.TabIndex = 2;
            this.searchByUserButton.Text = "Search By &User";
            this.searchByUserButton.UseVisualStyleBackColor = true;
            this.searchByUserButton.Click += new System.EventHandler(this.searchByUserButton_Click);
            // 
            // searchByHashtagButton
            // 
            this.searchByHashtagButton.Location = new System.Drawing.Point(740, 96);
            this.searchByHashtagButton.Name = "searchByHashtagButton";
            this.searchByHashtagButton.Size = new System.Drawing.Size(125, 23);
            this.searchByHashtagButton.TabIndex = 3;
            this.searchByHashtagButton.Text = "Search By &HashTag";
            this.searchByHashtagButton.UseVisualStyleBackColor = true;
            this.searchByHashtagButton.Click += new System.EventHandler(this.searchByHashtagButton_Click);
            // 
            // tweetsListBox
            // 
            this.tweetsListBox.FormattingEnabled = true;
            this.tweetsListBox.Location = new System.Drawing.Point(36, 182);
            this.tweetsListBox.Name = "tweetsListBox";
            this.tweetsListBox.Size = new System.Drawing.Size(935, 212);
            this.tweetsListBox.TabIndex = 9;
            this.tweetsListBox.TabStop = false;
            // 
            // Tweeder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 440);
            this.Controls.Add(this.tweetsListBox);
            this.Controls.Add(this.searchByHashtagButton);
            this.Controls.Add(this.searchByUserButton);
            this.Controls.Add(this.numberTweetsLabel);
            this.Controls.Add(this.numberTweetsTextBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.handleLabel);
            this.Controls.Add(this.tweederMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.tweederMenuStrip;
            this.MaximizeBox = false;
            this.Name = "Tweeder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tweeder";
            this.Load += new System.EventHandler(this.Tweeder_Load);
            this.tweederMenuStrip.ResumeLayout(false);
            this.tweederMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip tweederMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label handleLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.TextBox numberTweetsTextBox;
        private System.Windows.Forms.Label numberTweetsLabel;
        private System.Windows.Forms.Button searchByUserButton;
        private System.Windows.Forms.Button searchByHashtagButton;
        private System.Windows.Forms.ListBox tweetsListBox;
    }
}

