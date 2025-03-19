using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30506478_EPOS
{
    public partial class MexicanFood : Form
    {
        public MexicanFood()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) // create the back button
        {
            MainMenu btnBack = new MainMenu();
            btnBack.Visible = true;

            this.Hide();
        }

        private void btnEnchilada_Click(object sender, EventArgs e) // create the Enchilada's object 
        {
            Food ench = new Food();
            ench.name = "Enchilada's";
            ench.cost = 18;
            ench.sizeOfMeal = "Large";

            FoodInformation food = new FoodInformation(ench); // make a call to open a new foodinformation window with the unique details
            food.Visible = true;
            this.Hide();
        }

        private void btnNacho_Click(object sender, EventArgs e) // create the Nacho's object 
        {
            Food nach = new Food();
            nach.name =  "Nacho's";
            nach.cost = 10;
            nach.sizeOfMeal = "Medium";

            FoodInformation food = new FoodInformation(nach); // make a call to open a new foodinformation window with the unique details
            food.Visible = true;
            this.Hide();
        }

        private void btnChurro_Click(object sender, EventArgs e) // create the Churro's object 
        {
            Food chur = new Food();
            chur.name = "Churro's";
            chur.cost = 5;
            chur.sizeOfMeal = "Small";

            FoodInformation food = new FoodInformation(chur); // make a call to open a new foodinformation window with the unique details
            food.Visible = true;
            this.Hide();
        }

        private void btnBurrito_Click(object sender, EventArgs e) // create the Burrito's object 
        {
            Food bur = new Food();
            bur.name = "Burrito's";
            bur.cost = 15;
            bur.sizeOfMeal = "Medium";

            FoodInformation food = new FoodInformation(bur); // make a call to open a new foodinformation window with the unique details
            food.Visible = true;
            this.Hide(); 
        }
    }
}
