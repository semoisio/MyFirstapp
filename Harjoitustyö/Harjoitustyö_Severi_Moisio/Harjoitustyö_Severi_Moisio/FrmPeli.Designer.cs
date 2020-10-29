namespace Harjoitustyö_Severi_Moisio
{
    partial class FrmPeli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPeli));
            this.lblPeliaika = new System.Windows.Forms.Label();
            this.tmrPeliaika = new System.Windows.Forms.Timer(this.components);
            this.btnAloita = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblPelialkoi = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblPelipaattyi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEra = new System.Windows.Forms.Label();
            this.btnKelaa = new System.Windows.Forms.Button();
            this.lblEraNum = new System.Windows.Forms.Label();
            this.lblKotijoukkue = new System.Windows.Forms.Label();
            this.lblKotiMaalit = new System.Windows.Forms.Label();
            this.lblVierasMaalit = new System.Windows.Forms.Label();
            this.lblVierasjoukkue = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muokkaaTulostaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.käynnistäPysäytäKelloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nopeutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnPlay = new System.Windows.Forms.ToolStripButton();
            this.tsbtnKelaa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tsbtnLopeta = new System.Windows.Forms.ToolStripButton();
            this.lbVieras = new System.Windows.Forms.ListBox();
            this.lbKoti = new System.Windows.Forms.ListBox();
            this.pnlKotiTehopiste = new System.Windows.Forms.Panel();
            this.btnVahMaali = new System.Windows.Forms.Button();
            this.btnVahSyotto = new System.Windows.Forms.Button();
            this.btnLisSyotto = new System.Windows.Forms.Button();
            this.btnLisMaali = new System.Windows.Forms.Button();
            this.btnPeruPisteet = new System.Windows.Forms.Button();
            this.btnKotiMuokkaa = new System.Windows.Forms.Button();
            this.lblKotiMaali = new System.Windows.Forms.Label();
            this.lblKotiSyotot = new System.Windows.Forms.Label();
            this.tbKotiMaali = new System.Windows.Forms.TextBox();
            this.tbKotiSyotot = new System.Windows.Forms.TextBox();
            this.btnKotiPlus = new System.Windows.Forms.Button();
            this.btnKotiMiinus = new System.Windows.Forms.Button();
            this.btnVierasMiinus = new System.Windows.Forms.Button();
            this.btnVierasPlus = new System.Windows.Forms.Button();
            this.lblKokonaisaika = new System.Windows.Forms.Label();
            this.lblKokaika = new System.Windows.Forms.Label();
            this.btnMaali = new System.Windows.Forms.Button();
            this.pnlKoti = new System.Windows.Forms.Panel();
            this.pnlVieras = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnPeru = new System.Windows.Forms.Button();
            this.lblOhje = new System.Windows.Forms.Label();
            this.lblOhje2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.käynnistäPysäytäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muokkaaTulostaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nopeutaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOhjeMuokkaus = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlKotiTehopiste.SuspendLayout();
            this.pnlKoti.SuspendLayout();
            this.pnlVieras.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPeliaika
            // 
            this.lblPeliaika.AutoSize = true;
            this.lblPeliaika.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeliaika.Location = new System.Drawing.Point(571, 70);
            this.lblPeliaika.Name = "lblPeliaika";
            this.lblPeliaika.Size = new System.Drawing.Size(167, 38);
            this.lblPeliaika.TabIndex = 0;
            this.lblPeliaika.Text = "aika tähän";
            this.toolTip1.SetToolTip(this.lblPeliaika, "Pelikello");
            // 
            // tmrPeliaika
            // 
            this.tmrPeliaika.Interval = 1000;
            this.tmrPeliaika.Tick += new System.EventHandler(this.tmrPeliaika_Tick);
            // 
            // btnAloita
            // 
            this.btnAloita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAloita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAloita.Location = new System.Drawing.Point(938, 68);
            this.btnAloita.Name = "btnAloita";
            this.btnAloita.Size = new System.Drawing.Size(116, 58);
            this.btnAloita.TabIndex = 1;
            this.btnAloita.Text = "Aloita erä";
            this.toolTip1.SetToolTip(this.btnAloita, "Käynnistä/ pysäytä kello");
            this.btnAloita.UseVisualStyleBackColor = true;
            this.btnAloita.Click += new System.EventHandler(this.btnAloita_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblPelialkoi,
            this.tsslblPelipaattyi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 703);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1297, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblPelialkoi
            // 
            this.tsslblPelialkoi.Name = "tsslblPelialkoi";
            this.tsslblPelialkoi.Size = new System.Drawing.Size(25, 20);
            this.tsslblPelialkoi.Text = "  0";
            this.tsslblPelialkoi.Visible = false;
            // 
            // tsslblPelipaattyi
            // 
            this.tsslblPelipaattyi.Name = "tsslblPelipaattyi";
            this.tsslblPelipaattyi.Size = new System.Drawing.Size(25, 20);
            this.tsslblPelipaattyi.Text = "  0";
            this.tsslblPelipaattyi.Visible = false;
            this.tsslblPelipaattyi.TextChanged += new System.EventHandler(this.tsslblPelipaattyi_TextChanged);
            // 
            // lblEra
            // 
            this.lblEra.AutoSize = true;
            this.lblEra.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEra.Location = new System.Drawing.Point(250, 68);
            this.lblEra.Name = "lblEra";
            this.lblEra.Size = new System.Drawing.Size(68, 38);
            this.lblEra.TabIndex = 3;
            this.lblEra.Text = "Erä";
            // 
            // btnKelaa
            // 
            this.btnKelaa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKelaa.Enabled = false;
            this.btnKelaa.Location = new System.Drawing.Point(1060, 76);
            this.btnKelaa.Name = "btnKelaa";
            this.btnKelaa.Size = new System.Drawing.Size(75, 37);
            this.btnKelaa.TabIndex = 4;
            this.btnKelaa.Text = "Nopeuta";
            this.toolTip1.SetToolTip(this.btnKelaa, "Nopeuta pelikelloa");
            this.btnKelaa.UseVisualStyleBackColor = true;
            this.btnKelaa.Click += new System.EventHandler(this.btnKelaa_Click);
            // 
            // lblEraNum
            // 
            this.lblEraNum.AutoSize = true;
            this.lblEraNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEraNum.Location = new System.Drawing.Point(284, 106);
            this.lblEraNum.Name = "lblEraNum";
            this.lblEraNum.Size = new System.Drawing.Size(0, 38);
            this.lblEraNum.TabIndex = 7;
            this.toolTip1.SetToolTip(this.lblEraNum, "Erä numero");
            // 
            // lblKotijoukkue
            // 
            this.lblKotijoukkue.AutoSize = true;
            this.lblKotijoukkue.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKotijoukkue.Location = new System.Drawing.Point(355, 170);
            this.lblKotijoukkue.Name = "lblKotijoukkue";
            this.lblKotijoukkue.Size = new System.Drawing.Size(83, 38);
            this.lblKotijoukkue.TabIndex = 8;
            this.lblKotijoukkue.Text = "KotJ";
            // 
            // lblKotiMaalit
            // 
            this.lblKotiMaalit.AutoSize = true;
            this.lblKotiMaalit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKotiMaalit.Location = new System.Drawing.Point(383, 223);
            this.lblKotiMaalit.Name = "lblKotiMaalit";
            this.lblKotiMaalit.Size = new System.Drawing.Size(93, 38);
            this.lblKotiMaalit.TabIndex = 9;
            this.lblKotiMaalit.Text = "KotM";
            // 
            // lblVierasMaalit
            // 
            this.lblVierasMaalit.AutoSize = true;
            this.lblVierasMaalit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVierasMaalit.Location = new System.Drawing.Point(804, 223);
            this.lblVierasMaalit.Name = "lblVierasMaalit";
            this.lblVierasMaalit.Size = new System.Drawing.Size(132, 38);
            this.lblVierasMaalit.TabIndex = 11;
            this.lblVierasMaalit.Text = "vierasM";
            // 
            // lblVierasjoukkue
            // 
            this.lblVierasjoukkue.AutoSize = true;
            this.lblVierasjoukkue.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVierasjoukkue.Location = new System.Drawing.Point(778, 170);
            this.lblVierasjoukkue.Name = "lblVierasjoukkue";
            this.lblVierasjoukkue.Size = new System.Drawing.Size(92, 38);
            this.lblVierasjoukkue.TabIndex = 10;
            this.lblVierasjoukkue.Text = "VierJ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jepToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1297, 30);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jepToolStripMenuItem
            // 
            this.jepToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muokkaaTulostaToolStripMenuItem,
            this.käynnistäPysäytäKelloToolStripMenuItem,
            this.nopeutaToolStripMenuItem,
            this.lopetaToolStripMenuItem});
            this.jepToolStripMenuItem.Name = "jepToolStripMenuItem";
            this.jepToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.jepToolStripMenuItem.Text = "Tiedosto";
            // 
            // muokkaaTulostaToolStripMenuItem
            // 
            this.muokkaaTulostaToolStripMenuItem.Name = "muokkaaTulostaToolStripMenuItem";
            this.muokkaaTulostaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.muokkaaTulostaToolStripMenuItem.Size = new System.Drawing.Size(337, 26);
            this.muokkaaTulostaToolStripMenuItem.Text = "Muokkaa tulosta";
            this.muokkaaTulostaToolStripMenuItem.Click += new System.EventHandler(this.btnMaali_Click);
            // 
            // käynnistäPysäytäKelloToolStripMenuItem
            // 
            this.käynnistäPysäytäKelloToolStripMenuItem.Name = "käynnistäPysäytäKelloToolStripMenuItem";
            this.käynnistäPysäytäKelloToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.käynnistäPysäytäKelloToolStripMenuItem.Size = new System.Drawing.Size(337, 26);
            this.käynnistäPysäytäKelloToolStripMenuItem.Text = "Käynnistä / pysäytä kello";
            this.käynnistäPysäytäKelloToolStripMenuItem.Click += new System.EventHandler(this.btnAloita_Click);
            // 
            // nopeutaToolStripMenuItem
            // 
            this.nopeutaToolStripMenuItem.Name = "nopeutaToolStripMenuItem";
            this.nopeutaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nopeutaToolStripMenuItem.Size = new System.Drawing.Size(337, 26);
            this.nopeutaToolStripMenuItem.Text = "Nopeuta";
            this.nopeutaToolStripMenuItem.Click += new System.EventHandler(this.btnKelaa_Click);
            // 
            // lopetaToolStripMenuItem
            // 
            this.lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(337, 26);
            this.lopetaToolStripMenuItem.Text = "Lopeta";
            this.lopetaToolStripMenuItem.Click += new System.EventHandler(this.lopetaToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnPlay,
            this.tsbtnKelaa,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.helpToolStripButton,
            this.tsbtnLopeta});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1297, 31);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnPlay
            // 
            this.tsbtnPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPlay.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPlay.Image")));
            this.tsbtnPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPlay.Name = "tsbtnPlay";
            this.tsbtnPlay.Size = new System.Drawing.Size(29, 28);
            this.tsbtnPlay.Text = "Play";
            this.tsbtnPlay.ToolTipText = "Käynnistä/ pysäytä";
            this.tsbtnPlay.Click += new System.EventHandler(this.btnAloita_Click);
            // 
            // tsbtnKelaa
            // 
            this.tsbtnKelaa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnKelaa.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnKelaa.Image")));
            this.tsbtnKelaa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnKelaa.Name = "tsbtnKelaa";
            this.tsbtnKelaa.Size = new System.Drawing.Size(29, 24);
            this.tsbtnKelaa.Text = "Kelaa";
            this.tsbtnKelaa.ToolTipText = "Kelaa";
            this.tsbtnKelaa.Click += new System.EventHandler(this.btnKelaa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Muokkaa";
            this.toolStripButton1.ToolTipText = "Muokkaa tulosta";
            this.toolStripButton1.Click += new System.EventHandler(this.btnMaali_Click);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // tsbtnLopeta
            // 
            this.tsbtnLopeta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLopeta.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLopeta.Image")));
            this.tsbtnLopeta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLopeta.Name = "tsbtnLopeta";
            this.tsbtnLopeta.Size = new System.Drawing.Size(29, 24);
            this.tsbtnLopeta.Text = "Lopeta";
            this.tsbtnLopeta.ToolTipText = "Lopeta";
            this.tsbtnLopeta.Click += new System.EventHandler(this.lopetaToolStripMenuItem_Click);
            // 
            // lbVieras
            // 
            this.lbVieras.FormattingEnabled = true;
            this.lbVieras.ItemHeight = 16;
            this.lbVieras.Location = new System.Drawing.Point(785, 297);
            this.lbVieras.Name = "lbVieras";
            this.lbVieras.Size = new System.Drawing.Size(347, 292);
            this.lbVieras.TabIndex = 15;
            this.toolTip1.SetToolTip(this.lbVieras, "Tuplaklikkaamalla pelaajaa \r\npääsee muokkaamaan pisteitä.\r\n");
            this.lbVieras.DoubleClick += new System.EventHandler(this.lbKoti_DoubleClick);
            // 
            // lbKoti
            // 
            this.lbKoti.FormattingEnabled = true;
            this.lbKoti.ItemHeight = 16;
            this.lbKoti.Location = new System.Drawing.Point(139, 297);
            this.lbKoti.Name = "lbKoti";
            this.lbKoti.Size = new System.Drawing.Size(347, 292);
            this.lbKoti.TabIndex = 26;
            this.toolTip1.SetToolTip(this.lbKoti, "Tuplaklikkaamalla pelaajaa \r\npääsee muokkaamaan pisteitä.");
            this.lbKoti.DoubleClick += new System.EventHandler(this.lbKoti_DoubleClick);
            // 
            // pnlKotiTehopiste
            // 
            this.pnlKotiTehopiste.Controls.Add(this.btnVahMaali);
            this.pnlKotiTehopiste.Controls.Add(this.btnVahSyotto);
            this.pnlKotiTehopiste.Controls.Add(this.btnLisSyotto);
            this.pnlKotiTehopiste.Controls.Add(this.btnLisMaali);
            this.pnlKotiTehopiste.Controls.Add(this.btnPeruPisteet);
            this.pnlKotiTehopiste.Controls.Add(this.btnKotiMuokkaa);
            this.pnlKotiTehopiste.Controls.Add(this.lblKotiMaali);
            this.pnlKotiTehopiste.Controls.Add(this.lblKotiSyotot);
            this.pnlKotiTehopiste.Controls.Add(this.tbKotiMaali);
            this.pnlKotiTehopiste.Controls.Add(this.tbKotiSyotot);
            this.pnlKotiTehopiste.Location = new System.Drawing.Point(492, 297);
            this.pnlKotiTehopiste.Name = "pnlKotiTehopiste";
            this.pnlKotiTehopiste.Size = new System.Drawing.Size(287, 219);
            this.pnlKotiTehopiste.TabIndex = 30;
            this.pnlKotiTehopiste.Visible = false;
            // 
            // btnVahMaali
            // 
            this.btnVahMaali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVahMaali.Location = new System.Drawing.Point(166, 21);
            this.btnVahMaali.Name = "btnVahMaali";
            this.btnVahMaali.Size = new System.Drawing.Size(19, 23);
            this.btnVahMaali.TabIndex = 34;
            this.btnVahMaali.Text = "-";
            this.btnVahMaali.UseVisualStyleBackColor = true;
            this.btnVahMaali.Click += new System.EventHandler(this.btnVahMaali_Click);
            // 
            // btnVahSyotto
            // 
            this.btnVahSyotto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVahSyotto.Location = new System.Drawing.Point(166, 77);
            this.btnVahSyotto.Name = "btnVahSyotto";
            this.btnVahSyotto.Size = new System.Drawing.Size(19, 23);
            this.btnVahSyotto.TabIndex = 33;
            this.btnVahSyotto.Text = "-";
            this.btnVahSyotto.UseVisualStyleBackColor = true;
            this.btnVahSyotto.Click += new System.EventHandler(this.btnVahSyotto_Click);
            // 
            // btnLisSyotto
            // 
            this.btnLisSyotto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLisSyotto.Location = new System.Drawing.Point(70, 76);
            this.btnLisSyotto.Name = "btnLisSyotto";
            this.btnLisSyotto.Size = new System.Drawing.Size(19, 23);
            this.btnLisSyotto.TabIndex = 32;
            this.btnLisSyotto.Text = "+";
            this.btnLisSyotto.UseVisualStyleBackColor = true;
            this.btnLisSyotto.Click += new System.EventHandler(this.btnLisSyotto_Click);
            // 
            // btnLisMaali
            // 
            this.btnLisMaali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLisMaali.Location = new System.Drawing.Point(70, 21);
            this.btnLisMaali.Name = "btnLisMaali";
            this.btnLisMaali.Size = new System.Drawing.Size(19, 23);
            this.btnLisMaali.TabIndex = 31;
            this.btnLisMaali.Text = "+";
            this.btnLisMaali.UseVisualStyleBackColor = true;
            this.btnLisMaali.Click += new System.EventHandler(this.btnLisMaali_Click);
            // 
            // btnPeruPisteet
            // 
            this.btnPeruPisteet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeruPisteet.Location = new System.Drawing.Point(95, 164);
            this.btnPeruPisteet.Name = "btnPeruPisteet";
            this.btnPeruPisteet.Size = new System.Drawing.Size(65, 41);
            this.btnPeruPisteet.TabIndex = 30;
            this.btnPeruPisteet.Text = "Peru";
            this.btnPeruPisteet.UseVisualStyleBackColor = true;
            this.btnPeruPisteet.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKotiMuokkaa
            // 
            this.btnKotiMuokkaa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKotiMuokkaa.Location = new System.Drawing.Point(95, 117);
            this.btnKotiMuokkaa.Name = "btnKotiMuokkaa";
            this.btnKotiMuokkaa.Size = new System.Drawing.Size(65, 41);
            this.btnKotiMuokkaa.TabIndex = 29;
            this.btnKotiMuokkaa.Text = "Päivitä";
            this.btnKotiMuokkaa.UseVisualStyleBackColor = true;
            this.btnKotiMuokkaa.Click += new System.EventHandler(this.btnKotiMuokkaa_Click);
            // 
            // lblKotiMaali
            // 
            this.lblKotiMaali.AutoSize = true;
            this.lblKotiMaali.Location = new System.Drawing.Point(92, 1);
            this.lblKotiMaali.Name = "lblKotiMaali";
            this.lblKotiMaali.Size = new System.Drawing.Size(45, 17);
            this.lblKotiMaali.TabIndex = 27;
            this.lblKotiMaali.Text = "Maalit";
            // 
            // lblKotiSyotot
            // 
            this.lblKotiSyotot.AutoSize = true;
            this.lblKotiSyotot.Location = new System.Drawing.Point(92, 57);
            this.lblKotiSyotot.Name = "lblKotiSyotot";
            this.lblKotiSyotot.Size = new System.Drawing.Size(48, 17);
            this.lblKotiSyotot.TabIndex = 28;
            this.lblKotiSyotot.Text = "Syötöt";
            // 
            // tbKotiMaali
            // 
            this.tbKotiMaali.Enabled = false;
            this.tbKotiMaali.Location = new System.Drawing.Point(95, 21);
            this.tbKotiMaali.Name = "tbKotiMaali";
            this.tbKotiMaali.Size = new System.Drawing.Size(65, 22);
            this.tbKotiMaali.TabIndex = 25;
            this.tbKotiMaali.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbKotiSyotot
            // 
            this.tbKotiSyotot.Enabled = false;
            this.tbKotiSyotot.Location = new System.Drawing.Point(95, 77);
            this.tbKotiSyotot.Name = "tbKotiSyotot";
            this.tbKotiSyotot.Size = new System.Drawing.Size(65, 22);
            this.tbKotiSyotot.TabIndex = 0;
            this.tbKotiSyotot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnKotiPlus
            // 
            this.btnKotiPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKotiPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKotiPlus.Location = new System.Drawing.Point(3, 3);
            this.btnKotiPlus.Name = "btnKotiPlus";
            this.btnKotiPlus.Size = new System.Drawing.Size(34, 38);
            this.btnKotiPlus.TabIndex = 31;
            this.btnKotiPlus.Text = "+";
            this.toolTip1.SetToolTip(this.btnKotiPlus, "Lisää maali");
            this.btnKotiPlus.UseVisualStyleBackColor = true;
            this.btnKotiPlus.Click += new System.EventHandler(this.btnKotiPlus_Click);
            // 
            // btnKotiMiinus
            // 
            this.btnKotiMiinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKotiMiinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKotiMiinus.Location = new System.Drawing.Point(43, 3);
            this.btnKotiMiinus.Name = "btnKotiMiinus";
            this.btnKotiMiinus.Size = new System.Drawing.Size(34, 38);
            this.btnKotiMiinus.TabIndex = 32;
            this.btnKotiMiinus.Text = "-";
            this.toolTip1.SetToolTip(this.btnKotiMiinus, "Vähennä maali");
            this.btnKotiMiinus.UseVisualStyleBackColor = true;
            this.btnKotiMiinus.Click += new System.EventHandler(this.btnKotiMiinus_Click);
            // 
            // btnVierasMiinus
            // 
            this.btnVierasMiinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVierasMiinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVierasMiinus.Location = new System.Drawing.Point(43, 3);
            this.btnVierasMiinus.Name = "btnVierasMiinus";
            this.btnVierasMiinus.Size = new System.Drawing.Size(34, 38);
            this.btnVierasMiinus.TabIndex = 34;
            this.btnVierasMiinus.Text = "-";
            this.toolTip1.SetToolTip(this.btnVierasMiinus, "Vähennä maali");
            this.btnVierasMiinus.UseVisualStyleBackColor = true;
            this.btnVierasMiinus.Click += new System.EventHandler(this.btnVierasMiinus_Click);
            // 
            // btnVierasPlus
            // 
            this.btnVierasPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVierasPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVierasPlus.Location = new System.Drawing.Point(3, 3);
            this.btnVierasPlus.Name = "btnVierasPlus";
            this.btnVierasPlus.Size = new System.Drawing.Size(34, 38);
            this.btnVierasPlus.TabIndex = 33;
            this.btnVierasPlus.Text = "+";
            this.toolTip1.SetToolTip(this.btnVierasPlus, "Lisää maali");
            this.btnVierasPlus.UseVisualStyleBackColor = true;
            this.btnVierasPlus.Click += new System.EventHandler(this.btnVierasPlus_Click);
            // 
            // lblKokonaisaika
            // 
            this.lblKokonaisaika.AutoSize = true;
            this.lblKokonaisaika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKokonaisaika.Location = new System.Drawing.Point(12, 75);
            this.lblKokonaisaika.Name = "lblKokonaisaika";
            this.lblKokonaisaika.Size = new System.Drawing.Size(107, 20);
            this.lblKokonaisaika.TabIndex = 35;
            this.lblKokonaisaika.Text = "Kokonaisaika";
            // 
            // lblKokaika
            // 
            this.lblKokaika.AutoSize = true;
            this.lblKokaika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKokaika.Location = new System.Drawing.Point(25, 106);
            this.lblKokaika.Name = "lblKokaika";
            this.lblKokaika.Size = new System.Drawing.Size(60, 20);
            this.lblKokaika.TabIndex = 36;
            this.lblKokaika.Text = "00 : 00";
            this.toolTip1.SetToolTip(this.lblKokaika, "Pelin kokonaisaika");
            // 
            // btnMaali
            // 
            this.btnMaali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaali.Location = new System.Drawing.Point(551, 219);
            this.btnMaali.Name = "btnMaali";
            this.btnMaali.Size = new System.Drawing.Size(160, 38);
            this.btnMaali.TabIndex = 37;
            this.btnMaali.Text = "Muokkaa tulosta";
            this.toolTip1.SetToolTip(this.btnMaali, "Tästä pääsee lisäämän ja \r\nvähentämään maaleja");
            this.btnMaali.UseVisualStyleBackColor = true;
            this.btnMaali.Click += new System.EventHandler(this.btnMaali_Click);
            // 
            // pnlKoti
            // 
            this.pnlKoti.Controls.Add(this.btnKotiPlus);
            this.pnlKoti.Controls.Add(this.btnKotiMiinus);
            this.pnlKoti.Location = new System.Drawing.Point(295, 223);
            this.pnlKoti.Name = "pnlKoti";
            this.pnlKoti.Size = new System.Drawing.Size(82, 45);
            this.pnlKoti.TabIndex = 38;
            this.pnlKoti.Visible = false;
            // 
            // pnlVieras
            // 
            this.pnlVieras.Controls.Add(this.btnVierasPlus);
            this.pnlVieras.Controls.Add(this.btnVierasMiinus);
            this.pnlVieras.Location = new System.Drawing.Point(916, 223);
            this.pnlVieras.Name = "pnlVieras";
            this.pnlVieras.Size = new System.Drawing.Size(80, 45);
            this.pnlVieras.TabIndex = 39;
            this.pnlVieras.Visible = false;
            // 
            // btnPeru
            // 
            this.btnPeru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeru.Location = new System.Drawing.Point(551, 263);
            this.btnPeru.Name = "btnPeru";
            this.btnPeru.Size = new System.Drawing.Size(160, 28);
            this.btnPeru.TabIndex = 40;
            this.btnPeru.Text = "Peru muokkaus";
            this.toolTip1.SetToolTip(this.btnPeru, "Peru muokkaus");
            this.btnPeru.UseVisualStyleBackColor = true;
            this.btnPeru.Visible = false;
            this.btnPeru.Click += new System.EventHandler(this.btnPeru_Click);
            // 
            // lblOhje
            // 
            this.lblOhje.AutoSize = true;
            this.lblOhje.Location = new System.Drawing.Point(136, 277);
            this.lblOhje.Name = "lblOhje";
            this.lblOhje.Size = new System.Drawing.Size(280, 17);
            this.lblOhje.TabIndex = 41;
            this.lblOhje.Text = "Pelinro / Etunimi / Sukunimi / Maalit / Syötöt";
            // 
            // lblOhje2
            // 
            this.lblOhje2.AutoSize = true;
            this.lblOhje2.Location = new System.Drawing.Point(785, 277);
            this.lblOhje2.Name = "lblOhje2";
            this.lblOhje2.Size = new System.Drawing.Size(280, 17);
            this.lblOhje2.TabIndex = 42;
            this.lblOhje2.Text = "Pelinro / Etunimi / Sukunimi / Maalit / Syötöt";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.käynnistäPysäytäToolStripMenuItem,
            this.muokkaaTulostaToolStripMenuItem1,
            this.nopeutaToolStripMenuItem1,
            this.lopetaToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 100);
            // 
            // käynnistäPysäytäToolStripMenuItem
            // 
            this.käynnistäPysäytäToolStripMenuItem.Name = "käynnistäPysäytäToolStripMenuItem";
            this.käynnistäPysäytäToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.käynnistäPysäytäToolStripMenuItem.Text = "Käynnistä/ pysäytä";
            this.käynnistäPysäytäToolStripMenuItem.Click += new System.EventHandler(this.btnAloita_Click);
            // 
            // muokkaaTulostaToolStripMenuItem1
            // 
            this.muokkaaTulostaToolStripMenuItem1.Name = "muokkaaTulostaToolStripMenuItem1";
            this.muokkaaTulostaToolStripMenuItem1.Size = new System.Drawing.Size(201, 24);
            this.muokkaaTulostaToolStripMenuItem1.Text = "Muokkaa tulosta";
            this.muokkaaTulostaToolStripMenuItem1.Click += new System.EventHandler(this.btnMaali_Click);
            // 
            // nopeutaToolStripMenuItem1
            // 
            this.nopeutaToolStripMenuItem1.Name = "nopeutaToolStripMenuItem1";
            this.nopeutaToolStripMenuItem1.Size = new System.Drawing.Size(201, 24);
            this.nopeutaToolStripMenuItem1.Text = "Nopeuta";
            this.nopeutaToolStripMenuItem1.Click += new System.EventHandler(this.btnKelaa_Click);
            // 
            // lopetaToolStripMenuItem1
            // 
            this.lopetaToolStripMenuItem1.Name = "lopetaToolStripMenuItem1";
            this.lopetaToolStripMenuItem1.Size = new System.Drawing.Size(201, 24);
            this.lopetaToolStripMenuItem1.Text = "Lopeta";
            this.lopetaToolStripMenuItem1.Click += new System.EventHandler(this.lopetaToolStripMenuItem_Click);
            // 
            // lblOhjeMuokkaus
            // 
            this.lblOhjeMuokkaus.AutoSize = true;
            this.lblOhjeMuokkaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOhjeMuokkaus.Location = new System.Drawing.Point(423, 624);
            this.lblOhjeMuokkaus.Name = "lblOhjeMuokkaus";
            this.lblOhjeMuokkaus.Size = new System.Drawing.Size(447, 20);
            this.lblOhjeMuokkaus.TabIndex = 44;
            this.lblOhjeMuokkaus.Text = "Voit muokata tehopisteitä tuplaklikkaamalla pelaajaa";
            // 
            // FrmPeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 725);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblOhjeMuokkaus);
            this.Controls.Add(this.lblOhje2);
            this.Controls.Add(this.lblOhje);
            this.Controls.Add(this.btnPeru);
            this.Controls.Add(this.pnlVieras);
            this.Controls.Add(this.pnlKoti);
            this.Controls.Add(this.btnMaali);
            this.Controls.Add(this.lblKokaika);
            this.Controls.Add(this.lblKokonaisaika);
            this.Controls.Add(this.pnlKotiTehopiste);
            this.Controls.Add(this.lbKoti);
            this.Controls.Add(this.lbVieras);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblVierasMaalit);
            this.Controls.Add(this.lblVierasjoukkue);
            this.Controls.Add(this.lblKotiMaalit);
            this.Controls.Add(this.lblKotijoukkue);
            this.Controls.Add(this.lblEraNum);
            this.Controls.Add(this.btnKelaa);
            this.Controls.Add(this.lblEra);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAloita);
            this.Controls.Add(this.lblPeliaika);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1315, 772);
            this.MinimumSize = new System.Drawing.Size(1315, 772);
            this.Name = "FrmPeli";
            this.Text = "Peli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPeli_FormClosing);
            this.Load += new System.EventHandler(this.FrmJaakiekkoPeli_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlKotiTehopiste.ResumeLayout(false);
            this.pnlKotiTehopiste.PerformLayout();
            this.pnlKoti.ResumeLayout(false);
            this.pnlVieras.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeliaika;
        private System.Windows.Forms.Timer tmrPeliaika;
        private System.Windows.Forms.Button btnAloita;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblPelialkoi;
        private System.Windows.Forms.ToolStripStatusLabel tsslblPelipaattyi;
        private System.Windows.Forms.Label lblEra;
        private System.Windows.Forms.Button btnKelaa;
        private System.Windows.Forms.Label lblEraNum;
        private System.Windows.Forms.Label lblKotijoukkue;
        private System.Windows.Forms.Label lblKotiMaalit;
        private System.Windows.Forms.Label lblVierasMaalit;
        private System.Windows.Forms.Label lblVierasjoukkue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jepToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ListBox lbVieras;
        private System.Windows.Forms.ListBox lbKoti;
        private System.Windows.Forms.Panel pnlKotiTehopiste;
        private System.Windows.Forms.Button btnKotiMuokkaa;
        private System.Windows.Forms.Label lblKotiMaali;
        private System.Windows.Forms.Label lblKotiSyotot;
        private System.Windows.Forms.TextBox tbKotiMaali;
        private System.Windows.Forms.TextBox tbKotiSyotot;
        private System.Windows.Forms.Button btnKotiPlus;
        private System.Windows.Forms.Button btnKotiMiinus;
        private System.Windows.Forms.Button btnVierasMiinus;
        private System.Windows.Forms.Button btnVierasPlus;
        private System.Windows.Forms.Label lblKokonaisaika;
        private System.Windows.Forms.Label lblKokaika;
        private System.Windows.Forms.Button btnMaali;
        private System.Windows.Forms.Panel pnlKoti;
        private System.Windows.Forms.Panel pnlVieras;
        private System.Windows.Forms.ToolStripMenuItem muokkaaTulostaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem käynnistäPysäytäKelloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nopeutaToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnPeru;
        private System.Windows.Forms.Button btnPeruPisteet;
        private System.Windows.Forms.ToolStripMenuItem lopetaToolStripMenuItem;
        private System.Windows.Forms.Button btnLisMaali;
        private System.Windows.Forms.Button btnVahMaali;
        private System.Windows.Forms.Button btnVahSyotto;
        private System.Windows.Forms.Button btnLisSyotto;
        private System.Windows.Forms.Label lblOhje;
        private System.Windows.Forms.Label lblOhje2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem käynnistäPysäytäToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muokkaaTulostaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nopeutaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lopetaToolStripMenuItem1;
        private System.Windows.Forms.Label lblOhjeMuokkaus;
        private System.Windows.Forms.ToolStripButton tsbtnPlay;
        private System.Windows.Forms.ToolStripButton tsbtnKelaa;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbtnLopeta;
    }
}