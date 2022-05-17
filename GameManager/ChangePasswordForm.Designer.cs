namespace GameManager
{
    partial class ChangePasswordForm
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
            this.OldPasswordBox = new System.Windows.Forms.TextBox();
            this.NewPasswordBox = new System.Windows.Forms.TextBox();
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.RedirectTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // OldPasswordBox
            // 
            this.OldPasswordBox.Location = new System.Drawing.Point(174, 52);
            this.OldPasswordBox.Name = "OldPasswordBox";
            this.OldPasswordBox.Size = new System.Drawing.Size(144, 20);
            this.OldPasswordBox.TabIndex = 0;
            // 
            // NewPasswordBox
            // 
            this.NewPasswordBox.Location = new System.Drawing.Point(174, 78);
            this.NewPasswordBox.Name = "NewPasswordBox";
            this.NewPasswordBox.Size = new System.Drawing.Size(144, 20);
            this.NewPasswordBox.TabIndex = 1;
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OldPasswordLabel.Location = new System.Drawing.Point(83, 53);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(85, 15);
            this.OldPasswordLabel.TabIndex = 2;
            this.OldPasswordLabel.Text = "Old password:";
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewPasswordLabel.Location = new System.Drawing.Point(77, 79);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(91, 15);
            this.NewPasswordLabel.TabIndex = 3;
            this.NewPasswordLabel.Text = "New password:";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(93, 114);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(101, 31);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(200, 114);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(101, 31);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(12, 20);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(35, 13);
            this.Time.TabIndex = 6;
            this.Time.Text = "label1";
            this.Time.Visible = false;
            // 
            // RedirectTimer
            // 
            this.RedirectTimer.Interval = 1000;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 157);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.OldPasswordLabel);
            this.Controls.Add(this.NewPasswordBox);
            this.Controls.Add(this.OldPasswordBox);
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OldPasswordBox;
        private System.Windows.Forms.TextBox NewPasswordBox;
        private System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer RedirectTimer;
    }
}