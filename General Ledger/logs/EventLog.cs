using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General_Ledger.logs
{
    public partial class EventLog : Form
    {
        public EventLog()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'generalLedgerDataSet4.EventLog' table. You can move, or remove it, as needed.
            this.eventLogTableAdapter.Fill(this.generalLedgerDataSet4.EventLog);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainAdmin mainAdmin = new MainAdmin();
            mainAdmin.Show();
        }
    }
}
