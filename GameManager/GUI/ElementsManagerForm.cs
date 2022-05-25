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
        string selectedElementInfo;
        public ElementsManagerForm(Users user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            EditButton.Enabled = false;
            DeleteButton.Enabled = false;
            ElementsManagerLogic elementsManagerLogic = new ElementsManagerLogic();
            elementsManagerLogic.fillFiltersCheckBoxList(FiltersCheckBoxList);
            elementsManagerLogic.fillListBox(ElementsListBox, chosen, true);
            chosen = elementsManagerLogic.getFilters(FiltersCheckBoxList);

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            ElementsManagerLogic elementsManagerLogic = new ElementsManagerLogic();
            chosen = elementsManagerLogic.getFilters(FiltersCheckBoxList);
            elementsManagerLogic.filter(chosen, ElementsListBox);
            EditButton.Enabled = false;
            DeleteButton.Enabled = false;
            
        }

        private void ElementsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ElementsListBox.SelectedIndex >= 0)
            {
                DeleteButton.Enabled = true;
                EditButton.Enabled = true;
            }
            if (ElementsListBox.SelectedItem != null)
            {
                selectedElementInfo = ElementsListBox.SelectedItem.ToString();
            }
        }

        private void ResetFiltersButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FiltersCheckBoxList.Items.Count; i++)
            {
                FiltersCheckBoxList.SetItemChecked(i, false);
            }
            ElementsListBox.Items.Clear();
            ElementsManagerLogic elementsManagerLogic = new ElementsManagerLogic();
            elementsManagerLogic.fillListBox(ElementsListBox, chosen, true);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ElementsManagerLogic elementsManagerLogic = new ElementsManagerLogic();
            elementsManagerLogic.deleteElement(ElementsListBox.SelectedItem.ToString());
            ElementsListBox.Items.Clear();
            if (chosen.Count() == 0)
            {
                elementsManagerLogic.fillListBox(ElementsListBox, chosen, true);
            } else
            {
                elementsManagerLogic.fillListBox(ElementsListBox, chosen, false);
            }
            EditButton.Enabled = false;
            DeleteButton.Enabled = false;
        }
    }
}
