using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager.Logic
{
    public class EditCategoryLogic
    {
        string instance;
        public EditCategoryLogic(string instance_)
        {
            instance = instance_;
        }
        public void fillForestOrDesertTextBoxes(TextBox NameBox, TextBox AreaBox)
        {
            NameBox.Text = instance.Split(new string[] { "  |  " }, StringSplitOptions.None)[0].Replace("Name: ", "");
            AreaBox.Text = instance.Split(new string[] { "  |  " }, StringSplitOptions.None)[1].Replace("Area: ", "");
        }


        public void fillTempleOrCastleTextBoxes(TextBox NameBox, TextBox NumberBox, TextBox BuildYearBox, bool temple)
        {
            NameBox.Text = instance.Split(new string[] { "  |  " }, StringSplitOptions.None)[0].Replace("Name: ", "");
            if (temple)
            {
                NumberBox.Text = instance.Split(new string[] { "  |  " }, StringSplitOptions.None)[1].Replace("Chambers number: ", "");
            } else
            {
                NumberBox.Text = instance.Split(new string[] { "  |  " }, StringSplitOptions.None)[1].Replace("Towers number: ", "");
            }
            BuildYearBox.Text = instance.Split(new string[] { "  |  " }, StringSplitOptions.None)[2].Replace("Build year: ", "");
        }


        public void fillCaveTextBoxes(TextBox NameBox, TextBox AreaBox, TextBox DescriptionBox)
        {
            NameBox.Text = instance.Split(new string[] { "  |  " }, StringSplitOptions.None)[0].Replace("Name: ", "");
            AreaBox.Text = instance.Split(new string[] { "  |  " }, StringSplitOptions.None)[1].Replace("Area: ", "");
            DescriptionBox.Text = instance.Split(new string[] { "  |  " }, StringSplitOptions.None)[2].Replace("Description: ", "");
        }

        public void editForest()
        {

        }
    }
}
