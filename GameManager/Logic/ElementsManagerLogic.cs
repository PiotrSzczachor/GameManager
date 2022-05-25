using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameManager.DBModels;
using GameManager.GUI;
using GameManager.Logic;

namespace GameManager
{
    public class ElementsManagerLogic
    {
        List<string> tablesNames = new List<string>
            { "Alchemists", "Archers", "Bats", "Cobras", "Dragons", "Ents", "Golems", "Knights", "Mummies", "Scorpions", "Spiders", "Warewolves", "Warriors", "Witches", "Wizzards" };
        public void fillListBox(ListBox ElementsListBox, List<string> chosenTypes, bool all)
        {
            if (!all)
            {
                tablesNames = chosenTypes;
            }
            using (var db = new GameManagerContext())
            {
                foreach (string table in tablesNames)
                {
                    var typeId = db.Database.SqlQuery<int?>("SELECT Type_Id FROM " + table).FirstOrDefault();
                    if (typeId != null)
                    {
                        string[] atributesNames = db.Database.SqlQuery<string>("SELECT Atributes FROM ElementTypes WHERE ID=" + typeId).FirstOrDefault().Split(',');
                        var elementsNames = db.Database.SqlQuery<string>("SELECT Name FROM " + table).ToList();
                        var elementsIds = db.Database.SqlQuery<int?>("SELECT ID FROM " + table).ToList();
                        int count = elementsNames.Count();
                        for (int i = 0; i < count; i++)
                        {
                            List<int> atributesValues = new List<int>();
                            for (int j = 0; j < 5; j++)
                            {
                                var value = db.Database.SqlQuery<int?>("SELECT " + atributesNames[j] + " FROM " + table + " WHERE ID=" + elementsIds[i]).FirstOrDefault();
                                if (value != null)
                                {
                                    atributesValues.Add((int)value);
                                }
                                else
                                {
                                    atributesValues.Add(0);
                                }
                            }
                            var categoryId = db.Database.SqlQuery<int?>("SELECT Category_Id FROM " + table + " WHERE ID=" + elementsIds[i]).FirstOrDefault();
                            string categoryName = "";
                            var type = db.Database.SqlQuery<string>("SELECT Name FROM ElementTypes WHERE ID=" + typeId).FirstOrDefault();
                            if (type == "Archer" || type == "Knight" || type == "Warrior")
                            {
                                var categoryQuery= db.Castles.SingleOrDefault(c => c.Id == (int)categoryId);
                                categoryName = categoryQuery.name;
                            }
                            if (type == "Mummy" || type == "Scorpion" || type == "Cobra")
                            {
                                var categoryQuery = db.Deserts.SingleOrDefault(c => c.Id == (int)categoryId);
                                categoryName = categoryQuery.name;
                            }
                            if (type == "Witch" || type == "Wizzard" || type == "Alchemist")
                            {
                                var categoryQuery = db.Temples.SingleOrDefault(c => c.Id == (int)categoryId);
                                categoryName = categoryQuery.name;
                            }
                            if (type == "Ent" || type == "Warewolf" || type == "Spider")
                            {
                                var categoryQuery = db.Forests.SingleOrDefault(c => c.Id == (int)categoryId);
                                categoryName = categoryQuery.Name;
                            }
                            if (type == "Dragon" || type == "Golem" || type == "Bat")
                            {
                                var categoryQuery = db.Caves.SingleOrDefault(c => c.Id == (int)categoryId);
                                categoryName = categoryQuery.caveName;
                            }
                            string elementInfo = "Type: " + type + "  |  Name: " + elementsNames[i] + "  |  " + atributesNames[0] + ": " + atributesValues[0] +
                                                 "  |  " + atributesNames[1] + ": " + atributesValues[1] + "  |  " + atributesNames[2] + ": " + atributesValues[2] +
                                                 "  |  " + atributesNames[3] + ": " + atributesValues[3] + "  |  " + atributesNames[4] + ": " + atributesValues[4] +
                                                 "  |  Category: " + categoryName + "  |  " + type + "ID: " + elementsIds[i];
                            ElementsListBox.Items.Add(elementInfo);
                        }
                    }
                }

            }
        }

        public void fillFiltersCheckBoxList(CheckedListBox checkedListBox)
        {
            foreach(string element in tablesNames)
            {
                checkedListBox.Items.Add(element);
            }
        }

        public List<string> getFilters(CheckedListBox checkedListBox)
        {
            List<string> filters = new List<string>();
            foreach(var item in checkedListBox.CheckedItems)
            {
                filters.Add(item.ToString());
            }
            return filters;
        }

        public void filter(List<string> chosen, ListBox ElementsListBox)
        {
            ElementsListBox.Items.Clear();
            if (chosen.Count != 0)
            {
                fillListBox(ElementsListBox, chosen, false);
            }
            else
            {
                fillListBox(ElementsListBox, chosen, true);
            }
        }

        public void deleteElement(string elementInfo)
        {
            string elementName = elementInfo.Split(new string[] { "  |  " }, StringSplitOptions.None)[0].Replace("Type: ", "");
            string elementID = elementInfo.Split(new string[] { "  |  " }, StringSplitOptions.None)[8].Replace(elementName+"ID: ", "");
            string table = elementName + "s";
            if (elementName == "Warewolf")
            {
                table = "Warewolves";
            }
            if (elementName == "Witch")
            {
                table = "Witches";
            }
            if (elementName == "Mummy")
            {
                table = "Mummies";
            }
            using (var db = new GameManagerContext())
            {
                db.Database.ExecuteSqlCommand("DELETE FROM " + table + " WHERE ID=" + elementID);
            }
        }

        public void fillTypesComboBox(ComboBox typesComboBox)
        {
            foreach (string element in tablesNames)
            {
                string el = element.Remove(element.Length - 1);
                if (element == "Warewolves")
                {
                    el = "Warewolf";
                }
                if (element == "Witches")
                {
                    el = "Witch";
                }
                if (element == "Mummies")
                {
                    el = "Mummy";
                }
                typesComboBox.Items.Add(el);
            }
        }
        
    }
}
