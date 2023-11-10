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
    public partial class Form_deposit : Form
    {
        public Form_deposit()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            main_form f = new main_form();
            f.Show();
        }

        private void button_deposite_Click(object sender, EventArgs e)
        {
            BankDatabase db = new BankDatabase();
            db.Database.EnsureCreated();
            try
            {
                Account account = (from cx in db.Accounts.ToList()
                                   where cx.Id == int.Parse(textBox_accountNumber.Text)
                                   select cx).FirstOrDefault();
                if(account != null)
                {
                    account.Balance += decimal.Parse(textBox_amount.Text);
                    db.SaveChanges();
                    MessageBox.Show($"Succeeded \n Your Balance is "+account.Balance);
                }
               
            }
            catch
            {
                MessageBox.Show("Failed !");
            }
           
        }
    }
}
