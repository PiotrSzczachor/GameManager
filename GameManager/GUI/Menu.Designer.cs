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
            this.components = new System.ComponentModel.Container();
            this.CategoriesButton = new System.Windows.Forms.Button();
            this.ElementsButton = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.AccountInfoButton = new System.Windows.Forms.Button();
            this.LoggedUserLabel = new System.Windows.Forms.Label();
            this.RolesButton = new System.Windows.Forms.Button();
            this.PermissionTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CategoriesButton
            // 
            this.CategoriesButton.Location = new System.Drawing.Point(78, 109);
            this.CategoriesButton.Name = "CategoriesButton";
            this.CategoriesButton.Size = new System.Drawing.Size(167, 50);
            this.CategoriesButton.TabIndex = 0;
            this.CategoriesButton.Text = "Categories";
            this.CategoriesButton.UseVisualStyleBackColor = true;
            this.CategoriesButton.Click += new System.EventHandler(this.CategoriesButton_Click);
            // 
            // ElementsButton
            // 
            this.ElementsButton.Location = new System.Drawing.Point(78, 165);
            this.ElementsButton.Name = "ElementsButton";
            this.ElementsButton.Size = new System.Drawing.Size(167, 50);
            this.ElementsButton.TabIndex = 1;
            this.ElementsButton.Text = "Elements";
            this.ElementsButton.UseVisualStyleBackColor = true;
            this.ElementsButton.Click += new System.EventHandler(this.ElementsButton_Click);
            // 
            // UsersButton
            // 
            this.UsersButton.Location = new System.Drawing.Point(78, 221);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(167, 50);
            this.UsersButton.TabIndex = 2;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(78, 333);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(167, 50);
            this.LogOutButton.TabIndex = 3;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AccountInfoButton
            // 
            this.AccountInfoButton.Location = new System.Drawing.Point(78, 277);
            this.AccountInfoButton.Name = "AccountInfoButton";
            this.AccountInfoButton.Size = new System.Drawing.Size(167, 50);
            this.AccountInfoButton.TabIndex = 4;
            this.AccountInfoButton.Text = "Account Info";
            this.AccountInfoButton.UseVisualStyleBackColor = true;
            this.AccountInfoButton.Click += new System.EventHandler(this.AccountInfoButton_Click);
            // 
            // LoggedUserLabel
            // 
            this.LoggedUserLabel.AutoSize = true;
            this.LoggedUserLabel.Location = new System.Drawing.Point(75, 21);
            this.LoggedUserLabel.Name = "LoggedUserLabel";
            this.LoggedUserLabel.Size = new System.Drawing.Size(35, 13);
            this.LoggedUserLabel.TabIndex = 5;
            this.LoggedUserLabel.Text = "label1";
            // 
            // RolesButton
            // 
            this.RolesButton.Location = new System.Drawing.Point(78, 53);
            this.RolesButton.Name = "RolesButton";
            this.RolesButton.Size = new System.Drawing.Size(167, 50);
            this.RolesButton.TabIndex = 6;
            this.RolesButton.Text = "Roles";
            this.RolesButton.UseVisualStyleBackColor = true;
            this.RolesButton.Click += new System.EventHandler(this.RolesButton_Click);
            // 
            // PermissionTimer
            // 
            this.PermissionTimer.Interval = 1;
            this.PermissionTimer.Tick += new System.EventHandler(this.PermissionTimer_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 403);
            this.Controls.Add(this.RolesButton);
            this.Controls.Add(this.LoggedUserLabel);
            this.Controls.Add(this.AccountInfoButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.UsersButton);
            this.Controls.Add(this.ElementsButton);
            this.Controls.Add(this.CategoriesButton);
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
        private System.Windows.Forms.Button RolesButton;
        private System.Windows.Forms.Timer PermissionTimer;
    }
}