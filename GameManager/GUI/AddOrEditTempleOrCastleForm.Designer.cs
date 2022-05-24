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
            this.components = new System.ComponentModel.Container();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.BuildYearLabel = new System.Windows.Forms.Label();
            this.BuildYearTextBox = new System.Windows.Forms.TextBox();
            this.CheckingChanges = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(149, 123);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(89, 25);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(49, 123);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(89, 25);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumberLabel.Location = new System.Drawing.Point(8, 58);
            this.NumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(113, 15);
            this.NumberLabel.TabIndex = 9;
            this.NumberLabel.Text = "Chambers number:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLabel.Location = new System.Drawing.Point(8, 30);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 15);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name:";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(131, 58);
            this.NumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(151, 20);
            this.NumberTextBox.TabIndex = 7;
            this.NumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AreaTextBox_KeyPress);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(131, 30);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(151, 20);
            this.NameTextBox.TabIndex = 6;
            // 
            // BuildYearLabel
            // 
            this.BuildYearLabel.AutoSize = true;
            this.BuildYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BuildYearLabel.Location = new System.Drawing.Point(8, 87);
            this.BuildYearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BuildYearLabel.Name = "BuildYearLabel";
            this.BuildYearLabel.Size = new System.Drawing.Size(64, 15);
            this.BuildYearLabel.TabIndex = 13;
            this.BuildYearLabel.Text = "Build year:";
            // 
            // BuildYearTextBox
            // 
            this.BuildYearTextBox.Location = new System.Drawing.Point(131, 86);
            this.BuildYearTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BuildYearTextBox.Name = "BuildYearTextBox";
            this.BuildYearTextBox.Size = new System.Drawing.Size(151, 20);
            this.BuildYearTextBox.TabIndex = 12;
            this.BuildYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuildYearTextBox_KeyPress);
            // 
            // CheckingChanges
            // 
            this.CheckingChanges.Tick += new System.EventHandler(this.CheckingChanges_Tick);
            // 
            // AddOrEditTempleOrCastleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 158);
            this.Controls.Add(this.BuildYearLabel);
            this.Controls.Add(this.BuildYearTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddOrEditTempleOrCastleForm";
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
        private System.Windows.Forms.Timer CheckingChanges;
    }
}