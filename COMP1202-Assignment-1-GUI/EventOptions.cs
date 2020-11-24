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
    public partial class EventOptions : Form
    {
        public EventOptions()
        {
            InitializeComponent();
        }

        private void dtpEventDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EventOptions_Load(object sender, EventArgs e)
        {
            dtpEventDate.Format = DateTimePickerFormat.Custom;
            dtpEventDate.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }
    }
}
