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
    public partial class Form_transfer : Form
    {
        public Form_transfer()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            main_form f = new main_form();
            f.Show();
        }

        private void button_transfer_Click(object sender, EventArgs e)
        {
            BankDatabase db = new BankDatabase();
            db.Database.EnsureCreated();
            try
            {
                Account account = (from cx in db.Accounts.ToList()
                                   where cx.Id == int.Parse(textBox_accountNumber.Text)
                                   select cx).FirstOrDefault();
                Account account1 = (from cx in db.Accounts.ToList()
                                   where cx.Id == int.Parse(textBox_accountNumber.Text)
                                   select cx).FirstOrDefault();
                if (account != null && account1!=null)
                {
                    account.Balance -= decimal.Parse(textBox_amount.Text);
                    account1.Balance+= decimal.Parse(textBox_amount.Text);
                    db.SaveChanges();
                    MessageBox.Show($"Succeed Transffered \n ");
                }

            }
            catch
            {
                MessageBox.Show("Failed !");
            }

        }
    }
}
