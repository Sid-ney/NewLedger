using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace General_Ledger
{
    public partial class ChartView : Form
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=sweappdomain.database.windows.net;Initial Catalog=GeneralLedger;Persist Security Info=True;User ID=Michael;Password=Rutherfoord!");
        public SqlCommand cmd;
        public ChartView()
        {
            InitializeComponent();
        }

        private void Chart_View(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetUser();
        }

        private DataTable GetUser()
        {
            DataTable dt = new DataTable();

            cmd = new SqlCommand("SELECT * FROM ChartOfAccounts", conn);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);
            conn.Close();

            return dt;
        }

        private void ChartView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'generalLedgerDataSet3.ChartOfAccounts' table. You can move, or remove it, as needed.
            this.chartOfAccountsTableAdapter.Fill(this.generalLedgerDataSet3.ChartOfAccounts);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAdmin mainAdmin = new MainAdmin();
            mainAdmin.Show();
        }
    }
}
