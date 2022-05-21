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
            this.SuspendLayout();
            // 
            // CategoriesListBox
            // 
            this.CategoriesListBox.FormattingEnabled = true;
            this.CategoriesListBox.ItemHeight = 20;
            this.CategoriesListBox.Location = new System.Drawing.Point(18, 92);
            this.CategoriesListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoriesListBox.Name = "CategoriesListBox";
            this.CategoriesListBox.Size = new System.Drawing.Size(1009, 404);
            this.CategoriesListBox.TabIndex = 0;
            // 
            // AddNewForestButton
            // 
            this.AddNewForestButton.Location = new System.Drawing.Point(18, 508);
            this.AddNewForestButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddNewForestButton.Name = "AddNewForestButton";
            this.AddNewForestButton.Size = new System.Drawing.Size(195, 65);
            this.AddNewForestButton.TabIndex = 1;
            this.AddNewForestButton.Text = "Add new forest";
            this.AddNewForestButton.UseVisualStyleBackColor = true;
            this.AddNewForestButton.Click += new System.EventHandler(this.AddNewForestButton_Click);
            // 
            // AddNewTempleButton
            // 
            this.AddNewTempleButton.Location = new System.Drawing.Point(222, 508);
            this.AddNewTempleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddNewTempleButton.Name = "AddNewTempleButton";
            this.AddNewTempleButton.Size = new System.Drawing.Size(195, 65);
            this.AddNewTempleButton.TabIndex = 2;
            this.AddNewTempleButton.Text = "Add new temple";
            this.AddNewTempleButton.UseVisualStyleBackColor = true;
            // 
            // AddNewCaveButton
            // 
            this.AddNewCaveButton.Location = new System.Drawing.Point(630, 508);
            this.AddNewCaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddNewCaveButton.Name = "AddNewCaveButton";
            this.AddNewCaveButton.Size = new System.Drawing.Size(195, 65);
            this.AddNewCaveButton.TabIndex = 4;
            this.AddNewCaveButton.Text = "Add new cave";
            this.AddNewCaveButton.UseVisualStyleBackColor = true;
            // 
            // AddNewDesertButton
            // 
            this.AddNewDesertButton.Location = new System.Drawing.Point(834, 508);
            this.AddNewDesertButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddNewDesertButton.Name = "AddNewDesertButton";
            this.AddNewDesertButton.Size = new System.Drawing.Size(195, 65);
            this.AddNewDesertButton.TabIndex = 5;
            this.AddNewDesertButton.Text = "Add new desert";
            this.AddNewDesertButton.UseVisualStyleBackColor = true;
            // 
            // AddNewCastleButton
            // 
            this.AddNewCastleButton.Location = new System.Drawing.Point(426, 508);
            this.AddNewCastleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddNewCastleButton.Name = "AddNewCastleButton";
            this.AddNewCastleButton.Size = new System.Drawing.Size(195, 65);
            this.AddNewCastleButton.TabIndex = 6;
            this.AddNewCastleButton.Text = "Add new castle";
            this.AddNewCastleButton.UseVisualStyleBackColor = true;
            // 
            // CategoriesManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 591);
            this.Controls.Add(this.AddNewCastleButton);
            this.Controls.Add(this.AddNewDesertButton);
            this.Controls.Add(this.AddNewCaveButton);
            this.Controls.Add(this.AddNewTempleButton);
            this.Controls.Add(this.AddNewForestButton);
            this.Controls.Add(this.CategoriesListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CategoriesManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriesManagerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CategoriesListBox;
        private System.Windows.Forms.Button AddNewForestButton;
        private System.Windows.Forms.Button AddNewTempleButton;
        private System.Windows.Forms.Button AddNewCaveButton;
        private System.Windows.Forms.Button AddNewDesertButton;
        private System.Windows.Forms.Button AddNewCastleButton;
    }
}