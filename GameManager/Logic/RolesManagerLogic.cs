using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager.Logic
{
    public class RolesManagerLogic
    {
        public void fillListBox(ListBox listBox)
        {
            using (var db = new GameManagerContext())
            {
                var roles = db.Roles;
                foreach (var role in roles)
                {
                    string roleInfo = "Name: " + role.Name + "  |  Add Forests: " + role.AddForests + "  |  Add Temples: " + role.AddTemples + "  |  Add Castles: " + role.AddCastles + "  |  Add Caves: " + role.AddCaves +
                                      "  |  Add Deserts: " + role.AddDeserts +  "  |  Delete categories: " + role.DeleteCategories +
                                      "  |  Edit categories: " + role.EditCategories + "  |  Add roles: " + role.AddRoles + "  |  Edit roles: " + role.EditRoles +
                                      "  |  Delete roles: " + role.DeleteRoles + "  |  Add users: " + role.AddUsers + "  |  Delete users: " + role.DeleteUsers + "  |  Edit users: " + role.EdidUsers + "  |  Role ID: "+ role.Id;
                    listBox.Items.Add(roleInfo);
                }
            }
        }

        public void deleteRole(string roleInfo)
        {
            int id = Int32.Parse(roleInfo.Split(':').Last().Replace(" ", ""));
            using (var db = new GameManagerContext())
            {
                var role = db.Roles.SingleOrDefault(r => r.Id==id);
                db.Roles.Remove(role);
                db.SaveChanges();
            }
        }
    }
}
