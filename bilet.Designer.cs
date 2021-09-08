
namespace WindowsFormsApp1
{
    partial class bilet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bilet));
            this.nereye = new System.Windows.Forms.Label();
            this.cmbNereden = new System.Windows.Forms.ComboBox();
            this.fiyat = new System.Windows.Forms.Label();
            this.nereden = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lstBilgiler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpboxİstikamet = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.tarih = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKayitlar = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rezerveEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOtobus = new System.Windows.Forms.Label();
            this.cmbOtobus = new System.Windows.Forms.ComboBox();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.msktxtTC = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.msktxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.soyisim = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.Label();
            this.grpboxİstikamet.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nereye
            // 
            this.nereye.AutoSize = true;
            this.nereye.BackColor = System.Drawing.Color.Transparent;
            this.nereye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nereye.ForeColor = System.Drawing.Color.White;
            this.nereye.Location = new System.Drawing.Point(20, 78);
            this.nereye.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nereye.Name = "nereye";
            this.nereye.Size = new System.Drawing.Size(55, 18);
            this.nereye.TabIndex = 14;
            this.nereye.Text = "Nereye";
            // 
            // cmbNereden
            // 
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "K.maraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cmbNereden.Location = new System.Drawing.Point(87, 33);
            this.cmbNereden.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(238, 24);
            this.cmbNereden.TabIndex = 13;
            // 
            // fiyat
            // 
            this.fiyat.AutoSize = true;
            this.fiyat.BackColor = System.Drawing.Color.Transparent;
            this.fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyat.ForeColor = System.Drawing.Color.White;
            this.fiyat.Location = new System.Drawing.Point(446, 547);
            this.fiyat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(39, 18);
            this.fiyat.TabIndex = 64;
            this.fiyat.Text = "Fiyat";
            // 
            // nereden
            // 
            this.nereden.AutoSize = true;
            this.nereden.BackColor = System.Drawing.Color.Transparent;
            this.nereden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nereden.ForeColor = System.Drawing.Color.White;
            this.nereden.Location = new System.Drawing.Point(11, 34);
            this.nereden.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nereden.Name = "nereden";
            this.nereden.Size = new System.Drawing.Size(64, 18);
            this.nereden.TabIndex = 12;
            this.nereden.Text = "Nereden";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(497, 505);
            this.dtpTarih.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(240, 22);
            this.dtpTarih.TabIndex = 62;
            // 
            // lstBilgiler
            // 
            this.lstBilgiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lstBilgiler.GridLines = true;
            this.lstBilgiler.HideSelection = false;
            this.lstBilgiler.Location = new System.Drawing.Point(773, 72);
            this.lstBilgiler.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lstBilgiler.Name = "lstBilgiler";
            this.lstBilgiler.Size = new System.Drawing.Size(939, 682);
            this.lstBilgiler.TabIndex = 69;
            this.lstBilgiler.UseCompatibleStateImageBehavior = false;
            this.lstBilgiler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TC No";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İsim";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyisim";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cinsiyet";
            this.columnHeader5.Width = 59;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nereden";
            this.columnHeader6.Width = 65;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nereye";
            this.columnHeader7.Width = 63;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 8;
            this.columnHeader8.Text = "Koltuk No";
            this.columnHeader8.Width = 50;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 9;
            this.columnHeader9.Text = "Tarih";
            this.columnHeader9.Width = 65;
            // 
            // columnHeader10
            // 
            this.columnHeader10.DisplayIndex = 10;
            this.columnHeader10.Text = "Fiyat";
            this.columnHeader10.Width = 42;
            // 
            // columnHeader11
            // 
            this.columnHeader11.DisplayIndex = 7;
            this.columnHeader11.Text = "Otobüs";
            this.columnHeader11.Width = 57;
            // 
            // grpboxİstikamet
            // 
            this.grpboxİstikamet.BackColor = System.Drawing.Color.Transparent;
            this.grpboxİstikamet.Controls.Add(this.comboBox1);
            this.grpboxİstikamet.Controls.Add(this.cmbNereye);
            this.grpboxİstikamet.Controls.Add(this.nereye);
            this.grpboxİstikamet.Controls.Add(this.nereden);
            this.grpboxİstikamet.Controls.Add(this.cmbNereden);
            this.grpboxİstikamet.ForeColor = System.Drawing.Color.White;
            this.grpboxİstikamet.Location = new System.Drawing.Point(410, 350);
            this.grpboxİstikamet.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.grpboxİstikamet.Name = "grpboxİstikamet";
            this.grpboxİstikamet.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.grpboxİstikamet.Size = new System.Drawing.Size(327, 130);
            this.grpboxİstikamet.TabIndex = 59;
            this.grpboxİstikamet.TabStop = false;
            this.grpboxİstikamet.Text = "İSTİKAMET";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Adan",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "K.maraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.comboBox1.Location = new System.Drawing.Point(123, 136);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // cmbNereye
            // 
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "K.maraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cmbNereye.Location = new System.Drawing.Point(87, 78);
            this.cmbNereye.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(239, 24);
            this.cmbNereye.TabIndex = 15;
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.BackColor = System.Drawing.Color.Transparent;
            this.tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih.ForeColor = System.Drawing.Color.White;
            this.tarih.Location = new System.Drawing.Point(446, 508);
            this.tarih.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(41, 18);
            this.tarih.TabIndex = 63;
            this.tarih.Text = "Tarih";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.Location = new System.Drawing.Point(449, 702);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(288, 52);
            this.btnSil.TabIndex = 68;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKayitlar
            // 
            this.btnKayitlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKayitlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitlar.Image = ((System.Drawing.Image)(resources.GetObject("btnKayitlar.Image")));
            this.btnKayitlar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKayitlar.Location = new System.Drawing.Point(449, 623);
            this.btnKayitlar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnKayitlar.Name = "btnKayitlar";
            this.btnKayitlar.Size = new System.Drawing.Size(288, 52);
            this.btnKayitlar.TabIndex = 67;
            this.btnKayitlar.Text = "KAYITLAR";
            this.btnKayitlar.UseVisualStyleBackColor = true;
            this.btnKayitlar.Click += new System.EventHandler(this.btnKayitlar_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(497, 546);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(240, 22);
            this.txtFiyat.TabIndex = 70;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezerveEtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 28);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // rezerveEtToolStripMenuItem
            // 
            this.rezerveEtToolStripMenuItem.Name = "rezerveEtToolStripMenuItem";
            this.rezerveEtToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.rezerveEtToolStripMenuItem.Text = "Rezerve Et";
            this.rezerveEtToolStripMenuItem.Click += new System.EventHandler(this.rezerveEtToolStripMenuItem_Click);
            // 
            // lblOtobus
            // 
            this.lblOtobus.AutoSize = true;
            this.lblOtobus.BackColor = System.Drawing.Color.Transparent;
            this.lblOtobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOtobus.ForeColor = System.Drawing.Color.White;
            this.lblOtobus.Location = new System.Drawing.Point(428, 76);
            this.lblOtobus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOtobus.Name = "lblOtobus";
            this.lblOtobus.Size = new System.Drawing.Size(57, 18);
            this.lblOtobus.TabIndex = 16;
            this.lblOtobus.Text = "Otobüs";
            // 
            // cmbOtobus
            // 
            this.cmbOtobus.FormattingEnabled = true;
            this.cmbOtobus.Items.AddRange(new object[] {
            "Travego",
            "Setra",
            "Neoplan"});
            this.cmbOtobus.Location = new System.Drawing.Point(497, 72);
            this.cmbOtobus.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbOtobus.Name = "cmbOtobus";
            this.cmbOtobus.Size = new System.Drawing.Size(238, 24);
            this.cmbOtobus.TabIndex = 17;
            this.cmbOtobus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(497, 160);
            this.txtİsim.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(239, 22);
            this.txtİsim.TabIndex = 79;
            // 
            // msktxtTC
            // 
            this.msktxtTC.Location = new System.Drawing.Point(496, 116);
            this.msktxtTC.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.msktxtTC.Mask = "00000000000";
            this.msktxtTC.Name = "msktxtTC";
            this.msktxtTC.Size = new System.Drawing.Size(239, 22);
            this.msktxtTC.TabIndex = 78;
            this.msktxtTC.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(425, 305);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 77;
            this.label5.Text = "Cinsiyet";
            // 
            // telefon
            // 
            this.telefon.AutoSize = true;
            this.telefon.BackColor = System.Drawing.Color.Transparent;
            this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefon.ForeColor = System.Drawing.Color.White;
            this.telefon.Location = new System.Drawing.Point(428, 258);
            this.telefon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(57, 18);
            this.telefon.TabIndex = 76;
            this.telefon.Text = "Telefon";
            // 
            // tc
            // 
            this.tc.AutoSize = true;
            this.tc.BackColor = System.Drawing.Color.Transparent;
            this.tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc.ForeColor = System.Drawing.Color.White;
            this.tc.Location = new System.Drawing.Point(389, 120);
            this.tc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(96, 18);
            this.tc.TabIndex = 73;
            this.tc.Text = "TC Kimlik No";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(496, 301);
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(239, 24);
            this.cmbCinsiyet.TabIndex = 82;
            // 
            // msktxtTelefon
            // 
            this.msktxtTelefon.Location = new System.Drawing.Point(497, 254);
            this.msktxtTelefon.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.msktxtTelefon.Mask = "(999) 000-0000";
            this.msktxtTelefon.Name = "msktxtTelefon";
            this.msktxtTelefon.Size = new System.Drawing.Size(238, 22);
            this.msktxtTelefon.TabIndex = 81;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(497, 209);
            this.txtSoyisim.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(239, 22);
            this.txtSoyisim.TabIndex = 80;
            // 
            // soyisim
            // 
            this.soyisim.AutoSize = true;
            this.soyisim.BackColor = System.Drawing.Color.Transparent;
            this.soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyisim.ForeColor = System.Drawing.Color.White;
            this.soyisim.Location = new System.Drawing.Point(424, 213);
            this.soyisim.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.soyisim.Name = "soyisim";
            this.soyisim.Size = new System.Drawing.Size(61, 18);
            this.soyisim.TabIndex = 75;
            this.soyisim.Text = "Soyisim";
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.BackColor = System.Drawing.Color.Transparent;
            this.isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim.ForeColor = System.Drawing.Color.White;
            this.isim.Location = new System.Drawing.Point(450, 164);
            this.isim.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(35, 18);
            this.isim.TabIndex = 74;
            this.isim.Text = "İsim";
            // 
            // bilet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1758, 882);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.msktxtTC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.msktxtTelefon);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.soyisim);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.lblOtobus);
            this.Controls.Add(this.cmbOtobus);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.lstBilgiler);
            this.Controls.Add(this.grpboxİstikamet);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKayitlar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "bilet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilet Kesme";
            this.Load += new System.EventHandler(this.bilet_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Koltuk_MouseDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Koltuk_MouseDown);
            this.grpboxİstikamet.ResumeLayout(false);
            this.grpboxİstikamet.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nereye;
        private System.Windows.Forms.ComboBox cmbNereden;
        private System.Windows.Forms.Label fiyat;
        private System.Windows.Forms.Label nereden;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ListView lstBilgiler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.GroupBox grpboxİstikamet;
        private System.Windows.Forms.ComboBox cmbNereye;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKayitlar;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezerveEtToolStripMenuItem;
        private System.Windows.Forms.Label lblOtobus;
        private System.Windows.Forms.ComboBox cmbOtobus;
        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.MaskedTextBox msktxtTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label telefon;
        private System.Windows.Forms.Label tc;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.MaskedTextBox msktxtTelefon;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label soyisim;
        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}