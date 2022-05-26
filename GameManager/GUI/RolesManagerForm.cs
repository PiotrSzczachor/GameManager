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
    public partial class RolesManagerForm : Form
    {
        Users currentlyLoggedUser;
        string chosen;
        public RolesManagerForm(Users user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            EditButton.Enabled = false;
            DeleteButton.Enabled = false;
            PermissionTimer.Enabled = true;
            RolesManagerLogic rolesManagerLogic = new RolesManagerLogic();
            rolesManagerLogic.fillListBox(listBox1);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void PermissionTimer_Tick(object sender, EventArgs e)
        {
            var perm = currentlyLoggedUser.Role;
            if (!perm.AddRoles)
            {
                AddButton.Enabled = false;
            }
            if (!perm.EditRoles)
            {
                EditButton.Enabled = false;
            }
            if (!perm.DeleteRoles)
            {
                DeleteButton.Enabled = false;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddNewRoleForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            RolesManagerLogic rolesManagerLogic = new RolesManagerLogic();
            rolesManagerLogic.deleteRole(chosen);
            listBox1.Items.Clear();
            rolesManagerLogic.fillListBox(listBox1);
            EditButton.Enabled = false;
            DeleteButton.Enabled = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddNewRoleForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                DeleteButton.Enabled = true;
                EditButton.Enabled = true;
            }
            if (listBox1.SelectedItem != null)
            {
                chosen = listBox1.SelectedItem.ToString();
            }
        }
    }
}
