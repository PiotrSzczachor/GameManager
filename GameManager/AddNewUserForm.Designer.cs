namespace GameManager
{
    partial class AddNewUserForm
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
            this.Time = new System.Windows.Forms.Label();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.RedirectTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(3, 12);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(13, 13);
            this.Time.TabIndex = 19;
            this.Time.Text = "0";
            this.Time.Visible = false;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(209, 118);
            this.AddUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(75, 27);
            this.AddUserButton.TabIndex = 18;
            this.AddUserButton.Text = "Add user";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(131, 118);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 27);
            this.ResetButton.TabIndex = 17;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(52, 118);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 27);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailLabel.Location = new System.Drawing.Point(69, 90);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(46, 15);
            this.EmailLabel.TabIndex = 15;
            this.EmailLabel.Text = "E-mail:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordLabel.Location = new System.Drawing.Point(49, 61);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(64, 15);
            this.PasswordLabel.TabIndex = 14;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UsernameLabel.Location = new System.Drawing.Point(47, 33);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(68, 15);
            this.UsernameLabel.TabIndex = 13;
            this.UsernameLabel.Text = "Username:";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(116, 89);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailBox.MaxLength = 40;
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(173, 20);
            this.EmailBox.TabIndex = 12;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(116, 61);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordBox.MaxLength = 15;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(173, 20);
            this.PasswordBox.TabIndex = 11;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(116, 33);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameBox.MaxLength = 15;
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(173, 20);
            this.UsernameBox.TabIndex = 10;
            // 
            // RedirectTimer
            // 
            this.RedirectTimer.Interval = 1000;
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 159);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Name = "AddNewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Timer RedirectTimer;
    }
}