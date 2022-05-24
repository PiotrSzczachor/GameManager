namespace GameManager.GUI
{
    partial class AddOrEditTempleOrCastleForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.BuildYearLabel = new System.Windows.Forms.Label();
            this.BuildYearTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(224, 190);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(133, 39);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(74, 190);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(133, 39);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumberLabel.Location = new System.Drawing.Point(12, 90);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(162, 22);
            this.NumberLabel.TabIndex = 9;
            this.NumberLabel.Text = "Chambers number:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLabel.Location = new System.Drawing.Point(12, 46);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(62, 22);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name:";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(197, 90);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(224, 26);
            this.NumberTextBox.TabIndex = 7;
            this.NumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AreaTextBox_KeyPress);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(197, 46);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(224, 26);
            this.NameTextBox.TabIndex = 6;
            // 
            // BuildYearLabel
            // 
            this.BuildYearLabel.AutoSize = true;
            this.BuildYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BuildYearLabel.Location = new System.Drawing.Point(12, 134);
            this.BuildYearLabel.Name = "BuildYearLabel";
            this.BuildYearLabel.Size = new System.Drawing.Size(95, 22);
            this.BuildYearLabel.TabIndex = 13;
            this.BuildYearLabel.Text = "Build year:";
            // 
            // BuildYearTextBox
            // 
            this.BuildYearTextBox.Location = new System.Drawing.Point(197, 133);
            this.BuildYearTextBox.Name = "BuildYearTextBox";
            this.BuildYearTextBox.Size = new System.Drawing.Size(224, 26);
            this.BuildYearTextBox.TabIndex = 12;
            this.BuildYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuildYearTextBox_KeyPress);
            // 
            // AddTempleOrCastleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 243);
            this.Controls.Add(this.BuildYearLabel);
            this.Controls.Add(this.BuildYearTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "AddTempleOrCastleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label BuildYearLabel;
        private System.Windows.Forms.TextBox BuildYearTextBox;
    }
}