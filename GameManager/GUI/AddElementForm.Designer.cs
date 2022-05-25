namespace GameManager
{
    partial class AddElementForm
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
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.FirstAtributeTextBox = new System.Windows.Forms.TextBox();
            this.SecondAtributeTextBox = new System.Windows.Forms.TextBox();
            this.ThirdAtributeTextBox = new System.Windows.Forms.TextBox();
            this.FourthAtributeTextBox = new System.Windows.Forms.TextBox();
            this.FifthAtributeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(95, 20);
            this.TypeComboBox.MaxDropDownItems = 20;
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(599, 21);
            this.TypeComboBox.TabIndex = 0;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.Enabled = false;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(95, 47);
            this.CategoryComboBox.MaxDropDownItems = 20;
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(599, 21);
            this.CategoryComboBox.TabIndex = 1;
            // 
            // FirstAtributeTextBox
            // 
            this.FirstAtributeTextBox.Enabled = false;
            this.FirstAtributeTextBox.Location = new System.Drawing.Point(95, 74);
            this.FirstAtributeTextBox.Name = "FirstAtributeTextBox";
            this.FirstAtributeTextBox.Size = new System.Drawing.Size(121, 20);
            this.FirstAtributeTextBox.TabIndex = 2;
            // 
            // SecondAtributeTextBox
            // 
            this.SecondAtributeTextBox.Enabled = false;
            this.SecondAtributeTextBox.Location = new System.Drawing.Point(95, 100);
            this.SecondAtributeTextBox.Name = "SecondAtributeTextBox";
            this.SecondAtributeTextBox.Size = new System.Drawing.Size(121, 20);
            this.SecondAtributeTextBox.TabIndex = 3;
            // 
            // ThirdAtributeTextBox
            // 
            this.ThirdAtributeTextBox.Enabled = false;
            this.ThirdAtributeTextBox.Location = new System.Drawing.Point(95, 126);
            this.ThirdAtributeTextBox.Name = "ThirdAtributeTextBox";
            this.ThirdAtributeTextBox.Size = new System.Drawing.Size(121, 20);
            this.ThirdAtributeTextBox.TabIndex = 4;
            // 
            // FourthAtributeTextBox
            // 
            this.FourthAtributeTextBox.Enabled = false;
            this.FourthAtributeTextBox.Location = new System.Drawing.Point(95, 152);
            this.FourthAtributeTextBox.Name = "FourthAtributeTextBox";
            this.FourthAtributeTextBox.Size = new System.Drawing.Size(121, 20);
            this.FourthAtributeTextBox.TabIndex = 5;
            // 
            // FifthAtributeTextBox
            // 
            this.FifthAtributeTextBox.Enabled = false;
            this.FifthAtributeTextBox.Location = new System.Drawing.Point(95, 178);
            this.FifthAtributeTextBox.Name = "FifthAtributeTextBox";
            this.FifthAtributeTextBox.Size = new System.Drawing.Size(121, 20);
            this.FifthAtributeTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(254, 240);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(93, 36);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(362, 240);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(93, 36);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // AddElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 288);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FifthAtributeTextBox);
            this.Controls.Add(this.FourthAtributeTextBox);
            this.Controls.Add(this.ThirdAtributeTextBox);
            this.Controls.Add(this.SecondAtributeTextBox);
            this.Controls.Add(this.FirstAtributeTextBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.TypeComboBox);
            this.Name = "AddElementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddingElementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox FirstAtributeTextBox;
        private System.Windows.Forms.TextBox SecondAtributeTextBox;
        private System.Windows.Forms.TextBox ThirdAtributeTextBox;
        private System.Windows.Forms.TextBox FourthAtributeTextBox;
        private System.Windows.Forms.TextBox FifthAtributeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
    }
}