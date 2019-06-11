using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proje2
{
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FileOp.filewrite();
            Application.Exit();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

   
        private void Txttel_Click(object sender, EventArgs e)
        {

            if (txttel.Text == "Fiyat") txttel.Text = ""; //placeholder clear
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (koy.Checked)
            {
                koyfactory factory = new koyfactory();
                SystemControl.currentadmin.CreateOtel(factory, Otsehir.Text, Otad.Text, Convert.ToInt32(Otyildiz.Text));                

            }
            else if(Butik.Checked)
            {
                butfactory factory = new butfactory();
                SystemControl.currentadmin.CreateOtel(factory, Otsehir.Text, Otad.Text, Convert.ToInt32(Otyildiz.Text));
            }
            else if(pansiyon.Checked)
            {
                pansfactory factory = new pansfactory();
                SystemControl.currentadmin.CreateOtel(factory, Otsehir.Text, Otad.Text, Convert.ToInt32(Otyildiz.Text));
            }
            else
            {
                //no check error
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SystemControl.currentadmin.DelUser(textBox4.Text);
        }
    }
}
