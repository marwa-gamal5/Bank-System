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
    public partial class Form_complaint : Form
    {
        public Form_complaint()
        {
            InitializeComponent();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your complaint has been sent\n and will be reviewed\nThank you !");
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            main_form f = new main_form();
            f.Show();
        }
    }
}
