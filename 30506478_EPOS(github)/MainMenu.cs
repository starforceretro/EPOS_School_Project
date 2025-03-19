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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e) // creates a button to let the user log out
        {
            LogIn btnSubmit = new LogIn();
            btnSubmit.Visible = true;

            this.Hide();
        }

        private void btnJapFood_Click(object sender, EventArgs e) // creates a button to go to the japanese food section
        {
            JapaneseFood btnJapFood = new JapaneseFood();
            btnJapFood.Visible = true;

            this.Hide();
        }

        private void btnThaiFood_Click(object sender, EventArgs e) // creates a button to get to the thai food section
        {
            ThaiFood btnThaiFood = new ThaiFood();
            btnThaiFood.Visible = true;

            this.Hide();
        }

        private void btnMexFood_Click(object sender, EventArgs e) // creates a button to get to the mexican food section
        {
            MexicanFood btnMexFood = new MexicanFood();
            btnMexFood.Visible = true;

            this.Hide();
        }

        private void btnGermFood_Click(object sender, EventArgs e) // creates a button to get to the german food section
        {
            GermanFood btnGermFood = new GermanFood();
            btnGermFood.Visible = true;

            this.Hide();
        }

        private void btnPrevOrders_Click(object sender, EventArgs e) // create a button to get to the previous orders page
        {
            PreviousOrders btnPrevOrders = new PreviousOrders();
            btnPrevOrders.Visible = true;

            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
