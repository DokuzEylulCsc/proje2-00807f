namespace Proje2
{
    partial class frmkullanici
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsehir = new System.Windows.Forms.TextBox();
            this.clstbxoteltur = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clsbxodatur = new System.Windows.Forms.CheckedListBox();
            this.clbxekstralar = new System.Windows.Forms.CheckedListBox();
            this.cmbbxyatakcount = new System.Windows.Forms.ComboBox();
            this.cmbbxodagenislik = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.lblotelbulundu = new System.Windows.Forms.Label();
            this.chclstbxoteller = new System.Windows.Forms.CheckedListBox();
            this.lbluyari = new System.Windows.Forms.Label();
            this.lblotelgorunecek = new System.Windows.Forms.Label();
            this.btnrez = new System.Windows.Forms.Button();
            this.datepicgiris = new System.Windows.Forms.DateTimePicker();
            this.datepickcikis = new System.Windows.Forms.DateTimePicker();
            this.lblgirist = new System.Windows.Forms.Label();
            this.lblcikis = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnrezervasyon = new System.Windows.Forms.Button();
            this.lblgirst = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtkadı = new System.Windows.Forms.TextBox();
            this.txtparola = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "DEÜ-CSC El Turistiko A.Ş. ";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(815, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Çıkış Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(208, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(493, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Size En Uygun Oteli Bulun ve Fiyatları Karşılaştırın";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // txtsehir
            // 
            this.txtsehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsehir.Location = new System.Drawing.Point(141, 85);
            this.txtsehir.Name = "txtsehir";
            this.txtsehir.Size = new System.Drawing.Size(125, 26);
            this.txtsehir.TabIndex = 10;
            this.txtsehir.Text = "Örn. İzmir";
            this.txtsehir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsehir.TextChanged += new System.EventHandler(this.Txtsehir_TextChanged);
            // 
            // clstbxoteltur
            // 
            this.clstbxoteltur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clstbxoteltur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clstbxoteltur.FormattingEnabled = true;
            this.clstbxoteltur.Items.AddRange(new object[] {
            "Tatil Köyü",
            "Butik Otel",
            "Pansiyon"});
            this.clstbxoteltur.Location = new System.Drawing.Point(285, 71);
            this.clstbxoteltur.Name = "clstbxoteltur";
            this.clstbxoteltur.Size = new System.Drawing.Size(105, 76);
            this.clstbxoteltur.TabIndex = 11;
            this.clstbxoteltur.SelectedIndexChanged += new System.EventHandler(this.Clstbxoteltur_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Proje2.Properties.Resources.facebookb_m;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(932, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // clsbxodatur
            // 
            this.clsbxodatur.FormattingEnabled = true;
            this.clsbxodatur.Items.AddRange(new object[] {
            "Standart Oda",
            "Kral Dairesi"});
            this.clsbxodatur.Location = new System.Drawing.Point(396, 116);
            this.clsbxodatur.Name = "clsbxodatur";
            this.clsbxodatur.Size = new System.Drawing.Size(105, 34);
            this.clsbxodatur.TabIndex = 12;
            this.clsbxodatur.SelectedIndexChanged += new System.EventHandler(this.Clsbxodatur_SelectedIndexChanged);
            // 
            // clbxekstralar
            // 
            this.clbxekstralar.FormattingEnabled = true;
            this.clbxekstralar.Items.AddRange(new object[] {
            "Deniz Manzaralı",
            "Klimalı"});
            this.clbxekstralar.Location = new System.Drawing.Point(396, 71);
            this.clbxekstralar.Name = "clbxekstralar";
            this.clbxekstralar.Size = new System.Drawing.Size(105, 34);
            this.clbxekstralar.TabIndex = 13;
            this.clbxekstralar.SelectedIndexChanged += new System.EventHandler(this.Clbxekstralar_SelectedIndexChanged);
            // 
            // cmbbxyatakcount
            // 
            this.cmbbxyatakcount.FormattingEnabled = true;
            this.cmbbxyatakcount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbbxyatakcount.Location = new System.Drawing.Point(517, 116);
            this.cmbbxyatakcount.Name = "cmbbxyatakcount";
            this.cmbbxyatakcount.Size = new System.Drawing.Size(105, 21);
            this.cmbbxyatakcount.TabIndex = 14;
            this.cmbbxyatakcount.Text = "Yatak Sayısı";
            this.cmbbxyatakcount.SelectedIndexChanged += new System.EventHandler(this.Cmbbxyatakcount_SelectedIndexChanged);
            // 
            // cmbbxodagenislik
            // 
            this.cmbbxodagenislik.FormattingEnabled = true;
            this.cmbbxodagenislik.Location = new System.Drawing.Point(517, 71);
            this.cmbbxodagenislik.Name = "cmbbxodagenislik";
            this.cmbbxodagenislik.Size = new System.Drawing.Size(105, 21);
            this.cmbbxodagenislik.TabIndex = 15;
            this.cmbbxodagenislik.Text = "Oda Genişliği";
            this.cmbbxodagenislik.SelectedIndexChanged += new System.EventHandler(this.Cmbbxodagenislik_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(665, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 55);
            this.button4.TabIndex = 16;
            this.button4.Text = "Otelleri Listele";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // lblotelbulundu
            // 
            this.lblotelbulundu.AutoSize = true;
            this.lblotelbulundu.BackColor = System.Drawing.Color.Transparent;
            this.lblotelbulundu.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblotelbulundu.ForeColor = System.Drawing.Color.DarkRed;
            this.lblotelbulundu.Location = new System.Drawing.Point(285, 176);
            this.lblotelbulundu.Name = "lblotelbulundu";
            this.lblotelbulundu.Size = new System.Drawing.Size(337, 26);
            this.lblotelbulundu.TabIndex = 19;
            this.lblotelbulundu.Text = "İşte Sizin İçin Bulduğumuz Oteller";
            this.lblotelbulundu.Visible = false;
            this.lblotelbulundu.Click += new System.EventHandler(this.Lblotelbulundu_Click);
            // 
            // chclstbxoteller
            // 
            this.chclstbxoteller.FormattingEnabled = true;
            this.chclstbxoteller.Location = new System.Drawing.Point(37, 231);
            this.chclstbxoteller.Name = "chclstbxoteller";
            this.chclstbxoteller.Size = new System.Drawing.Size(539, 154);
            this.chclstbxoteller.TabIndex = 20;
            this.chclstbxoteller.Visible = false;
            this.chclstbxoteller.SelectedIndexChanged += new System.EventHandler(this.Chclstbxoteller_SelectedIndexChanged);
            // 
            // lbluyari
            // 
            this.lbluyari.AutoSize = true;
            this.lbluyari.BackColor = System.Drawing.Color.Transparent;
            this.lbluyari.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbluyari.ForeColor = System.Drawing.Color.Black;
            this.lbluyari.Location = new System.Drawing.Point(95, 399);
            this.lbluyari.Name = "lbluyari";
            this.lbluyari.Size = new System.Drawing.Size(667, 16);
            this.lbluyari.TabIndex = 21;
            this.lbluyari.Text = "*Lütfen Rezervasyon Yapacağınız Oteli ve Giriş Çıkış Yapacağınız Tarihi Seçin Ard" +
    "ından Rezervasyon Yap Butonuna Tıklayın";
            this.lbluyari.Visible = false;
            this.lbluyari.Click += new System.EventHandler(this.Lbluyari_Click);
            // 
            // lblotelgorunecek
            // 
            this.lblotelgorunecek.AutoSize = true;
            this.lblotelgorunecek.BackColor = System.Drawing.Color.Transparent;
            this.lblotelgorunecek.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblotelgorunecek.ForeColor = System.Drawing.Color.DarkRed;
            this.lblotelgorunecek.Location = new System.Drawing.Point(190, 189);
            this.lblotelgorunecek.Name = "lblotelgorunecek";
            this.lblotelgorunecek.Size = new System.Drawing.Size(556, 39);
            this.lblotelgorunecek.TabIndex = 22;
            this.lblotelgorunecek.Text = "Bulunan Oteller Burada Gözükecek :)";
            this.lblotelgorunecek.Click += new System.EventHandler(this.Lblotelgorunecek_Click);
            // 
            // btnrez
            // 
            this.btnrez.Location = new System.Drawing.Point(1473, 431);
            this.btnrez.Name = "btnrez";
            this.btnrez.Size = new System.Drawing.Size(104, 46);
            this.btnrez.TabIndex = 23;
            this.btnrez.Text = "Rezervasyon Yap";
            this.btnrez.UseVisualStyleBackColor = true;
            this.btnrez.Visible = false;
            // 
            // datepicgiris
            // 
            this.datepicgiris.Location = new System.Drawing.Point(599, 273);
            this.datepicgiris.Name = "datepicgiris";
            this.datepicgiris.Size = new System.Drawing.Size(152, 20);
            this.datepicgiris.TabIndex = 25;
            this.datepicgiris.Visible = false;
            this.datepicgiris.ValueChanged += new System.EventHandler(this.Datepicgiris_ValueChanged);
            // 
            // datepickcikis
            // 
            this.datepickcikis.Location = new System.Drawing.Point(599, 338);
            this.datepickcikis.Name = "datepickcikis";
            this.datepickcikis.Size = new System.Drawing.Size(152, 20);
            this.datepickcikis.TabIndex = 26;
            this.datepickcikis.Visible = false;
            this.datepickcikis.ValueChanged += new System.EventHandler(this.Datepickcikis_ValueChanged);
            // 
            // lblgirist
            // 
            this.lblgirist.AutoSize = true;
            this.lblgirist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgirist.Location = new System.Drawing.Point(1311, 402);
            this.lblgirist.Name = "lblgirist";
            this.lblgirist.Size = new System.Drawing.Size(72, 16);
            this.lblgirist.TabIndex = 27;
            this.lblgirist.Text = "Giriş Tarihi";
            this.lblgirist.Visible = false;
            // 
            // lblcikis
            // 
            this.lblcikis.AutoSize = true;
            this.lblcikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcikis.Location = new System.Drawing.Point(636, 319);
            this.lblcikis.Name = "lblcikis";
            this.lblcikis.Size = new System.Drawing.Size(74, 16);
            this.lblcikis.TabIndex = 27;
            this.lblcikis.Text = "Çıkış Tarihi";
            this.lblcikis.Visible = false;
            this.lblcikis.Click += new System.EventHandler(this.Lblcikis_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(899, 446);
            this.tabControl1.TabIndex = 28;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnrezervasyon);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lbluyari);
            this.tabPage1.Controls.Add(this.lblgirst);
            this.tabPage1.Controls.Add(this.lblcikis);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.lblgirist);
            this.tabPage1.Controls.Add(this.txtsehir);
            this.tabPage1.Controls.Add(this.datepickcikis);
            this.tabPage1.Controls.Add(this.clstbxoteltur);
            this.tabPage1.Controls.Add(this.datepicgiris);
            this.tabPage1.Controls.Add(this.clsbxodatur);
            this.tabPage1.Controls.Add(this.btnrez);
            this.tabPage1.Controls.Add(this.clbxekstralar);
            this.tabPage1.Controls.Add(this.lblotelgorunecek);
            this.tabPage1.Controls.Add(this.cmbbxyatakcount);
            this.tabPage1.Controls.Add(this.cmbbxodagenislik);
            this.tabPage1.Controls.Add(this.chclstbxoteller);
            this.tabPage1.Controls.Add(this.lblotelbulundu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(891, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rezervasyon Yap";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // btnrezervasyon
            // 
            this.btnrezervasyon.Location = new System.Drawing.Point(779, 285);
            this.btnrezervasyon.Name = "btnrezervasyon";
            this.btnrezervasyon.Size = new System.Drawing.Size(87, 50);
            this.btnrezervasyon.TabIndex = 28;
            this.btnrezervasyon.Text = "Rezervasyon Yap";
            this.btnrezervasyon.UseVisualStyleBackColor = true;
            this.btnrezervasyon.Visible = false;
            // 
            // lblgirst
            // 
            this.lblgirst.AutoSize = true;
            this.lblgirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgirst.Location = new System.Drawing.Point(630, 254);
            this.lblgirst.Name = "lblgirst";
            this.lblgirst.Size = new System.Drawing.Size(72, 16);
            this.lblgirst.TabIndex = 27;
            this.lblgirst.Text = "Giriş Tarihi";
            this.lblgirst.Visible = false;
            this.lblgirst.Click += new System.EventHandler(this.Lblcikis_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.checkedListBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(891, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rezervasyonlarım";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnguncelle);
            this.tabPage3.Controls.Add(this.txtsoyad);
            this.tabPage3.Controls.Add(this.txttel);
            this.tabPage3.Controls.Add(this.txtkadı);
            this.tabPage3.Controls.Add(this.txtparola);
            this.tabPage3.Controls.Add(this.txtad);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(891, 420);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hesap Ayarlarım";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(452, 123);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(375, 124);
            this.checkedListBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(49, 123);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(355, 134);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(111, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Geçmiş Rezervasyonlarım";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(537, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Güncel Rezervasyonlarım";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "Seçili Rezervasyonu İptal Et";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kullanıcı adı ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "İsim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Soyisim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(323, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 31);
            this.label8.TabIndex = 4;
            this.label8.Text = "Kullanıcı Bilgileri";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Parola";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Telefon Numarası";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.Location = new System.Drawing.Point(468, 183);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(110, 22);
            this.txtsoyad.TabIndex = 11;
            this.txtsoyad.Text = "Yeni Soyad";
            this.txtsoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttel.Location = new System.Drawing.Point(468, 281);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(153, 22);
            this.txttel.TabIndex = 12;
            this.txttel.Text = "Yeni Telefon Numarası";
            this.txttel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtkadı
            // 
            this.txtkadı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkadı.Location = new System.Drawing.Point(468, 218);
            this.txtkadı.Name = "txtkadı";
            this.txtkadı.Size = new System.Drawing.Size(110, 22);
            this.txtkadı.TabIndex = 13;
            this.txtkadı.Text = "Yeni Kullanıcı Adı";
            this.txtkadı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtparola
            // 
            this.txtparola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtparola.Location = new System.Drawing.Point(468, 249);
            this.txtparola.Name = "txtparola";
            this.txtparola.Size = new System.Drawing.Size(110, 22);
            this.txtparola.TabIndex = 14;
            this.txtparola.Text = "Yeni Parola";
            this.txtparola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(468, 147);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(110, 22);
            this.txtad.TabIndex = 15;
            this.txtad.Text = "Yeni AD";
            this.txtad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(383, 346);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(111, 44);
            this.btnguncelle.TabIndex = 16;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            // 
            // frmkullanici
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(923, 512);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.IsMdiContainer = true;
            this.Name = "frmkullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsehir;
        private System.Windows.Forms.CheckedListBox clstbxoteltur;
        private System.Windows.Forms.CheckedListBox clsbxodatur;
        private System.Windows.Forms.CheckedListBox clbxekstralar;
        private System.Windows.Forms.ComboBox cmbbxyatakcount;
        private System.Windows.Forms.ComboBox cmbbxodagenislik;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblotelbulundu;
        private System.Windows.Forms.CheckedListBox chclstbxoteller;
        private System.Windows.Forms.Label lbluyari;
        private System.Windows.Forms.Label lblotelgorunecek;
        private System.Windows.Forms.Button btnrez;
        private System.Windows.Forms.DateTimePicker datepicgiris;
        private System.Windows.Forms.DateTimePicker datepickcikis;
        private System.Windows.Forms.Label lblgirist;
        private System.Windows.Forms.Label lblcikis;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblgirst;
        private System.Windows.Forms.Button btnrezervasyon;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtkadı;
        private System.Windows.Forms.TextBox txtparola;
        private System.Windows.Forms.TextBox txtad;
    }
}
