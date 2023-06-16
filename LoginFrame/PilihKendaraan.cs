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
    public partial class PilihKendaraan : Form
    {
        public PilihKendaraan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            NEWS news = new NEWS();
            news.Visible = true;
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
