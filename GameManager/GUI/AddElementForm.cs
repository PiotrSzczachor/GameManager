using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameManager.GUI;
using GameManager.Logic;

namespace GameManager
{
    public partial class AddElementForm : Form
    {
        Users currentlyLoggedUser;
        public AddElementForm(Users user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            ElementsManagerLogic elementsManagerLogic = new ElementsManagerLogic();
            elementsManagerLogic.fillTypesComboBox(TypeComboBox);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ElementsManagerForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddElementLogic addElementLogic = new AddElementLogic();
            CategoryComboBox.Items.Clear();
            addElementLogic.fillCategoriesComboBox(TypeComboBox.SelectedItem.ToString(), CategoryComboBox);
            addElementLogic.fillLabels(label3, label4, label5, label6, label7, TypeComboBox.SelectedItem.ToString());
            CategoryComboBox.Enabled = true;
            List<TextBox> textboxes = new List<TextBox> { FirstAtributeTextBox, SecondAtributeTextBox, ThirdAtributeTextBox, FourthAtributeTextBox, FifthAtributeTextBox };
            foreach (TextBox textbox in textboxes)
            {
                textbox.Enabled = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            AddElementLogic addElementLogic = new AddElementLogic();
            string type = TypeComboBox.SelectedItem.ToString();
            string categoryInfo = CategoryComboBox.SelectedItem.ToString();
            string name = NameTextBox.Text;
            if (type != "" && categoryInfo != "" && name != "" && FirstAtributeTextBox.Text != "" &&
                SecondAtributeTextBox.Text != "" && ThirdAtributeTextBox.Text != "" &&
                FourthAtributeTextBox.Text != " "&& FifthAtributeTextBox.Text != "")
            {
                int atr1 = Int32.Parse(FirstAtributeTextBox.Text);
                int atr2 = Int32.Parse(SecondAtributeTextBox.Text);
                int art3 = Int32.Parse(ThirdAtributeTextBox.Text);
                int art4 = Int32.Parse(FourthAtributeTextBox.Text);
                int art5 = Int32.Parse(FifthAtributeTextBox.Text);
                addElementLogic.addItemToDb(type, name, categoryInfo, atr1, atr2, art3, art4, art5);
            } else
            {
                MessageBox.Show("You need to fill all TextBoxes",
                                "Fill all TextBoxes",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            
        }

        private void FirstAtributeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SecondAtributeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ThirdAtributeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FourthAtributeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FifthAtributeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
