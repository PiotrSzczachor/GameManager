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
    public partial class AddNewRoleForm : Form
    {
        Users currentlyLoggedUser;
        List<string> chosen = new List<string> ();
        string name;
        bool isEdit;
        public AddNewRoleForm(Users user, string name_, bool edit)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            name = name_;
            isEdit = edit;
            if (isEdit)
            {
                NameTextBox.Text = name_;
            }
            AddRoleLogic addRoleLogic = new AddRoleLogic();
            addRoleLogic.fillCheckedList(checkedListBox1);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RolesManagerForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                chosen.Add(item.ToString());
            }
            AddRoleLogic addRoleLogic = new AddRoleLogic();
            if(NameTextBox.Text != "")
            {
                addRoleLogic.addRole(chosen, NameTextBox.Text, isEdit, name);
            } else
            {
                MessageBox.Show("You need to name new role.",
                                "Write role name.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            
        }
    }
}
