namespace GameManager
{
    partial class CategoriesManagerForm
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
            this.CategoriesListBox = new System.Windows.Forms.ListBox();
            this.AddNewForestButton = new System.Windows.Forms.Button();
            this.AddNewTempleButton = new System.Windows.Forms.Button();
            this.AddNewCaveButton = new System.Windows.Forms.Button();
            this.AddNewDesertButton = new System.Windows.Forms.Button();
            this.AddNewCastleButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filterByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cavesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.desertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetFiltersButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoriesListBox
            // 
            this.CategoriesListBox.FormattingEnabled = true;
            this.CategoriesListBox.Location = new System.Drawing.Point(12, 95);
            this.CategoriesListBox.Name = "CategoriesListBox";
            this.CategoriesListBox.Size = new System.Drawing.Size(674, 264);
            this.CategoriesListBox.TabIndex = 0;
            this.CategoriesListBox.SelectedIndexChanged += new System.EventHandler(this.CategoriesListBox_SelectedIndexChanged);
            // 
            // AddNewForestButton
            // 
            this.AddNewForestButton.Location = new System.Drawing.Point(12, 365);
            this.AddNewForestButton.Name = "AddNewForestButton";
            this.AddNewForestButton.Size = new System.Drawing.Size(130, 42);
            this.AddNewForestButton.TabIndex = 1;
            this.AddNewForestButton.Text = "Add new forest";
            this.AddNewForestButton.UseVisualStyleBackColor = true;
            this.AddNewForestButton.Click += new System.EventHandler(this.AddNewForestButton_Click);
            // 
            // AddNewTempleButton
            // 
            this.AddNewTempleButton.Location = new System.Drawing.Point(148, 365);
            this.AddNewTempleButton.Name = "AddNewTempleButton";
            this.AddNewTempleButton.Size = new System.Drawing.Size(130, 42);
            this.AddNewTempleButton.TabIndex = 2;
            this.AddNewTempleButton.Text = "Add new temple";
            this.AddNewTempleButton.UseVisualStyleBackColor = true;
            this.AddNewTempleButton.Click += new System.EventHandler(this.AddNewTempleButton_Click);
            // 
            // AddNewCaveButton
            // 
            this.AddNewCaveButton.Location = new System.Drawing.Point(420, 365);
            this.AddNewCaveButton.Name = "AddNewCaveButton";
            this.AddNewCaveButton.Size = new System.Drawing.Size(130, 42);
            this.AddNewCaveButton.TabIndex = 4;
            this.AddNewCaveButton.Text = "Add new cave";
            this.AddNewCaveButton.UseVisualStyleBackColor = true;
            this.AddNewCaveButton.Click += new System.EventHandler(this.AddNewCaveButton_Click);
            // 
            // AddNewDesertButton
            // 
            this.AddNewDesertButton.Location = new System.Drawing.Point(556, 365);
            this.AddNewDesertButton.Name = "AddNewDesertButton";
            this.AddNewDesertButton.Size = new System.Drawing.Size(130, 42);
            this.AddNewDesertButton.TabIndex = 5;
            this.AddNewDesertButton.Text = "Add new desert";
            this.AddNewDesertButton.UseVisualStyleBackColor = true;
            this.AddNewDesertButton.Click += new System.EventHandler(this.AddNewDesertButton_Click);
            // 
            // AddNewCastleButton
            // 
            this.AddNewCastleButton.Location = new System.Drawing.Point(284, 365);
            this.AddNewCastleButton.Name = "AddNewCastleButton";
            this.AddNewCastleButton.Size = new System.Drawing.Size(130, 42);
            this.AddNewCastleButton.TabIndex = 6;
            this.AddNewCastleButton.Text = "Add new castle";
            this.AddNewCastleButton.UseVisualStyleBackColor = true;
            this.AddNewCastleButton.Click += new System.EventHandler(this.AddNewCastleButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(148, 51);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(130, 34);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(284, 51);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(130, 34);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(420, 51);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(130, 34);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterByToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filterByToolStripMenuItem
            // 
            this.filterByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forestsToolStripMenuItem,
            this.templesToolStripMenuItem,
            this.cavesToolStripMenuItem,
            this.cavesToolStripMenuItem1,
            this.desertsToolStripMenuItem});
            this.filterByToolStripMenuItem.Name = "filterByToolStripMenuItem";
            this.filterByToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.filterByToolStripMenuItem.Text = "Filter by";
            // 
            // forestsToolStripMenuItem
            // 
            this.forestsToolStripMenuItem.Name = "forestsToolStripMenuItem";
            this.forestsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.forestsToolStripMenuItem.Text = "Forests";
            this.forestsToolStripMenuItem.Click += new System.EventHandler(this.forestsToolStripMenuItem_Click);
            // 
            // templesToolStripMenuItem
            // 
            this.templesToolStripMenuItem.Name = "templesToolStripMenuItem";
            this.templesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.templesToolStripMenuItem.Text = "Temples";
            this.templesToolStripMenuItem.Click += new System.EventHandler(this.templesToolStripMenuItem_Click);
            // 
            // cavesToolStripMenuItem
            // 
            this.cavesToolStripMenuItem.Name = "cavesToolStripMenuItem";
            this.cavesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cavesToolStripMenuItem.Text = "Castles";
            this.cavesToolStripMenuItem.Click += new System.EventHandler(this.cavesToolStripMenuItem_Click);
            // 
            // cavesToolStripMenuItem1
            // 
            this.cavesToolStripMenuItem1.Name = "cavesToolStripMenuItem1";
            this.cavesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cavesToolStripMenuItem1.Text = "Caves";
            this.cavesToolStripMenuItem1.Click += new System.EventHandler(this.cavesToolStripMenuItem1_Click);
            // 
            // desertsToolStripMenuItem
            // 
            this.desertsToolStripMenuItem.Name = "desertsToolStripMenuItem";
            this.desertsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desertsToolStripMenuItem.Text = "Deserts";
            this.desertsToolStripMenuItem.Click += new System.EventHandler(this.desertsToolStripMenuItem_Click);
            // 
            // ResetFiltersButton
            // 
            this.ResetFiltersButton.Location = new System.Drawing.Point(555, 51);
            this.ResetFiltersButton.Name = "ResetFiltersButton";
            this.ResetFiltersButton.Size = new System.Drawing.Size(130, 34);
            this.ResetFiltersButton.TabIndex = 11;
            this.ResetFiltersButton.Text = "Reset filters";
            this.ResetFiltersButton.UseVisualStyleBackColor = true;
            this.ResetFiltersButton.Click += new System.EventHandler(this.ResetFiltersButton_Click);
            // 
            // CategoriesManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 427);
            this.Controls.Add(this.ResetFiltersButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddNewCastleButton);
            this.Controls.Add(this.AddNewDesertButton);
            this.Controls.Add(this.AddNewCaveButton);
            this.Controls.Add(this.AddNewTempleButton);
            this.Controls.Add(this.AddNewForestButton);
            this.Controls.Add(this.CategoriesListBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CategoriesManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriesManagerForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CategoriesListBox;
        private System.Windows.Forms.Button AddNewForestButton;
        private System.Windows.Forms.Button AddNewTempleButton;
        private System.Windows.Forms.Button AddNewCaveButton;
        private System.Windows.Forms.Button AddNewDesertButton;
        private System.Windows.Forms.Button AddNewCastleButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filterByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cavesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem desertsToolStripMenuItem;
        private System.Windows.Forms.Button ResetFiltersButton;
    }
}