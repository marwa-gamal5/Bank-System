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
    public partial class Form_display_info : Form
    {
        public Form_display_info()
        {
            InitializeComponent();
        }




        private void button_back_Click(object sender, EventArgs e)
        {
            Form_display_info f1 = new Form_display_info();
            main_form f = new main_form();
            f.Show();
            f1.Hide();
        }

        private void button_display_Click(object sender, EventArgs e)
        {
            BankDatabase db = new BankDatabase();
            db.Database.EnsureCreated();
                    Account account = (from cx in db.Accounts.ToList()
                               where cx.Id ==int.Parse(textBox_accountNumber.Text)
                               select cx).FirstOrDefault();

            if (account != null)
            {
                textBox_name.Text = account.Name;
                textBox_occupation.Text = account.Occupation;
                textBox_phone.Text = account.Phone;
                textBox_balance.Text =Convert.ToString( account.Balance);
                textBox_birth.Text = account.Date_of_birth;
                textBox_branch.Text = account.Branche;
                textBox_gender.Text = account.Gender;
                textBox_accountType.Text = account.Account_type;
                textBox_accountNumber.Text = Convert.ToString(account.Id);
                textBox_address.Text = account.Address;
            }
                                       
            if (account == null)
            {
                MessageBox.Show("Not Found !");
            }

        }

        private void Form_display_info_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
