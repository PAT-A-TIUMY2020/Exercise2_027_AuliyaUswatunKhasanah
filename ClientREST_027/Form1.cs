using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientREST_027
{
    public partial class Form1 : Form
    {
        Mahasiswa mhs = new Mahasiswa();
        string baseUrl = "http://localhost:1907/";

        public Form1()
        {
            InitializeComponent();

            btUpdate.Enabled = false;
            btHapus.Enabled = false;
            tampilData();
            totalMhs();
        }

        public void tampilData()
        {
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

            dGVDataMhs.DataSource = data;
            dGVDataMhs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }




        public void totalMhs()
        {
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
            int length = data.Count();
            lbTotal.Text = Convert.ToString(length);
        }

        private void responseMsg()
        {

            if (lblStatus.Text.Length >= 8)
            {
                lblStatus.BackColor = System.Drawing.Color.Green;
                lblStatus.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                lblStatus.BackColor = System.Drawing.Color.Red;
                lblStatus.ForeColor = System.Drawing.Color.White;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click_1(object sender, EventArgs e)
        {
            btHapus.Enabled = false;
            btUpdate.Enabled = false;

            mhs.nim = tbNIM.Text;
            mhs.nama = tbNama.Text;
            mhs.angkatan = tbAngkatan.Text;
            mhs.prodi = tbProdi.Text;

            var data = JsonConvert.SerializeObject(mhs);
            var postdata = new WebClient();
            postdata.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            string response = postdata.UploadString(baseUrl + "Mahasiswa", data);

            lblStatus.Text = response;
            responseMsg();
            tampilData();
            totalMhs();
        }

        private void btUpdate_Click_1(object sender, EventArgs e)
        {
            mhs.nim = tbNIM.Text;
            mhs.nama = tbNama.Text;
            mhs.angkatan = tbAngkatan.Text;
            mhs.prodi = tbProdi.Text;

            var data = JsonConvert.SerializeObject(mhs);
            var updatedata = new WebClient();
            updatedata.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            string response = updatedata.UploadString(baseUrl + "UpdateMahasiswa", data);

            lblStatus.Text = response;
            responseMsg();
            tampilData();
            totalMhs();
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            mhs.nim = tbNIM.Text;

            var data = JsonConvert.SerializeObject(mhs);
            var deletedata = new WebClient();
            deletedata.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            string response = deletedata.UploadString(baseUrl + "DeleteMahasiswa/" + tbNIM.Text, data);

            lblStatus.Text = response;
            responseMsg();
            tampilData();
            totalMhs();
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
            string nim = tbCari.Text;
            if (nim == null || nim == "")
            {
                dGVDataMhs.DataSource = data;
            }
            else
            {
                var item = data.Where(x => x.nim == tbCari.Text).ToList();

                dGVDataMhs.DataSource = item;
            }
        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

        }

        private void btClear_Click_1(object sender, EventArgs e)
        {
            tbNIM.Clear();
            tbNama.Clear();
            tbAngkatan.Clear();
            tbProdi.Clear();
            tbCari.Clear();
            tampilData();
            totalMhs();
        }

        private void dGVDataMhs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNIM.Text = Convert.ToString(dGVDataMhs.Rows[e.RowIndex].Cells[1].Value);
            tbNama.Text = Convert.ToString(dGVDataMhs.Rows[e.RowIndex].Cells[0].Value);
            tbProdi.Text = Convert.ToString(dGVDataMhs.Rows[e.RowIndex].Cells[2].Value);
            tbAngkatan.Text = Convert.ToString(dGVDataMhs.Rows[e.RowIndex].Cells[3].Value);

            btHapus.Enabled = true;
            btUpdate.Enabled = true;
        }
    }
}
