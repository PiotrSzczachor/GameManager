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
        }
    }
}
