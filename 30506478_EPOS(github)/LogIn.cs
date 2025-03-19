using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30506478_EPOS
{
    public partial class LogIn : Form
    {
   


        public LogIn()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string inputUsername = txtUsername.Text; //declare the input strings
            string inputPassword = txtPassword.Text;
            string inputReferralCode = txtReferral.Text;

            bool correctLogin = loginFunction(inputUsername, inputPassword, inputReferralCode); 
                if (correctLogin == true) // create a boolean that will send the user to the main menu if the conditions are met 
            {
                MainMenu btnSubmit = new MainMenu();
                btnSubmit.Visible = true;

                this.Hide();
            }

            else
            {
                lblError.Text = "Error: incorrect username and/or Password."; // create an error message for the user if the conditions are not met
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private bool loginFunction(string inputUsername, string inputPassword, string inputReferralCode) // create the login function, import the information from previous methods
        {
            string allUsernames = ""; //declare strings for this method 
            string allPasswords = "";
            string allReferralCodes = "";

            using (StreamReader sr = new StreamReader("logindetails.csv")) // this will be used to read the information in our .csv file 
            {
                allUsernames = sr.ReadLine(); // readlines will help the program read the information
                allPasswords = sr.ReadLine();
                allReferralCodes = sr.ReadLine();
            }

            string[] username = allUsernames.Split(','); // checks for the ',' between usernames, passwords and codes
            string[] password = allPasswords.Split(',');
            string[] referralCodes = allReferralCodes.Split(',');

            int index = 0; // create a loop so all usernames, passwords and codes are checked to see if they are correct 
            foreach (string element in username)
            {
                if (inputUsername == username[index] && inputPassword == password[index] && inputReferralCode == referralCodes[index])
                {
                    return true;
                }
             
                 index++;

            }
            return false;

        }

        private void btnRegister_Click(object sender, EventArgs e) // this will take the user to the register page
        {
            Register btnRegister = new Register();
            btnRegister.Visible = true;

            this.Hide();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
