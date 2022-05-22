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
    public partial class CategoriesManagerForm : Form
    {
        Users currentlyLoggedUser;
        public CategoriesManagerForm(Users user)
        {
            InitializeComponent();
            EditButton.Enabled = false;
            DeleteButton.Enabled = false;
            currentlyLoggedUser = user;
            CategoriesManagerLogic categoriesManagerLogic = new CategoriesManagerLogic();
            categoriesManagerLogic.fillListBox(CategoriesListBox);
        }

        private void AddNewForestButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddForestOrDesertForm(currentlyLoggedUser, true).ShowDialog();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void AddNewDesertButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddForestOrDesertForm(currentlyLoggedUser, false).ShowDialog();
            this.Close();
        }

        private void AddNewTempleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddTempleOrCastleForm(currentlyLoggedUser, true).ShowDialog();
            this.Hide();
        }

        private void AddNewCastleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddTempleOrCastleForm(currentlyLoggedUser, false).ShowDialog();
            this.Hide();
        }

        private void AddNewCaveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddCaveForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void CategoriesListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            EditButton.Enabled = true;
            DeleteButton.Enabled = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            CategoriesManagerLogic categoriesManagerLogic = new CategoriesManagerLogic();
            if (CategoriesListBox.SelectedItem.ToString().Contains("Type: Forest"))
            {
                string id = CategoriesListBox.SelectedItem.ToString().Split(':')[4].Replace(" ", "");
                categoriesManagerLogic.deleteForest(id, CategoriesListBox);
            }
        }
    }
}
