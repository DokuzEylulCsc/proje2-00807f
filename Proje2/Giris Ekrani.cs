using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form ChildForm = new Form();
            ChildForm.Show();
            ChildForm.MdiParent = this;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            // Sayı harici kabul etme https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sayı harici kabul etme https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Harf harici kabul etme 
            e.Handled = char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Harf harici kabul etme
            e.Handled = char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBox3_Click(object sender, EventArgs e)
        {
            if (txtad.Text == "Adınız") txtad.Text = ""; //placeholder clear
        }

        private void Txtsoyad_Click(object sender, EventArgs e)
        {
            if (txtsoyad.Text == "Soyadınız") txtsoyad.Text = ""; //placeholder clear
        }

        private void Txttel_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txttel_Click(object sender, EventArgs e)
        { 
            if (txttel.Text == "Telefon Numaranız") txttel.Text = ""; //placeholder clear
        }

        private void Txtyas_Click(object sender, EventArgs e)
        {
            if (txtyas.Text == "Yaşınız") txtyas.Text = ""; //placeholder clear
        }

        private void Btnuyelik_Click(object sender, EventArgs e)
        {
            //hata yakalama
            if (txtad.Text == "" || txtparola.Text == "" || txtyas.Text == "" || txttel.Text == ""|| txtad.Text == "Adınız" || txtparola.Text == "Parolanız" || txtyas.Text == "Yaşınız" || txttel.Text == "Telefon Numaranız" || txtsoyad.Text==""|| txtsoyad.Text == "Soyadınız") MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun"); 
            else
            {
                //kayıt oluşturma işlemleri
            }
        }

        private void Txtparola_Click(object sender, EventArgs e)
        {
            if (txtparola.Text == "Parolanız") txtparola.Text = ""; //placeholder clear
            if (txtparola.Text != "Parolanız") txtparola.PasswordChar = '*'; //parola gizleme
        }
    }
}
