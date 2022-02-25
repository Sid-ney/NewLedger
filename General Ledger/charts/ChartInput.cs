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
    public partial class ChartInput : Form
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=sweappdomain.database.windows.net;Initial Catalog=GeneralLedger;Persist Security Info=True;User ID=Michael;Password=Rutherfoord!");
        public SqlCommand cmd;

        public ChartInput()
        {
            InitializeComponent();
        }

        private void ChartInput_Load(object sender, EventArgs e)
        {

        }

        private void labelAccountStatement_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string AccountName = textBoxName.Text;
                string AccountNumber = textBoxNumber.Text;
                string Description = textBoxDescription.Text;
                string Catergory = textBoxCategory.Text;
                string Subcategory = textBoxSubcatagory.Text;
                string InitialBalance = textBoxInitialBalance.Text;
                string Balance = textBoxBalance.Text;
                string Order = textBoxOrder.Text;
                string Statement = textBoxStatement.Text;
                string comment = textBoxComment.Text;
                string NormalSide = listBox1.Text;
                string Debit = debitTextBox.Text;
                string Credit = creditTextBox.Text;
                string dateString = DateTime.Now.ToString("yyyy-MM-dd");
                string datetime = DateTime.Now.ToString("hh:mm:ss tt");
                Decimal BeforeBalance = System.Convert.ToDecimal(Balance);
                Decimal DebitDec = System.Convert.ToDecimal(Debit);
                Decimal CreditDec = System.Convert.ToDecimal(Credit);
                Decimal AfterBalance = AfterBalanceCheck(NormalSide, BeforeBalance, DebitDec, CreditDec);
                Decimal Value = AfterBalance;
                string Username = Login.userID;


              
              



                //String to Decimal: System.Convert.ToDecimal(InitialBalance)

                cmd = new SqlCommand("Insert into ChartOfAccounts Values('" + AccountName + "','" + AccountNumber + "','"
                    + Description + "','" + NormalSide + "','" + Catergory + "','" + Subcategory + "','" + InitialBalance + "','" + Debit
                    + "','" + Credit + "','" + Balance + "','" + dateString + "','" + datetime + "','" + Login.userID + "','" + Order + "','" + Statement + "')", conn); ;
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("Insert into EventLog Values('" + AccountNumber + "' , '" + AccountName + "','" + NormalSide + "','" + BeforeBalance + "','" + AfterBalance + "','" + Value + "','" +
                    dateString + "','" + datetime + "','" + Description + "','" + Username + "')", conn);
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Data Entered");

                this.Close();
                ChartView view = new ChartView();
                view.Show();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private Decimal AfterBalanceCheck(string NormalSide, Decimal BeforeBalance, Decimal DebitDec, Decimal CreditDec) 
        {
            Decimal AfterBalance = 0.00m;
            if (NormalSide.Equals("Debit"))
            {
                AfterBalance = BeforeBalance + DebitDec - CreditDec;
            }
            else if (NormalSide.Equals("Credit"))
            {
                 AfterBalance = BeforeBalance - DebitDec + CreditDec;
            }
            else
            {
                //throw new Exception("Sydney Smells");
            }
            return AfterBalance;

        }

        
    }
}
