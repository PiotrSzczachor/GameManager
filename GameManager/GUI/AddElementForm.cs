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
    }
}
