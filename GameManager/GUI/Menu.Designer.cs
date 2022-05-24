namespace GameManager
{
    partial class Menu
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
            this.CategoriesButton = new System.Windows.Forms.Button();
            this.ElementsButton = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.AccountInfoButton = new System.Windows.Forms.Button();
            this.LoggedUserLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CategoriesButton
            // 
            this.CategoriesButton.Location = new System.Drawing.Point(117, 82);
            this.CategoriesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoriesButton.Name = "CategoriesButton";
            this.CategoriesButton.Size = new System.Drawing.Size(250, 77);
            this.CategoriesButton.TabIndex = 0;
            this.CategoriesButton.Text = "Categories";
            this.CategoriesButton.UseVisualStyleBackColor = true;
            this.CategoriesButton.Click += new System.EventHandler(this.CategoriesButton_Click);
            // 
            // ElementsButton
            // 
            this.ElementsButton.Location = new System.Drawing.Point(117, 168);
            this.ElementsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ElementsButton.Name = "ElementsButton";
            this.ElementsButton.Size = new System.Drawing.Size(250, 77);
            this.ElementsButton.TabIndex = 1;
            this.ElementsButton.Text = "Elements";
            this.ElementsButton.UseVisualStyleBackColor = true;
            this.ElementsButton.Click += new System.EventHandler(this.ElementsButton_Click);
            // 
            // UsersButton
            // 
            this.UsersButton.Location = new System.Drawing.Point(117, 254);
            this.UsersButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(250, 77);
            this.UsersButton.TabIndex = 2;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(117, 426);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(250, 77);
            this.LogOutButton.TabIndex = 3;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AccountInfoButton
            // 
            this.AccountInfoButton.Location = new System.Drawing.Point(117, 340);
            this.AccountInfoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AccountInfoButton.Name = "AccountInfoButton";
            this.AccountInfoButton.Size = new System.Drawing.Size(250, 77);
            this.AccountInfoButton.TabIndex = 4;
            this.AccountInfoButton.Text = "Account Info";
            this.AccountInfoButton.UseVisualStyleBackColor = true;
            this.AccountInfoButton.Click += new System.EventHandler(this.AccountInfoButton_Click);
            // 
            // LoggedUserLabel
            // 
            this.LoggedUserLabel.AutoSize = true;
            this.LoggedUserLabel.Location = new System.Drawing.Point(112, 32);
            this.LoggedUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoggedUserLabel.Name = "LoggedUserLabel";
            this.LoggedUserLabel.Size = new System.Drawing.Size(51, 20);
            this.LoggedUserLabel.TabIndex = 5;
            this.LoggedUserLabel.Text = "label1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 526);
            this.Controls.Add(this.LoggedUserLabel);
            this.Controls.Add(this.AccountInfoButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.UsersButton);
            this.Controls.Add(this.ElementsButton);
            this.Controls.Add(this.CategoriesButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CategoriesButton;
        private System.Windows.Forms.Button ElementsButton;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button AccountInfoButton;
        private System.Windows.Forms.Label LoggedUserLabel;
    }
}