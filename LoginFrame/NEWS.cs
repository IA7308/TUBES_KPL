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
    public partial class NEWS : Form
    {
        IController controller;
        public NEWS(IController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PilihKendaraan pilihKendaraan = new PilihKendaraan();
            pilihKendaraan.Visible = true;
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Login login = new Login();
            //login.Visible = true;
            this.Hide();
        }

        private void UploadBerita_Click(object sender, EventArgs e)
        {
            UploadNews uploadnews = new UploadNews();
            uploadnews.Visible = true;
            this.Hide();
        }
    }
}
