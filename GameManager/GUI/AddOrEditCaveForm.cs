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
        string initName;
        string initArea;
        string initDescription;
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
                initName = NameTextBox.Text;
                initArea = AreaTextBox.Text;
                initDescription = DescriptionTextBox.Text;
                CheckingChanges.Enabled = true;
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
            // New instance
            if (!isEdit)
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
            // Editing instance
            else
            {
                EditCategoryLogic editCategoryLogic = new EditCategoryLogic(instance);
                editCategoryLogic.editCave(initName, initArea, initDescription, NameTextBox.Text, AreaTextBox.Text, DescriptionTextBox.Text);
            }
 
        }

        private void CheckingChanges_Tick(object sender, EventArgs e)
        {
            if (NameTextBox.Text == initName && AreaTextBox.Text == initArea && DescriptionTextBox.Text == initDescription && isEdit)
            {
                SaveButton.Enabled = false;
            }
            else
            {
                SaveButton.Enabled = true;
            }
        }
    }
}
