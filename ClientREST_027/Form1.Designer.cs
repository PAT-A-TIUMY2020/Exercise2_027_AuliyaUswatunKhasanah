namespace ClientREST_027
{
    partial class Form1
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.dGVDataMhs = new System.Windows.Forms.DataGridView();
            this.btClear = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAngkatan = new System.Windows.Forms.TextBox();
            this.tbProdi = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbNIM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDataMhs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AllowDrop = true;
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(67, 233);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 24);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(616, 82);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(124, 135);
            this.lbTotal.TabIndex = 21;
            this.lbTotal.Text = "0";
            this.lbTotal.Click += new System.EventHandler(this.lbTotal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Total Mahasiswa";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(763, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Cari";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(489, 247);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(269, 22);
            this.tbCari.TabIndex = 18;
            this.tbCari.Text = "Cari Berdasarkan NIM";
            this.tbCari.TextChanged += new System.EventHandler(this.tbCari_TextChanged);
            // 
            // dGVDataMhs
            // 
            this.dGVDataMhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDataMhs.Location = new System.Drawing.Point(63, 275);
            this.dGVDataMhs.Name = "dGVDataMhs";
            this.dGVDataMhs.RowTemplate.Height = 24;
            this.dGVDataMhs.Size = new System.Drawing.Size(775, 150);
            this.dGVDataMhs.TabIndex = 16;
            this.dGVDataMhs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDataMhs_CellContentClick);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(476, 145);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 15;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click_1);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(476, 87);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 14;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click_1);
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(476, 116);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(75, 23);
            this.btHapus.TabIndex = 13;
            this.btHapus.Text = "Delete";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAngkatan);
            this.groupBox1.Controls.Add(this.tbProdi);
            this.groupBox1.Controls.Add(this.tbNama);
            this.groupBox1.Controls.Add(this.tbNIM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTambah);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(62, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 184);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Mahasiswa";
            // 
            // tbAngkatan
            // 
            this.tbAngkatan.Location = new System.Drawing.Point(94, 112);
            this.tbAngkatan.Name = "tbAngkatan";
            this.tbAngkatan.Size = new System.Drawing.Size(269, 22);
            this.tbAngkatan.TabIndex = 7;
            // 
            // tbProdi
            // 
            this.tbProdi.Location = new System.Drawing.Point(94, 82);
            this.tbProdi.Name = "tbProdi";
            this.tbProdi.Size = new System.Drawing.Size(269, 22);
            this.tbProdi.TabIndex = 6;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(94, 53);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(269, 22);
            this.tbNama.TabIndex = 5;
            // 
            // tbNIM
            // 
            this.tbNIM.Location = new System.Drawing.Point(94, 25);
            this.tbNIM.Name = "tbNIM";
            this.tbNIM.Size = new System.Drawing.Size(269, 22);
            this.tbNIM.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Angkatan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prodi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(168, 148);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(195, 23);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah Data Mahasiswa";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 510);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.dGVDataMhs);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDataMhs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.DataGridView dGVDataMhs;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAngkatan;
        private System.Windows.Forms.TextBox tbProdi;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbNIM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label label1;
    }
}

