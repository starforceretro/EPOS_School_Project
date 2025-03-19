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
    public partial class GermanFood : Form
    {
        public GermanFood()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) // create back button for the main menu
        {
            MainMenu btnBack = new MainMenu(); 
            btnBack.Visible = true;

            this.Hide();
        }

        private void btnBrat_Click(object sender, EventArgs e) // create the Bratwurst object 
        {
            Food brat = new Food();
            brat.name = "Bratwurst";
            brat.cost = 9;
            brat.sizeOfMeal = "Medium";

            FoodInformation food = new FoodInformation(brat); // make a call to open a new foodinformation window with the unique details
            food.Visible = true;
            this.Hide();
        }

        private void btnSchnitzel_Click(object sender, EventArgs e) // create the Schnitzel object 
        {
            Food schni = new Food();
            schni.name = "Schnitzel";
            schni.cost = 15;
            schni.sizeOfMeal = "Large";

            FoodInformation food = new FoodInformation(schni); // make a call to open a new foodinformation window with the unique details
            food.Visible = true;
            this.Hide();
        }

        private void btnApfel_Click(object sender, EventArgs e) // create the Apfelstrudel object 
        {
            Food apfel = new Food();
            apfel.name = "Apfelstrudel";
            apfel.cost = 10;
            apfel.sizeOfMeal = "Medium";

            FoodInformation food = new FoodInformation(apfel); // make a call to open a new foodinformation window with the unique details
            food.Visible = true;
            this.Hide();
        }

        private void btnSauer_Click(object sender, EventArgs e) // create the Sauerkraut object
        {
            Food sau = new Food();
            sau.name = "Sauerkraut";
            sau.cost = 5;
            sau.sizeOfMeal = "Small";

            FoodInformation food = new FoodInformation(sau); // make a call to open a new foodinformation window with the unique details
            food.Visible = true;
            this.Hide();
        }

        private void GermanFood_Load(object sender, EventArgs e)
        {

        }
    }
}
