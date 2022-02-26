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
    public partial class ModifyUsers : Form
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=sweappdomain.database.windows.net;Initial Catalog=GeneralLedger;Persist Security Info=True;User ID=Michael;Password=Rutherfoord!");
        public SqlCommand cmd;
        public SqlDataAdapter da;
        private BindingSource bindingSource = null;
        private SqlCommandBuilder SqlCommandBuilder = null;
        DataTable dataTable = new DataTable();

       

        public ModifyUsers()
        {
            InitializeComponent();
            conn.ConnectionString = @"Data Source=sweappdomain.database.windows.net;Initial Catalog=GeneralLedger;Persist Security Info=True;User ID=Michael;Password=Rutherfoord!";
        }

        private void ModifyUsers_Load_1(object sender, EventArgs e)
        {
            // Attach the DataError event to the corresponding event handler.
            this.dataGridView1.DataError +=
                new DataGridViewDataErrorEventHandler(dataGridView1_DataError);
            // Bind the Gridtable
            DataBind();
        }

        private void dataGridView1_DataError(object sender,
    DataGridViewDataErrorEventArgs e)
        {
            // If the data source raises an exception when a cell value is
            // commited, display an error message.
            if (e.Exception != null &&
                e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("CustomerID value must be unique.");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.EndEdit(); //very important step
                da.Update(dataTable);
                MessageBox.Show("User information has been Updated", "Update Successful", MessageBoxButtons.OK);
                DataBind();
            }
            catch (Exception error) 
            {
                MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainAdmin mainAdmin = new MainAdmin();
            mainAdmin.Show();
        }

        private void DataBind()
        {
            dataGridView1.DataSource = null;
            dataTable.Clear();

            String connectionString = @"Data Source=sweappdomain.database.windows.net;Initial Catalog=GeneralLedger;Persist Security Info=True;User ID=Michael;Password=Rutherfoord!"; //use your connection string please
            String queryString1 = "SELECT * FROM UserAccount"; // Use your table please

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = queryString1;
            try
            {
                da = new SqlDataAdapter(queryString1, connection);
                SqlCommandBuilder = new SqlCommandBuilder(da);
                da.Fill(dataTable);
                bindingSource = new BindingSource { DataSource = dataTable };
                dataGridView1.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        //private DataTable GetUser()
        //{
        //    DataTable dt = new DataTable();

        //    cmd = new SqlCommand("SELECT * FROM UserAccount", conn);

        //    conn.Open();

        //     SqlDataReader reader = cmd.ExecuteReader();

        //    dt.Load(reader);
        //    conn.Close();

        //    return dt;
        //}





    }
    
 }
