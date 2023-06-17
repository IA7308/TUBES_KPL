using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFrame
{
    public partial class SignUpFrame : Form
    {
        public SignUpFrame()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" || this.textBox2.Text == "")
            {
                MessageBox.Show("Tidak Boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Login login = new Login();
                login.Visible = true;
                this.Hide();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Hide();
        }
    }
}
