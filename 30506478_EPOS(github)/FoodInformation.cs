using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30506478_EPOS
{
    public partial class FoodInformation : Form
    {
        Food GlobalFood; // global variables that can be used anywhere. Names, costs, sizes and amounts 

        string[] names;
        string[] costs;
        string[] sizes;
        string[] amounts;
 
        
      
        public FoodInformation(Food food) // link the labels to the objects in food 
        {
           
            GlobalFood = food;
            InitializeComponent();
           nameLBL.Text = food.name;
          costLBL.Text  = "£" + food.cost;
            somLBL.Text = food.sizeOfMeal;
            loadPreviousOrders();
        }

        private void FoodInformation_Load(object sender, EventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e) //create a back button to the main menu
        {
            MainMenu main = new MainMenu();
            main.Visible = true;
            this.Hide();
        }

        private void loadPreviousOrders() // create a method to look the previous order
        {
            string allNames = "";
            string allCosts = "";
            string allSizes = "";
            string allAmounts = "";
     
            
       



            using (StreamReader sr = new StreamReader("orders.csv")) // create a streamreader to read the orders.csv file



            {
                allNames = sr.ReadLine();
                allCosts = sr.ReadLine();
                allSizes = sr.ReadLine();
                allAmounts = sr.ReadLine();
                
              

            }

            names = allNames.Split(',');
            costs = allCosts.Split(',');
            sizes = allSizes.Split(',');
            amounts = allAmounts.Split(',');
      
        }



        private void updateOrders(List<string> namesList, List<string> costsList, List<string> sizesList, List<string> amountsList) // create a method that will update the lists in the .csv file
        {
            using (StreamWriter sw = new StreamWriter("orders.csv"))
            {
                sw.WriteLine(string.Join(",", namesList));
                sw.WriteLine(string.Join(",", costsList));
                sw.WriteLine(string.Join(",", sizesList));
                sw.WriteLine(string.Join(",", amountsList));
                 
            

            }
             
            loadPreviousOrders(); // call to the loadPreviousOrders function
            lblSuccess.Text = GlobalFood.name + " Ordered"; // this will tell the user they have ordered 
        }










        private void btn1Plate_Click(object sender, EventArgs e) // create a button for each amount 
        {
            
            string inputSize = "1";
            int amount = Convert.ToInt32(inputSize);
            List<string> namesList = names.ToList();
            List<string> costsList = costs.ToList();
            List<string> sizesList = sizes.ToList();
            List<string> amountsList = amounts.ToList();
    

            namesList.Add(GlobalFood.name);
            sizesList.Add(GlobalFood.sizeOfMeal);
            costsList.Add(GlobalFood.cost.ToString());
            amountsList.Add(inputSize);


            updateOrders(namesList, costsList, sizesList, amountsList);
        }

        private void btn2Plate_Click(object sender, EventArgs e)
        {

            string inputSize = "2";
            int amount = Convert.ToInt32(inputSize);
            List<string> namesList = names.ToList();
            List<string> costsList = costs.ToList();
            List<string> sizesList = sizes.ToList();
            List<string> amountsList = amounts.ToList();


            namesList.Add(GlobalFood.name);
            sizesList.Add(GlobalFood.sizeOfMeal);
            costsList.Add(GlobalFood.cost.ToString());
            amountsList.Add(inputSize);


            updateOrders(namesList, costsList, sizesList, amountsList);
        }

        private void btn3Plate_Click(object sender, EventArgs e)
        {
            string inputSize = "3";
            int amount = Convert.ToInt32(inputSize);
            List<string> namesList = names.ToList();
            List<string> costsList = costs.ToList();
            List<string> sizesList = sizes.ToList();
            List<string> amountsList = amounts.ToList();


            namesList.Add(GlobalFood.name);
            sizesList.Add(GlobalFood.sizeOfMeal);
            costsList.Add(GlobalFood.cost.ToString());
            amountsList.Add(inputSize);


            updateOrders(namesList, costsList, sizesList, amountsList);
        }

        private void btn4Plate_Click(object sender, EventArgs e)
        {
            string inputSize = "4";
            int amount = Convert.ToInt32(inputSize);
            List<string> namesList = names.ToList();
            List<string> costsList = costs.ToList();
            List<string> sizesList = sizes.ToList();
            List<string> amountsList = amounts.ToList();


            namesList.Add(GlobalFood.name);
            sizesList.Add(GlobalFood.sizeOfMeal);
            costsList.Add(GlobalFood.cost.ToString());
            amountsList.Add(inputSize);


            updateOrders(namesList, costsList, sizesList, amountsList);
        }

        private void btn5Plate_Click(object sender, EventArgs e)
        {
            string inputSize = "5";
            int amount = Convert.ToInt32(inputSize);
            List<string> namesList = names.ToList();
            List<string> costsList = costs.ToList();
            List<string> sizesList = sizes.ToList();
            List<string> amountsList = amounts.ToList();


            namesList.Add(GlobalFood.name);
            sizesList.Add(GlobalFood.sizeOfMeal);
            costsList.Add(GlobalFood.cost.ToString());
            amountsList.Add(inputSize);


            updateOrders(namesList, costsList, sizesList, amountsList);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
