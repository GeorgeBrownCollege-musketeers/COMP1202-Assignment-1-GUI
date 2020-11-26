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
        private EventCoordinator eCoord;
        public EventOptions()
        {
            InitializeComponent();
        }

        public EventOptions(EventCoordinator eCoord)
        {
            this.eCoord = eCoord;
            InitializeComponent();
        }

        public void updateTable()
        {
            this.dgvEvents.Rows.Clear();
            foreach (Event e in this.eCoord.GetEvents())
                dgvEvents.Rows.Add(e.getEventId(), e.getEventName(), e.getVenue(), e.getEventDate().ToString(), e.getAttendees(), e.getMaxAttendees());
        }

        private void dtpEventDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EventOptions_Load(object sender, EventArgs e)
        {
            dtpEventDate.Format = DateTimePickerFormat.Custom;
            dtpEventDate.CustomFormat = "MM/dd/yyyy hh:mm";
            updateTable();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackToMenu_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEvents.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    eCoord.deleteEvent(Convert.ToInt32(dgvEvents.CurrentRow.Cells["id"].Value));
                    updateTable();
                }
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            this.eCoord.addEvent(txtEventName.Text, txtEventVenue.Text, new COMP1202_Assignment_1_GUI.Date(dtpEventDate.Value.Day, dtpEventDate.Value.Month, dtpEventDate.Value.Year, dtpEventDate.Value.Hour, dtpEventDate.Value.Minute), Convert.ToInt32(nudMaxAttendees.Value));
            updateTable();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
