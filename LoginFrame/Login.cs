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
    public partial class Login : Form
    {
        IController controller;
        
        public Login(IController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Jika inputan kosong.
            if (this.textBox1.Text == "" || this.textBox2.Text == "")
            {
                MessageBox.Show("Tidak Boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Jika tidak kosong.
            else
            {
                //Memanggil controller Login dengan berisikan parameter textBox.
                controller.Login(this.textBox1.Text, this.textBox2.Text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Memanggil Controller Registrasi.
            controller.Registrasi();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
