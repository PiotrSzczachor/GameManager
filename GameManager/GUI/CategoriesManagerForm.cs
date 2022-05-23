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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            bool wasDeleted = false;
            CategoriesManagerLogic categoriesManagerLogic = new CategoriesManagerLogic();
            if (!wasDeleted)
            {
                if (CategoriesListBox.SelectedItem.ToString().Contains("Type: Forest"))
                {
                    string id = CategoriesListBox.SelectedItem.ToString().Split(':')[4].Replace(" ", "");
                    categoriesManagerLogic.deleteForest(id, CategoriesListBox);
                    wasDeleted = true;
                }
            }
            if (!wasDeleted)
            {
                if (CategoriesListBox.SelectedItem.ToString().Contains("Type: Temple"))
                {
                    string id = CategoriesListBox.SelectedItem.ToString().Split(':')[5].Replace(" ", "");
                    categoriesManagerLogic.deleteTemple(id, CategoriesListBox);
                    wasDeleted = true;
                }
            }
            if (!wasDeleted)
            {
                if (CategoriesListBox.SelectedItem.ToString().Contains("Type: Castle"))
                {
                    string id = CategoriesListBox.SelectedItem.ToString().Split(':')[5].Replace(" ", "");
                    categoriesManagerLogic.deleteCastle(id, CategoriesListBox);
                    wasDeleted = true;
                }
            }
            if (!wasDeleted)
            {
                if (CategoriesListBox.SelectedItem.ToString().Contains("Type: Cave"))
                {
                    string id = CategoriesListBox.SelectedItem.ToString().Split(':')[5].Replace(" ", "");
                    categoriesManagerLogic.deleteCave(id, CategoriesListBox);
                    wasDeleted = true;
                }
            }
            if (!wasDeleted)
            {
                if (CategoriesListBox.SelectedItem.ToString().Contains("Type: Desert"))
                {
                    string id = CategoriesListBox.SelectedItem.ToString().Split(':')[4].Replace(" ", "");
                    categoriesManagerLogic.deleteDesert(id, CategoriesListBox);
                    wasDeleted = true;
                }
            }
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
        }

        private void forestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
            CategoriesListBox.Items.Clear();
            CategoriesManagerLogic categoriesManagerLogic = new CategoriesManagerLogic();
            categoriesManagerLogic.fillListBoxWithForests(CategoriesListBox, new GameManagerContext());
        }

        private void ResetFiltersButton_Click(object sender, EventArgs e)
        {
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
            CategoriesListBox.Items.Clear();
            CategoriesManagerLogic categoriesManagerLogic = new CategoriesManagerLogic();
            categoriesManagerLogic.fillListBox(CategoriesListBox);
        }

        private void CategoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoriesListBox.SelectedIndex >= 0)
            {
                DeleteButton.Enabled = true;
                EditButton.Enabled = true;
            }
            
        }

        private void templesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
            CategoriesListBox.Items.Clear();
            CategoriesManagerLogic categoriesManagerLogic = new CategoriesManagerLogic();
            categoriesManagerLogic.fillListBoxWithTemples(CategoriesListBox, new GameManagerContext());
        }

        private void cavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
            CategoriesListBox.Items.Clear();
            CategoriesManagerLogic categoriesManagerLogic = new CategoriesManagerLogic();
            categoriesManagerLogic.fillListBoxWithCastles(CategoriesListBox, new GameManagerContext());
        }

        private void cavesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
            CategoriesListBox.Items.Clear();
            CategoriesManagerLogic categoriesManagerLogic = new CategoriesManagerLogic();
            categoriesManagerLogic.fillListBoxWithCaves(CategoriesListBox, new GameManagerContext());
        }

        private void desertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
            CategoriesListBox.Items.Clear();
            CategoriesManagerLogic categoriesManagerLogic = new CategoriesManagerLogic();
            categoriesManagerLogic.fillListBoxWithDeserts(CategoriesListBox, new GameManagerContext());
        }
    }
}
