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
    public partial class AddOrEditForestOrDesertForm : Form
    {
        Users currentlyLoggedUser;
        bool isForest;
        bool isEdit;
        string instance;
        string initName;
        string initArea;
        public AddOrEditForestOrDesertForm(Users user, bool forest, bool edit, string instance_)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            isForest = forest;
            isEdit = edit;
            instance = instance_;
            if (isEdit)
            {
                EditCategoryLogic editCategoryLogic = new EditCategoryLogic(instance);
                editCategoryLogic.fillForestOrDesertTextBoxes(NameTextBox, AreaTextBox);
                initName = NameTextBox.Text;
                initArea = AreaTextBox.Text;
                CheckingChanges.Enabled = true;
            }
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
            // Adding new object
            if (!isEdit)
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
                } else
                {
                    MessageBox.Show("You need to fill all TextBoxes",
                                        "Fill all TextBox",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                }
            }
            // Editing object
            else
            {
                EditCategoryLogic editCategoryLogic = new EditCategoryLogic(instance);
                if (isForest)
                {
                    editCategoryLogic.editForest(initName, initArea, NameTextBox.Text, AreaTextBox.Text);
                }
                else
                {
                    editCategoryLogic.editDesert(initName, initArea, NameTextBox.Text, AreaTextBox.Text);
                }
            }

        }

        private void CheckingChanges_Tick(object sender, EventArgs e)
        {
            if (NameTextBox.Text == initName && AreaTextBox.Text == initArea && isEdit)
            {
                SaveButton.Enabled = false;
            } else
            {
                SaveButton.Enabled = true;
            }
        }
    }
}
