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
    public partial class Form_newUser : Form
    {
        private readonly object db;

        public Form_newUser()
        {
            InitializeComponent();
        }

        private void button_Signup(object sender, EventArgs e)
        {
            BankDatabase db = new BankDatabase();
            db.Database.EnsureCreated();
            try
            {
               
               
            Account account = new Account();
            account.UserName = textBox_username.Text;
            account.password = textBox_password.Text;

                db.Accounts.Add(account);
                db.SaveChanges();

            var result = MessageBox.Show("Registration success", "New User ", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                    
                Form_logIn f1 = new Form_logIn();
                f1.Show();
                Hide();

            }
            else
            {
                textBox_username.Text = "";
                textBox_password.Text = "";

            }
        }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_Back(object sender, EventArgs e)
        {
            Form_logIn f = new Form_logIn();
            f.Show();
            Hide();
        }

       
    }
}
