namespace LoginFrame
{
    partial class UploadNews
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.UpdateBerita = new System.Windows.Forms.Label();
            this.JenisBerita = new System.Windows.Forms.Label();
            this.Judul = new System.Windows.Forms.Label();
            this.Isi = new System.Windows.Forms.Label();
            this.Jenis = new System.Windows.Forms.TextBox();
            this.Judulbox = new System.Windows.Forms.TextBox();
            this.isiBox = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.JudulBerita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JudulKolom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsiKolom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(580, 87);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 28);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(580, 158);
            this.Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(100, 28);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(580, 230);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 28);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // UpdateBerita
            // 
            this.UpdateBerita.AutoSize = true;
            this.UpdateBerita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBerita.Location = new System.Drawing.Point(421, 11);
            this.UpdateBerita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdateBerita.Name = "UpdateBerita";
            this.UpdateBerita.Size = new System.Drawing.Size(143, 25);
            this.UpdateBerita.TabIndex = 3;
            this.UpdateBerita.Text = "Update Berita";
            // 
            // JenisBerita
            // 
            this.JenisBerita.AutoSize = true;
            this.JenisBerita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JenisBerita.Location = new System.Drawing.Point(16, 96);
            this.JenisBerita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JenisBerita.Name = "JenisBerita";
            this.JenisBerita.Size = new System.Drawing.Size(123, 20);
            this.JenisBerita.TabIndex = 4;
            this.JenisBerita.Text = "Jenis Berita :";
            // 
            // Judul
            // 
            this.Judul.AutoSize = true;
            this.Judul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Judul.Location = new System.Drawing.Point(16, 166);
            this.Judul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Judul.Name = "Judul";
            this.Judul.Size = new System.Drawing.Size(66, 20);
            this.Judul.TabIndex = 5;
            this.Judul.Text = "Judul :";
            // 
            // Isi
            // 
            this.Isi.AutoSize = true;
            this.Isi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Isi.Location = new System.Drawing.Point(16, 230);
            this.Isi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Isi.Name = "Isi";
            this.Isi.Size = new System.Drawing.Size(41, 20);
            this.Isi.TabIndex = 6;
            this.Isi.Text = "Isi :";
            // 
            // Jenis
            // 
            this.Jenis.Location = new System.Drawing.Point(193, 96);
            this.Jenis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Jenis.Name = "Jenis";
            this.Jenis.Size = new System.Drawing.Size(195, 22);
            this.Jenis.TabIndex = 7;
            // 
            // Judulbox
            // 
            this.Judulbox.Location = new System.Drawing.Point(193, 166);
            this.Judulbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Judulbox.Name = "Judulbox";
            this.Judulbox.Size = new System.Drawing.Size(195, 22);
            this.Judulbox.TabIndex = 8;
            // 
            // isiBox
            // 
            this.isiBox.Location = new System.Drawing.Point(193, 234);
            this.isiBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isiBox.Name = "isiBox";
            this.isiBox.Size = new System.Drawing.Size(195, 22);
            this.isiBox.TabIndex = 9;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JudulBerita,
            this.JudulKolom,
            this.IsiKolom});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 369);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1067, 185);
            this.dgv.TabIndex = 10;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(951, 15);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 28);
            this.Back.TabIndex = 11;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // JudulBerita
            // 
            this.JudulBerita.HeaderText = "Jenis Berita";
            this.JudulBerita.MinimumWidth = 6;
            this.JudulBerita.Name = "JudulBerita";
            this.JudulBerita.ReadOnly = true;
            // 
            // JudulKolom
            // 
            this.JudulKolom.HeaderText = "Judul";
            this.JudulKolom.MinimumWidth = 6;
            this.JudulKolom.Name = "JudulKolom";
            this.JudulKolom.ReadOnly = true;
            // 
            // IsiKolom
            // 
            this.IsiKolom.HeaderText = "Isi";
            this.IsiKolom.MinimumWidth = 6;
            this.IsiKolom.Name = "IsiKolom";
            this.IsiKolom.ReadOnly = true;
            // 
            // UploadNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.isiBox);
            this.Controls.Add(this.Judulbox);
            this.Controls.Add(this.Jenis);
            this.Controls.Add(this.Isi);
            this.Controls.Add(this.Judul);
            this.Controls.Add(this.JenisBerita);
            this.Controls.Add(this.UpdateBerita);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UploadNews";
            this.Text = "UploadNews";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label UpdateBerita;
        public System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label JenisBerita;
        private System.Windows.Forms.Label Judul;
        private System.Windows.Forms.Label Isi;
        private System.Windows.Forms.TextBox Jenis;
        private System.Windows.Forms.TextBox Judulbox;
        private System.Windows.Forms.TextBox isiBox;
        private System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn JudulBerita;
        private System.Windows.Forms.DataGridViewTextBoxColumn JudulKolom;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsiKolom;
    }
}