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
    public partial class JapaneseFood : Form
    {
        public JapaneseFood()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) // create the back button to main menu
        {
            MainMenu btnBack = new MainMenu();
            btnBack.Visible = true;

            this.Hide();
        }

        private void JapaneseFood_Load(object sender, EventArgs e)
        {

        }

        private void btnOni_Click(object sender, EventArgs e)  // create the Onigiri object 
        {
            Food onigi = new Food();
            onigi.name = "Onigiri";
            onigi.cost = 8;
            onigi.sizeOfMeal = "Small";

            FoodInformation food = new FoodInformation(onigi); // make a call to open a new foodinformation window with the unique details
            food.Visible = true;
            this.Hide();

        }

        private void btnMochi_Click(object sender, EventArgs e) // create the Mochi object 
        {
            Food moch = new Food();
            moch.name = "Mochi";
            moch.cost = 4;
            moch.sizeOfMeal = "Small";

            FoodInformation food = new FoodInformation(moch); // make a call to open a new foodinformation window with the unique details
            food.Visible = true;
            this.Hide();
        }

        private void btnOkowa_Click(object sender, EventArgs e) // create the Okowa object 
        {
            Food oko = new Food();
            oko.name = "Okowa";
            oko.cost = 5;
            oko.sizeOfMeal = "Small";

            FoodInformation food = new FoodInformation(oko); // make a call to open a new foodinformation window with the unique details
            food.Visible = true;
            this.Hide();

        }

        private void BtnOya_Click(object sender, EventArgs e) // create the Oyakudon object 
        {
            Food oya = new Food();
            oya.name = "Oyakudon";
            oya.cost = 9;
            oya.sizeOfMeal = "Medium";

            FoodInformation food = new FoodInformation(oya); // make a call to open a new foodinformation window with the unique details
            food.Visible = true;
            this.Hide();
        }


    }
}
