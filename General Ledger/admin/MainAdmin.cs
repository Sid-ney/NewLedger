using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using General_Ledger.logs;

namespace General_Ledger
{
    public partial class MainAdmin : Form
    {
        public MainAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.Show();
        }

        private void ModifyUsers_Click(object sender, EventArgs e)
        {
            ModifyUsers modifyUsers = new ModifyUsers();
            modifyUsers.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            NewUser user = new NewUser();
            user.Show();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChartOfAccountsButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ChartInput chart = new ChartInput();
            chart.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            ChartView chartView = new ChartView();
            chartView.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            EventLog eventLog = new EventLog();
            eventLog.Show();
        }
    }
}
