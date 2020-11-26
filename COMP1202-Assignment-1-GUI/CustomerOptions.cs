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
    public partial class CustomerOptions : Form
    {
        EventCoordinator eCoord;

        public CustomerOptions()
        {
            InitializeComponent();
        }
        
        public CustomerOptions(EventCoordinator eCoord)
        {
            this.eCoord = eCoord;
            InitializeComponent();
        }

        private void CustomerOptions_Load(object sender, EventArgs e)
        {
            this.updateTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void updateTable()
        {
            foreach (Customer customer in this.eCoord.GetCustomers())
                this.dgvCustomers.Rows.Add(customer.getFirstName(), customer.getLastName(),customer.getPhone());  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
