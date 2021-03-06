﻿using System;
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
            updateinfo();
            
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FileOp.filewrite();//cikista veriyi dosyaya yazdir
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
            updateinfo();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            SystemControl.currentadmin.DelUser(textBox4.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            otel selected = SystemControl.Otellist.Find(x => x.Otelname == listBox1.SelectedItem);
            SystemControl.currentadmin.AddRoom(selected,selected.Odalist[selected.Odalist.Count - 1].Room_no + 1,Convert.ToInt32(cmbbxyatakcount.SelectedItem.ToString()),cmbbxodagenislik.SelectedItem.ToString(),checkBox1.Checked,checkBox3.Checked,checkBox2.Checked);
            updateinfo();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            otel selected = SystemControl.Otellist.Find(x => x.Otelname == listBox1.SelectedItem);
            label18.Text = selected.Type + " - " + selected.Star.ToString() + " yildiz" + " sehir: " + selected.City;
        }

        void updateinfo()
        {
            //islemlerden sonra bilgileri yenile
            listBox1.Items.Clear();
            Oteller.Items.Clear();
            int dolu = 0;
            int bos = 0;
            foreach (otel i in SystemControl.Otellist)
            {
                

                listBox1.Items.Add(i.Otelname);//acilista otel listesi hazirla
                Oteller.Items.Add(i.Otelname);
                foreach (Oda o in i.Odalist)
                {
                    /*if (o.Reserved)
                    {
                        dolu++;
                        lstbxdoluoda.Items.Add(i.Otelname + " " + o.Room_no);
                    }
                    else
                    {
                        bos++;
                        lstbxbosoda.Items.Add(i.Otelname + " " + o.Room_no);
                    }*/
                }
                txtbxdoluodasayisi.Text = dolu.ToString();
                txtbxbosodasayisi.Text = bos.ToString();
            }
        }

        private void Otyildiz_TextChanged(object sender, EventArgs e)
        {

        }
    }   
}
