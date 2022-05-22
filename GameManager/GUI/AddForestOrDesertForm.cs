using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameManager.Logic;

namespace GameManager
{
    public partial class AddForestOrDesertForm : Form
    {
        Users currentlyLoggedUser;
        bool isForest;
        public AddForestOrDesertForm(Users user, bool forest)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            isForest = forest;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CategoriesManagerForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            AddCategoryLogic addCategoryLogic = new AddCategoryLogic();
            if ( NameTextBox.Text != "" && AreaTextBox.Text != "")
            {
                if (isForest)
                {
                    addCategoryLogic.addForest(NameTextBox.Text, Int32.Parse(AreaTextBox.Text));
                } else
                {
                    addCategoryLogic.addDesert(NameTextBox.Text, Int32.Parse(AreaTextBox.Text));
                }
                MessageBox.Show("Added successfully",
                                    "Added successfully",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

            } else
            {
                MessageBox.Show("You need to fill all TextBoxes",
                                    "Fill all TextBox",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
        }

        private void AreaLabel_Click(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AreaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
