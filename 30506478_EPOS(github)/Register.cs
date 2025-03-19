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
    public partial class Register : Form
    {
        
        string[] userNames; // global variables for usernames, passwords and ref codes
        string[] password;
        string[] refferalCodes;

        public Register()
        {
            InitializeComponent();
            loadPreviousUsers();
        }

        private void btnBack_Click(object sender, EventArgs e) // create a button to get back to the log in screen
        {
            LogIn btnBack = new LogIn();
            btnBack.Visible = true;

            this.Hide();
        }


        private void loadPreviousUsers() // create a function to load the previous users info
        {
            string allUserNames = "";
            string allPasswords = "";
            string allRefferalCodes = "";
    



            using (StreamReader sr = new StreamReader("logindetails.csv")) // load the logindetails.csv



            {
                allUserNames = sr.ReadLine(); // this will read the old info
                allPasswords = sr.ReadLine();
                allRefferalCodes = sr.ReadLine();
              

            }

            userNames = allUserNames.Split(',');
            password = allPasswords.Split(',');
            refferalCodes = allRefferalCodes.Split(',');
            
        }

   


        private void updateUsers(List<string> usernamesList, List<string> passwordsList, List<string> refferalCodeList) // this function will update the csv file with the new users information
        {
            using (StreamWriter sw = new StreamWriter("logindetails.csv"))
            {
                sw.WriteLine(string.Join(",", usernamesList));
                sw.WriteLine(string.Join(",", passwordsList));
                sw.WriteLine(string.Join(",", refferalCodeList));

            }

            loadPreviousUsers();
            lblAccountRegistered.Text =  "Account Registered";
        }

        private void btnRegister_Click(object sender, EventArgs e) // this will allow the users inputs to be saved to the csv, allowing them to sign in with their new account 
        {
            string newUser = txtUserName.Text; // Get user input
            string newPassword = txtPassword.Text;
            string newRefferalCode = txtRefCode.Text;

            List<string> usernamesList = userNames.ToList();
            List<string> passwordsList = password.ToList();
            List<string> refferalCodeList = refferalCodes.ToList();

            usernamesList.Add(newUser); // Add input
            passwordsList.Add(newPassword);
            refferalCodeList.Add(newRefferalCode);

            updateUsers(usernamesList, passwordsList, refferalCodeList);




            
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
