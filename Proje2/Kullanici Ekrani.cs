using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Proje2
{
    public partial class frmkullanici : Form
    {
        public frmkullanici()
        {

            InitializeComponent();
            txtad.Text = SystemControl.currentmusteri.F_name;
            txtsoyad.Text = SystemControl.currentmusteri.L_name;
            txttel.Text = SystemControl.currentmusteri.Tel_no;
            txtkadı.Text = SystemControl.currentmusteri.Username;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            FileOp.filewrite();
            this.Close();
            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
          
            lblotelbulundu.Show();
            chclstbxoteller.Show();
            lbluyari.Show();
            lblotelgorunecek.Hide();
            lblcikis.Show();
            datepicgiris.Show();
            datepickcikis.Show();
            btnrezervasyon.Show();
            lblgirst.Show();
          
        }

        private void Lblotelbulundu_Click(object sender, EventArgs e)
        {
          
        }

        private void Lstbxoteller_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            lblotelbulundu.Hide();
            chclstbxoteller.Hide();
            lbluyari.Hide();
            lblotelgorunecek.Show();
         
           
        }

        private void Lblcikis_Click(object sender, EventArgs e)
        {

        }

        private void Lblotelgorunecek_Click(object sender, EventArgs e)
        {

        }

        private void Txtsehir_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clstbxoteltur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Clsbxodatur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clbxekstralar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cmbbxyatakcount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cmbbxodagenislik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Chclstbxoteller_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lbluyari_Click(object sender, EventArgs e)
        {

        }


        private void Datepicgiris_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Datepickcikis_ValueChanged(object sender, EventArgs e)
        {

        }



        private void TabPage1_Click(object sender, EventArgs e)
        {
            tabPage1.Text = @"Rezervasyon Yap";
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void btnrezervasyon_Click(object sender, EventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SystemControl.currentmusteri.F_name = txtad.Text;
            SystemControl.currentmusteri.L_name = txtsoyad.Text;
            SystemControl.currentmusteri.Tel_no = txttel.Text;
            SystemControl.currentmusteri.Username = txtkadı.Text;

            using (SHA512 shaM = new SHA512Managed())
            {
                SystemControl.currentmusteri.Pass_hash = BitConverter.ToString(shaM.ComputeHash(Encoding.UTF8.GetBytes(txtparola.Text))).Replace("-", "");
            }

           /* SystemControl.Userlist.Find(x => x.Id == SystemControl.currentmusteri.Id) = SystemControl.currentmusteri;
            SystemControl.Userlist.*/

        }
    }
}
