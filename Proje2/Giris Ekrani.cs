using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Proje2
{
    public partial class frmgiris : Form
    {
       

    public frmgiris()
        {
            InitializeComponent();
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }
        frmkullanici fr1;
        public void Button1_Click(object sender, EventArgs e) //giris butonu datada sorgu yapılarak girişe izin verilecek
        {

            if (SystemControl.Userlist.Find(x => x.Username == textBox2.Text) != null)
            {
                Kullanici founduser = SystemControl.Userlist.Find(x => x.Username == textBox2.Text);

                using (SHA512 shaM = new SHA512Managed())
                {
                    if(BitConverter.ToString(shaM.ComputeHash(Encoding.UTF8.GetBytes(textBox1.Text))).Replace("-", "") == founduser.Pass_hash)
                    {
                        Console.WriteLine(founduser.GetType().ToString());
                        if(founduser.GetType().ToString() == "Proje2.admin")
                        {
                            if (fr3 == null)
                            {
                                fr3 = new frmadmin();
                                fr3.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            if (fr1 == null)
                            {
                                fr1 = new frmkullanici();
                                fr1.Show();
                                this.Hide();
                            }
                        }
                    }
                    else
                    {
                        //parola yalnıs hata
                    }                    
                }          
            }
            else
            {
                //kullanıcı yok hata
            }



        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            // Sayı harici kabul etme https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers

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
            if (txtkadı.Text == "Yaşınız") txtkadı.Text = ""; //placeholder clear
        }

        private void Btnuyelik_Click(object sender, EventArgs e)
        {
            //hata yakalama
            if (txtad.Text == "" || txtparola.Text == "" || txtkadı.Text == "" || txttel.Text == ""|| txtad.Text == "Adınız" || txtparola.Text == "Parolanız" || txtkadı.Text == "Kullanıcı Adı" || txttel.Text == "Telefon Numaranız" || txtsoyad.Text==""|| txtsoyad.Text == "Soyadınız") MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun"); 
            else
            {
                if (SystemControl.Userlist.Find(x => x.Username == txtkadı.Text) != null)
                {
                    SystemControl.Userlist.Add(new musteri(txtkadı.Text, txttel.Text, txtkadı.Text, txtsoyad.Text, txtparola.Text));
                }

                else
                {
                    //ayni username var
                }
                    
                //kayıt oluşturma işlemleri
            }
        }

        private void Txtparola_Click(object sender, EventArgs e)
        {
            if (txtparola.Text == "Parolanız") txtparola.Text = ""; //placeholder clear
            //if (txtparola.Text != "Parolanız") txtparola.PasswordChar = '*'; //parola gizleme
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            FileOp.filewrite();
            Application.Exit();
        }
        frmadmin fr3;
 
    }
}
