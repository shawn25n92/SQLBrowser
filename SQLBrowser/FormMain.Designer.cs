namespace SQLBrowser
{
    partial class FormMain
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
            this.SQLBrowserMainMenu = new System.Windows.Forms.MenuStrip();
            this.MainMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSourcesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchBoxLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SQLBrowserMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SQLBrowserMainMenu
            // 
            this.SQLBrowserMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuItemFile,
            this.MainMenuItemAbout,
            this.MainMenuItemHelp});
            this.SQLBrowserMainMenu.Location = new System.Drawing.Point(0, 0);
            this.SQLBrowserMainMenu.Name = "SQLBrowserMainMenu";
            this.SQLBrowserMainMenu.Size = new System.Drawing.Size(950, 24);
            this.SQLBrowserMainMenu.TabIndex = 0;
            this.SQLBrowserMainMenu.Text = "menuStrip1";
            // 
            // MainMenuItemFile
            // 
            this.MainMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.MainMenuItemFile.Name = "MainMenuItemFile";
            this.MainMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.MainMenuItemFile.Text = "File";
            // 
            // MainMenuItemAbout
            // 
            this.MainMenuItemAbout.Name = "MainMenuItemAbout";
            this.MainMenuItemAbout.Size = new System.Drawing.Size(52, 20);
            this.MainMenuItemAbout.Text = "About";
            // 
            // MainMenuItemHelp
            // 
            this.MainMenuItemHelp.Name = "MainMenuItemHelp";
            this.MainMenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.MainMenuItemHelp.Text = "Help";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataSourcesToolStripMenuItem1});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // dataSourcesToolStripMenuItem1
            // 
            this.dataSourcesToolStripMenuItem1.Name = "dataSourcesToolStripMenuItem1";
            this.dataSourcesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.dataSourcesToolStripMenuItem1.Text = "Data Sources";
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Location = new System.Drawing.Point(134, 27);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(730, 20);
            this.SearchBox.TabIndex = 1;
            // 
            // SearchBoxLabel
            // 
            this.SearchBoxLabel.AutoSize = true;
            this.SearchBoxLabel.Location = new System.Drawing.Point(12, 30);
            this.SearchBoxLabel.Name = "SearchBoxLabel";
            this.SearchBoxLabel.Size = new System.Drawing.Size(90, 13);
            this.SearchBoxLabel.TabIndex = 2;
            this.SearchBoxLabel.Text = "Search Database";
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(870, 27);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(68, 20);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBoxLabel);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SQLBrowserMainMenu);
            this.MainMenuStrip = this.SQLBrowserMainMenu;
            this.Name = "FormMain";
            this.Text = "SQLBrowser";
            this.SQLBrowserMainMenu.ResumeLayout(false);
            this.SQLBrowserMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip SQLBrowserMainMenu;
        private System.Windows.Forms.ToolStripMenuItem MainMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataSourcesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MainMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem MainMenuItemHelp;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchBoxLabel;
        private System.Windows.Forms.Button SearchButton;
    }
}