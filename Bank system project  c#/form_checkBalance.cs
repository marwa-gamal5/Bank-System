using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;

namespace projectfinal
{
    public partial class form_checkBalance : Form
    {
        public form_checkBalance()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main_form f = new main_form();
            f.Show();
            form_checkBalance f1 = new form_checkBalance();
            f1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BankDatabase db = new BankDatabase();
            db.Database.EnsureCreated();
            try
            {
                Account account = (from cx in db.Accounts.ToList()
                                   where cx.Id == int.Parse(textBox_accountNumber.Text)
                                   select cx).FirstOrDefault();
               
                if (account != null)
                {
                    textBox_balance.Text=  Convert.ToString( account.Balance);
                   
                }

            }
            catch
            {
                MessageBox.Show("Failed !");
            }
        }
    }
}
