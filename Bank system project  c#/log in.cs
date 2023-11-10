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
    public partial class Form_logIn : Form
    {
        public Form_logIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Signup(object sender, EventArgs e)
        {
            Form_newUser f = new Form_newUser();
            f.ShowDialog();

        }

        private void button_Login(object sender, EventArgs e)
        {
            BankDatabase db = new BankDatabase();
            db.Database.EnsureCreated();
            string userName = textBox_username.Text;
            string password = textBox_password.Text;

            Account user1 = (from c in db.Accounts.ToList()
                                where c.UserName == userName && c.password == password
                                select c).FirstOrDefault(); 
            if (user1 == null)
            {
                MessageBox.Show("Invalid login");
            }
            else
            {
                Data.LoginUserId = user1.Id; ;

                if (comboBox_position.SelectedIndex==0)

                {
                    if ((textBox_username.Text == "Admin") && (textBox_password.Text == "admin123"))
                    {
                        Form_recieve_complaint f = new Form_recieve_complaint();
                        f.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Admin Login Invalid!");
                    }
                }else if (comboBox_position.SelectedIndex==1)
                {
                    main_form f = new main_form();
                    f.Show();
                    Hide();
                }
            }
        }
        

       

        private void radio_admin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
