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

namespace GameManager.GUI
{
    public partial class AddOrEditCaveForm : Form
    {
        Users currentlyLoggedUser;
        bool isEdit;
        string instance;
        public AddOrEditCaveForm(Users user, bool edit, string instance_)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            isEdit = edit;
            instance = instance_;
            if (isEdit)
            {
                EditCategoryLogic editCategoryLogic = new EditCategoryLogic(instance);
                editCategoryLogic.fillCaveTextBoxes(NameTextBox, AreaTextBox, DescriptionTextBox);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CategoriesManagerForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            AddCategoryLogic addCategoryLogic = new AddCategoryLogic();
            if (NameTextBox.Text != "" && AreaTextBox.Text != "" && DescriptionTextBox.Text != "")
            {
                addCategoryLogic.addCave(NameTextBox.Text, Int32.Parse(AreaTextBox.Text), DescriptionTextBox.Text);
            }
            else
            {
                MessageBox.Show("You need to fill all TextBoxes",
                                    "Fill all TextBox",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
        }
    }
}
