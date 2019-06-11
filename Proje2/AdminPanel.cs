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
            Application.Exit();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Txttel_Click(object sender, EventArgs e)
        {

            if (txttel.Text == "Fiyat") txttel.Text = ""; //placeholder clear
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
