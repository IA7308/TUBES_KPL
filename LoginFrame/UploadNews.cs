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
    public partial class UploadNews : Form
    {
        public UploadNews()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            dgv.Rows.Add(Jenis.Text, Judulbox.Text, isiBox.Text);
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(dgv.CurrentRow != null)
            {
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                dgv.CurrentRow.Cells["JudulBerita"].Value = Jenis.Text;
                dgv.CurrentRow.Cells["JudulKolom"].Value = Judulbox.Text;
                dgv.CurrentRow.Cells["IsiKolom"].Value = isiBox.Text;
            }
        }
    }
}
