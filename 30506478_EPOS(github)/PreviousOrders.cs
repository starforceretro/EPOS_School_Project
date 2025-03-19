using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30506478_EPOS
{
    public partial class PreviousOrders : Form
    {
        public PreviousOrders() // make calls to the different aspects of the program, this will allow the table to see the info
        {
            InitializeComponent();
            LoadPrevOrder();
            DisplayOrdersInGrid();
            
        }
         // delcare global variables
        string[] names;
        string[] costs;
        string[] sizes;
        string[] amounts;

        private void LoadPrevOrder() // create a method for loading the previous order
        {
            string allNames = "";
            string allCosts = "";
            string allSizes = "";
            string AllAmounts = "";

            using (StreamReader sr = new StreamReader("orders.csv")) // create a streamreader that will read from the orders.csv file
            


            {
                allNames = sr.ReadLine();
                allCosts = sr.ReadLine();
                allSizes = sr.ReadLine();
                AllAmounts = sr.ReadLine();
            }

            names = allNames.Split(',');
            costs = allCosts.Split(',');
            sizes = allSizes.Split(',');
            amounts = AllAmounts.Split(',');
        }

        private void DisplayOrdersInGrid() // this will add the data to the table
        {
            int combinedTotal = 0;
           int numberOfOrders = 0;
            foreach (string name in names)
            {
                var index = tblPreviousOrders.Rows.Add();
                tblPreviousOrders.Rows[index].Cells[0].Value = names[index];
                tblPreviousOrders.Rows[index].Cells[1].Value = "£" +  costs[index];
                tblPreviousOrders.Rows[index].Cells[2].Value = sizes[index];
                tblPreviousOrders.Rows[index].Cells[3].Value = amounts[index];
                

                int lineTotal = Convert.ToInt32(costs[index]) * Convert.ToInt32(amounts[index]);

                tblPreviousOrders.Rows[index].Cells[4].Value = "£" + Convert.ToInt32(costs[index]) * Convert.ToInt32(amounts[index]);

                tblPreviousOrders.Rows[index].Cells[4].Value = "£" + lineTotal;

                combinedTotal = combinedTotal + lineTotal;
                numberOfOrders++;



            }

            lblTotal.Text = "£" +  combinedTotal.ToString();
            lblAverage.Text = "£" + (combinedTotal / numberOfOrders);


        }

        private void btnBacktoMain_Click(object sender, EventArgs e) // create a back button to get back to the main menu
        {
            MainMenu btnBacktoMain = new MainMenu();
            btnBacktoMain.Visible = true;

            this.Hide();
        }

        private void PreviousOrders_Load(object sender, EventArgs e)
        {

        }
    }
}
