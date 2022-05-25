namespace GameManager.GUI
{
    partial class ElementsManagerForm
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
            this.ElementsListBox = new System.Windows.Forms.ListBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ElementsListBox
            // 
            this.ElementsListBox.FormattingEnabled = true;
            this.ElementsListBox.HorizontalScrollbar = true;
            this.ElementsListBox.Location = new System.Drawing.Point(19, 57);
            this.ElementsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ElementsListBox.Name = "ElementsListBox";
            this.ElementsListBox.Size = new System.Drawing.Size(829, 277);
            this.ElementsListBox.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(200, 345);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(119, 39);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(322, 345);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(119, 39);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(445, 345);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(119, 39);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(568, 345);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(119, 39);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // ElementsManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 395);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ElementsListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ElementsManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElementsManagerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ElementsListBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
    }
}