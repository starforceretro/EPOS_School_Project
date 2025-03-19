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
    public partial class ThaiFood : Form
    {
        public ThaiFood()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu btnBack = new MainMenu();
            btnBack.Visible = true;

            this.Hide();
        }

        private void btnPadThai_Click(object sender, EventArgs e) // create the Pad Thai object 
        {
            Food pad = new Food();
            pad.name = "Pad Thai";
            pad.cost = 12;
            pad.sizeOfMeal = "Medium";

            FoodInformation food = new FoodInformation(pad); // make a call to open a new foodinformation window with the unique details
            food.Visible = true;
            this.Hide();
        }

        private void btnRoti_Click(object sender, EventArgs e) // create the Roti Canai object 
        {
            Food roti = new Food();
            roti.name = "Roti Canai";
            roti.cost = 17;
            roti.sizeOfMeal = "Large";

            FoodInformation food = new FoodInformation(roti); // make a call to open a new foodinformation window with the unique details
            food.Visible = true;
            this.Hide();
        }

        private void btnPhat_Click(object sender, EventArgs e) // create the Phat Kaphrao object 
        {
            Food phat = new Food();
            phat.name = "Phat Kaphrao";
            phat.cost = 9;
            phat.sizeOfMeal = "Medium";

            FoodInformation food = new FoodInformation(phat); // make a call to open a new foodinformation window with the unique details
            food.Visible = true;
            this.Hide();
        }

        private void btnDrunken_Click(object sender, EventArgs e) // create the Drunken Noodles object 
        {
            Food drunk = new Food();
            drunk.name = "Drunken Noodles";
            drunk.cost = 13;
            drunk.sizeOfMeal = "Medium";

            FoodInformation food = new FoodInformation(drunk); // make a call to open a new foodinformation window with the unique details
            food.Visible = true;
            this.Hide();
        }
    }
}
