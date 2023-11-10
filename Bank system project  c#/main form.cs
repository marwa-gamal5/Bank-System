using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectfinal
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panel_transaction.Visible = false;
            panel_account.Visible = false;
            panel_services.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panel_transaction.Visible == true)
            {
                panel_transaction.Visible = false;
            }
            if (panel_account.Visible == true)
            {
                panel_account.Visible = false;
            }
            if (panel_services.Visible == true)
            {
                panel_services.Visible = false;
            }
           
        }
        private void showSubmenu(Panel panel_menu)
        {
            if (panel_menu.Visible == false)
            {
                hideSubmenu();
                panel_menu.Visible = true;
            }
            else
            {
                panel_menu.Visible = false;
            }
        }
        private void button_transaction_Click(object sender, EventArgs e)
        {
            //showSubmenu(panel_transaction);
            showSubmenu(panel_transaction);
        }

        

        private void button_withdraw_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            Form_withdraw f = new Form_withdraw();
            f.Show();
        }

        private void button_deposite_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            Form_deposit f = new Form_deposit();
            f.ShowDialog();

        }

        private void button_check_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            Form_transfer f = new Form_transfer();
            f.Show();
        }

        private void button_account_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_account);
        }

        private void button_create_ac_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            Form_account f = new Form_account();
            f.Show();
        }
        private void button_display_ac_info_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            Form_display_info f = new Form_display_info();
            f.Show();
        }

        private void button_service_Click(object sender, EventArgs e)
        {
        }

        private void button_complaint_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            Form_complaint f = new Form_complaint();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            form_checkBalance f = new form_checkBalance();
            f.Show();
        }

        private void panel_sevice_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void button_service_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panel_services);
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            Form_logIn f = new Form_logIn();
            f.Show();
            Hide();
        }
    }
}
