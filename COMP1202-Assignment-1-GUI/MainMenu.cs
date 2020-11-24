using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1202_Assignment_1_GUI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerOptions co = new CustomerOptions();
            co.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnEventOptions_Click(object sender, EventArgs e)
        {
            EventOptions eo = new EventOptions();
            eo.Show();
        }
    }
}
