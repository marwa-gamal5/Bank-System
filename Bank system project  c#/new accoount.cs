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
    public partial class Form_account : Form
    {
        public Form_account()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BankDatabase db = new BankDatabase();
            db.Database.EnsureCreated();
            try
            {
               
                Account account = new Account();
                account.Name = textBox_name.Text;
                account.Occupation = textBox_occupation.Text;
                account.Phone = textBox_phone.Text;
                account.Date_of_birth = textBox_birth.Text;
                account.Address = textBox_address.Text;
                foreach(var i in comboBox_accountType.Items)
                {
                    account.Account_type =Convert.ToString( comboBox_accountType.SelectedItem);
                }
                foreach(var i in comboBox_branche.Items)
                {
                    account.Branche = Convert.ToString( comboBox_branche.SelectedItem);
                }
                account.Balance = decimal.Parse(textBox_balance.Text);

                if (radioButton_male.Checked)
                {
                    account.Gender = "Male";
                }else if (radioButton_female.Checked)
                {
                    account.Gender = "Female";
                }
                db.Accounts.Add(account);
                db.SaveChanges();
                MessageBox.Show($"Created successfully \n Your Account Number is " + account.Id , "New Account ", MessageBoxButtons.YesNo);


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_account f1 = new Form_account();
            main_form f = new main_form();
            f.Show();
            f1.Hide();
        }
    }
}
