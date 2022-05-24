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
    public partial class AddOrEditTempleOrCastleForm : Form
    {
        Users currentlyLoggedUser;
        bool isTemple;
        bool isEdit;
        string instance;
        string initName;
        string initNumber;
        string initBuildYear;
        public AddOrEditTempleOrCastleForm(Users user, bool temple, bool edit, string instance_)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            isTemple = temple;
            isEdit = edit;
            instance = instance_;
            if (isTemple)
            {
                NumberLabel.Text = "Chambers number: ";
            } else
            {
                NumberLabel.Text = "Towers number: ";
            }
            if (isEdit)
            {
                EditCategoryLogic editCategoryLogic = new EditCategoryLogic(instance);
                editCategoryLogic.fillTempleOrCastleTextBoxes(NameTextBox, NumberTextBox, BuildYearTextBox, isTemple);
                initName = NameTextBox.Text;
                initNumber = NumberTextBox.Text;
                initBuildYear = BuildYearTextBox.Text;
                CheckingChanges.Enabled = true;
            }

            
        }

        private void AreaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BuildYearTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            // Adding new category
            if (!isEdit)
            {
                AddCategoryLogic addCategoryLogic = new AddCategoryLogic();
                if (NameTextBox.Text != "" && NumberTextBox.Text != "" && BuildYearTextBox.Text != "")
                {
                    if (isTemple)
                    {
                        addCategoryLogic.addTemple(NameTextBox.Text, Int32.Parse(NumberTextBox.Text), Int32.Parse(BuildYearTextBox.Text));
                    }
                    else
                    {
                        addCategoryLogic.addCastle(NameTextBox.Text, Int32.Parse(NumberTextBox.Text), Int32.Parse(BuildYearTextBox.Text));
                    }
                }
                else
                {
                    MessageBox.Show("You need to fill all TextBoxes",
                                        "Fill all TextBox",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                }
            } else
            // Editing existing category
            {
                EditCategoryLogic editCategoryLogic = new EditCategoryLogic(instance);
                if (!isTemple)
                {
                    editCategoryLogic.editCastle(initName, initNumber, initBuildYear, NameTextBox.Text, NumberTextBox.Text, BuildYearTextBox.Text);
                } else
                {
                    editCategoryLogic.editTemple(initName, initNumber, initBuildYear, NameTextBox.Text, NumberTextBox.Text, BuildYearTextBox.Text);
                }
            }
            
        }

        private void CheckingChanges_Tick(object sender, EventArgs e)
        {
            if (NameTextBox.Text == initName && NumberTextBox.Text == initNumber && BuildYearTextBox.Text == initBuildYear && isEdit)
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
