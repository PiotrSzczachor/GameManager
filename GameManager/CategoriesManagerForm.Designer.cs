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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddNewForestButton = new System.Windows.Forms.Button();
            this.AddNewTempleButton = new System.Windows.Forms.Button();
            this.AddNewCaveButton = new System.Windows.Forms.Button();
            this.AddNewDesertButton = new System.Windows.Forms.Button();
            this.AddNewCastleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(674, 264);
            this.listBox1.TabIndex = 0;
            // 
            // AddNewForestButton
            // 
            this.AddNewForestButton.Location = new System.Drawing.Point(12, 330);
            this.AddNewForestButton.Name = "AddNewForestButton";
            this.AddNewForestButton.Size = new System.Drawing.Size(130, 42);
            this.AddNewForestButton.TabIndex = 1;
            this.AddNewForestButton.Text = "Add new forest";
            this.AddNewForestButton.UseVisualStyleBackColor = true;
            this.AddNewForestButton.Click += new System.EventHandler(this.AddNewForestButton_Click);
            // 
            // AddNewTempleButton
            // 
            this.AddNewTempleButton.Location = new System.Drawing.Point(148, 330);
            this.AddNewTempleButton.Name = "AddNewTempleButton";
            this.AddNewTempleButton.Size = new System.Drawing.Size(130, 42);
            this.AddNewTempleButton.TabIndex = 2;
            this.AddNewTempleButton.Text = "Add new temple";
            this.AddNewTempleButton.UseVisualStyleBackColor = true;
            // 
            // AddNewCaveButton
            // 
            this.AddNewCaveButton.Location = new System.Drawing.Point(420, 330);
            this.AddNewCaveButton.Name = "AddNewCaveButton";
            this.AddNewCaveButton.Size = new System.Drawing.Size(130, 42);
            this.AddNewCaveButton.TabIndex = 4;
            this.AddNewCaveButton.Text = "Add new cave";
            this.AddNewCaveButton.UseVisualStyleBackColor = true;
            // 
            // AddNewDesertButton
            // 
            this.AddNewDesertButton.Location = new System.Drawing.Point(556, 330);
            this.AddNewDesertButton.Name = "AddNewDesertButton";
            this.AddNewDesertButton.Size = new System.Drawing.Size(130, 42);
            this.AddNewDesertButton.TabIndex = 5;
            this.AddNewDesertButton.Text = "Add new desert";
            this.AddNewDesertButton.UseVisualStyleBackColor = true;
            // 
            // AddNewCastleButton
            // 
            this.AddNewCastleButton.Location = new System.Drawing.Point(284, 330);
            this.AddNewCastleButton.Name = "AddNewCastleButton";
            this.AddNewCastleButton.Size = new System.Drawing.Size(130, 42);
            this.AddNewCastleButton.TabIndex = 6;
            this.AddNewCastleButton.Text = "Add new castle";
            this.AddNewCastleButton.UseVisualStyleBackColor = true;
            // 
            // CategoriesManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 384);
            this.Controls.Add(this.AddNewCastleButton);
            this.Controls.Add(this.AddNewDesertButton);
            this.Controls.Add(this.AddNewCaveButton);
            this.Controls.Add(this.AddNewTempleButton);
            this.Controls.Add(this.AddNewForestButton);
            this.Controls.Add(this.listBox1);
            this.Name = "CategoriesManagerForm";
            this.Text = "CategoriesManagerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AddNewForestButton;
        private System.Windows.Forms.Button AddNewTempleButton;
        private System.Windows.Forms.Button AddNewCaveButton;
        private System.Windows.Forms.Button AddNewDesertButton;
        private System.Windows.Forms.Button AddNewCastleButton;
    }
}