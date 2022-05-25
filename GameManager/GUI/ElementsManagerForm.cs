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
    public partial class ElementsManagerForm : Form
    {
        Users currentlyLoggedUser;
        List<String> chosen = new List<String>();
        public ElementsManagerForm(Users user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            EditButton.Enabled = false;
            DeleteButton.Enabled = false;
            ElementsManagerLogic elementsManagerLogic = new ElementsManagerLogic();
            elementsManagerLogic.fillListBox(ElementsListBox, chosen, true);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu(currentlyLoggedUser).ShowDialog();
            this.Close();
        }
    }
}
