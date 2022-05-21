using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager
{
    public partial class CategoriesManagerForm : Form
    {
        Users currentlyLoggedUser;
        public CategoriesManagerForm(Users user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            CategoriesManagerLogic categoriesManagerLogic = new CategoriesManagerLogic();
            categoriesManagerLogic.fillListBox(CategoriesListBox);
        }

        private void AddNewForestButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
