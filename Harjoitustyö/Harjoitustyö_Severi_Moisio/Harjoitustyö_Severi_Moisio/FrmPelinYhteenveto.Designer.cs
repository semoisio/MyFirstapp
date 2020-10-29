namespace Harjoitustyö_Severi_Moisio
{
    partial class FrmPelinYhteenveto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPelinYhteenveto));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaJaLopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblVirhe = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblKotiJoukkue = new System.Windows.Forms.Label();
            this.lblVierasJoukkue = new System.Windows.Forms.Label();
            this.lblKotiMaalit = new System.Windows.Forms.Label();
            this.lblVierasMaalit = new System.Windows.Forms.Label();
            this.lbKotiYhteenveto = new System.Windows.Forms.ListBox();
            this.lbVierasYhteenveto = new System.Windows.Forms.ListBox();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tallennaJaLopetaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTehopisteet = new System.Windows.Forms.Panel();
            this.btnPeru = new System.Windows.Forms.Button();
            this.btnLisSyotto = new System.Windows.Forms.Button();
            this.btnLisMaali = new System.Windows.Forms.Button();
            this.btnVahMaali = new System.Windows.Forms.Button();
            this.btnVahSyotto = new System.Windows.Forms.Button();
            this.btnPäivitä = new System.Windows.Forms.Button();
            this.tbSyotto = new System.Windows.Forms.TextBox();
            this.lblSyotto = new System.Windows.Forms.Label();
            this.tbMaali = new System.Windows.Forms.TextBox();
            this.lblMaali = new System.Windows.Forms.Label();
            this.lblVoitto1 = new System.Windows.Forms.Label();
            this.lblVoitto2 = new System.Windows.Forms.Label();
            this.lblTasapeli = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblOhje = new System.Windows.Forms.Label();
            this.lblOhje2 = new System.Windows.Forms.Label();
            this.lblOhjeMuokkaus = new System.Windows.Forms.Label();
            this.pbVoitto1 = new System.Windows.Forms.PictureBox();
            this.pbVoitto2 = new System.Windows.Forms.PictureBox();
            this.pbTasan = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlTehopisteet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoitto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoitto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTasan)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jepToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jepToolStripMenuItem
            // 
            this.jepToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tallennaJaLopetaToolStripMenuItem});
            this.jepToolStripMenuItem.Name = "jepToolStripMenuItem";
            this.jepToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.jepToolStripMenuItem.Text = "Tiedosto";
            // 
            // tallennaJaLopetaToolStripMenuItem
            // 
            this.tallennaJaLopetaToolStripMenuItem.Name = "tallennaJaLopetaToolStripMenuItem";
            this.tallennaJaLopetaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tallennaJaLopetaToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.tallennaJaLopetaToolStripMenuItem.Text = "Tallenna ja lopeta";
            this.tallennaJaLopetaToolStripMenuItem.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1031, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblVirhe});
            this.statusStrip1.Location = new System.Drawing.Point(0, 615);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1031, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblVirhe
            // 
            this.tsslblVirhe.Name = "tsslblVirhe";
            this.tsslblVirhe.Size = new System.Drawing.Size(134, 20);
            this.tsslblVirhe.Text = "Tänne tulee virheet";
            this.tsslblVirhe.Visible = false;
            // 
            // lblKotiJoukkue
            // 
            this.lblKotiJoukkue.AutoSize = true;
            this.lblKotiJoukkue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKotiJoukkue.Location = new System.Drawing.Point(205, 94);
            this.lblKotiJoukkue.Name = "lblKotiJoukkue";
            this.lblKotiJoukkue.Size = new System.Drawing.Size(105, 20);
            this.lblKotiJoukkue.TabIndex = 3;
            this.lblKotiJoukkue.Text = "Kotijoukkue";
            // 
            // lblVierasJoukkue
            // 
            this.lblVierasJoukkue.AutoSize = true;
            this.lblVierasJoukkue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVierasJoukkue.Location = new System.Drawing.Point(653, 94);
            this.lblVierasJoukkue.Name = "lblVierasJoukkue";
            this.lblVierasJoukkue.Size = new System.Drawing.Size(126, 20);
            this.lblVierasJoukkue.TabIndex = 4;
            this.lblVierasJoukkue.Text = "Vierasjoukkue";
            // 
            // lblKotiMaalit
            // 
            this.lblKotiMaalit.AutoSize = true;
            this.lblKotiMaalit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKotiMaalit.Location = new System.Drawing.Point(228, 132);
            this.lblKotiMaalit.Name = "lblKotiMaalit";
            this.lblKotiMaalit.Size = new System.Drawing.Size(26, 29);
            this.lblKotiMaalit.TabIndex = 5;
            this.lblKotiMaalit.Text = "0";
            // 
            // lblVierasMaalit
            // 
            this.lblVierasMaalit.AutoSize = true;
            this.lblVierasMaalit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVierasMaalit.Location = new System.Drawing.Point(676, 132);
            this.lblVierasMaalit.Name = "lblVierasMaalit";
            this.lblVierasMaalit.Size = new System.Drawing.Size(26, 29);
            this.lblVierasMaalit.TabIndex = 6;
            this.lblVierasMaalit.Text = "0";
            // 
            // lbKotiYhteenveto
            // 
            this.lbKotiYhteenveto.FormattingEnabled = true;
            this.lbKotiYhteenveto.ItemHeight = 16;
            this.lbKotiYhteenveto.Location = new System.Drawing.Point(123, 190);
            this.lbKotiYhteenveto.Name = "lbKotiYhteenveto";
            this.lbKotiYhteenveto.Size = new System.Drawing.Size(267, 324);
            this.lbKotiYhteenveto.TabIndex = 7;
            this.toolTip1.SetToolTip(this.lbKotiYhteenveto, "Tuplaklikkaamalla pelaajaa \r\npääsee muokkaamaan pisteitä.");
            this.lbKotiYhteenveto.DoubleClick += new System.EventHandler(this.lbKotiYhteenveto_DoubleClick);
            // 
            // lbVierasYhteenveto
            // 
            this.lbVierasYhteenveto.FormattingEnabled = true;
            this.lbVierasYhteenveto.ItemHeight = 16;
            this.lbVierasYhteenveto.Location = new System.Drawing.Point(584, 190);
            this.lbVierasYhteenveto.Name = "lbVierasYhteenveto";
            this.lbVierasYhteenveto.Size = new System.Drawing.Size(267, 324);
            this.lbVierasYhteenveto.TabIndex = 8;
            this.toolTip1.SetToolTip(this.lbVierasYhteenveto, "Tuplaklikkaamalla pelaajaa \r\npääsee muokkaamaan pisteitä.");
            this.lbVierasYhteenveto.DoubleClick += new System.EventHandler(this.lbKotiYhteenveto_DoubleClick);
            // 
            // btnTallenna
            // 
            this.btnTallenna.ContextMenuStrip = this.contextMenuStrip1;
            this.btnTallenna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTallenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTallenna.Location = new System.Drawing.Point(926, 530);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(97, 79);
            this.btnTallenna.TabIndex = 9;
            this.btnTallenna.Text = "Tallenna ja lopeta";
            this.toolTip1.SetToolTip(this.btnTallenna, "Tallentaa ja palaa etusivulle");
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tallennaJaLopetaToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(196, 28);
            // 
            // tallennaJaLopetaToolStripMenuItem1
            // 
            this.tallennaJaLopetaToolStripMenuItem1.Name = "tallennaJaLopetaToolStripMenuItem1";
            this.tallennaJaLopetaToolStripMenuItem1.Size = new System.Drawing.Size(195, 24);
            this.tallennaJaLopetaToolStripMenuItem1.Text = "Tallenna ja lopeta";
            this.tallennaJaLopetaToolStripMenuItem1.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // pnlTehopisteet
            // 
            this.pnlTehopisteet.Controls.Add(this.btnPeru);
            this.pnlTehopisteet.Controls.Add(this.btnLisSyotto);
            this.pnlTehopisteet.Controls.Add(this.btnLisMaali);
            this.pnlTehopisteet.Controls.Add(this.btnVahMaali);
            this.pnlTehopisteet.Controls.Add(this.btnVahSyotto);
            this.pnlTehopisteet.Controls.Add(this.btnPäivitä);
            this.pnlTehopisteet.Controls.Add(this.tbSyotto);
            this.pnlTehopisteet.Controls.Add(this.lblSyotto);
            this.pnlTehopisteet.Controls.Add(this.tbMaali);
            this.pnlTehopisteet.Controls.Add(this.lblMaali);
            this.pnlTehopisteet.Location = new System.Drawing.Point(396, 190);
            this.pnlTehopisteet.Name = "pnlTehopisteet";
            this.pnlTehopisteet.Size = new System.Drawing.Size(182, 219);
            this.pnlTehopisteet.TabIndex = 10;
            this.pnlTehopisteet.Visible = false;
            // 
            // btnPeru
            // 
            this.btnPeru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeru.Location = new System.Drawing.Point(49, 165);
            this.btnPeru.Name = "btnPeru";
            this.btnPeru.Size = new System.Drawing.Size(75, 41);
            this.btnPeru.TabIndex = 39;
            this.btnPeru.Text = "Peru lisäys";
            this.btnPeru.UseVisualStyleBackColor = true;
            this.btnPeru.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLisSyotto
            // 
            this.btnLisSyotto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLisSyotto.Location = new System.Drawing.Point(36, 75);
            this.btnLisSyotto.Name = "btnLisSyotto";
            this.btnLisSyotto.Size = new System.Drawing.Size(19, 23);
            this.btnLisSyotto.TabIndex = 38;
            this.btnLisSyotto.Text = "+";
            this.btnLisSyotto.UseVisualStyleBackColor = true;
            this.btnLisSyotto.Click += new System.EventHandler(this.btnLisSyotto_Click);
            // 
            // btnLisMaali
            // 
            this.btnLisMaali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLisMaali.Location = new System.Drawing.Point(36, 23);
            this.btnLisMaali.Name = "btnLisMaali";
            this.btnLisMaali.Size = new System.Drawing.Size(19, 23);
            this.btnLisMaali.TabIndex = 37;
            this.btnLisMaali.Text = "+";
            this.btnLisMaali.UseVisualStyleBackColor = true;
            this.btnLisMaali.Click += new System.EventHandler(this.btnLisMaali_Click);
            // 
            // btnVahMaali
            // 
            this.btnVahMaali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVahMaali.Location = new System.Drawing.Point(117, 23);
            this.btnVahMaali.Name = "btnVahMaali";
            this.btnVahMaali.Size = new System.Drawing.Size(19, 23);
            this.btnVahMaali.TabIndex = 36;
            this.btnVahMaali.Text = "-";
            this.btnVahMaali.UseVisualStyleBackColor = true;
            this.btnVahMaali.Click += new System.EventHandler(this.btnVahMaali_Click);
            // 
            // btnVahSyotto
            // 
            this.btnVahSyotto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVahSyotto.Location = new System.Drawing.Point(117, 75);
            this.btnVahSyotto.Name = "btnVahSyotto";
            this.btnVahSyotto.Size = new System.Drawing.Size(19, 23);
            this.btnVahSyotto.TabIndex = 35;
            this.btnVahSyotto.Text = "-";
            this.btnVahSyotto.UseVisualStyleBackColor = true;
            this.btnVahSyotto.Click += new System.EventHandler(this.btnVahSyotto_Click);
            // 
            // btnPäivitä
            // 
            this.btnPäivitä.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPäivitä.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPäivitä.Location = new System.Drawing.Point(49, 118);
            this.btnPäivitä.Name = "btnPäivitä";
            this.btnPäivitä.Size = new System.Drawing.Size(75, 41);
            this.btnPäivitä.TabIndex = 4;
            this.btnPäivitä.Text = "Päivitä";
            this.btnPäivitä.UseVisualStyleBackColor = true;
            this.btnPäivitä.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSyotto
            // 
            this.tbSyotto.Enabled = false;
            this.tbSyotto.Location = new System.Drawing.Point(61, 76);
            this.tbSyotto.Name = "tbSyotto";
            this.tbSyotto.Size = new System.Drawing.Size(50, 22);
            this.tbSyotto.TabIndex = 3;
            this.tbSyotto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSyotto
            // 
            this.lblSyotto.AutoSize = true;
            this.lblSyotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSyotto.Location = new System.Drawing.Point(57, 53);
            this.lblSyotto.Name = "lblSyotto";
            this.lblSyotto.Size = new System.Drawing.Size(56, 20);
            this.lblSyotto.TabIndex = 2;
            this.lblSyotto.Text = "Syötöt";
            // 
            // tbMaali
            // 
            this.tbMaali.Enabled = false;
            this.tbMaali.Location = new System.Drawing.Point(61, 23);
            this.tbMaali.Name = "tbMaali";
            this.tbMaali.Size = new System.Drawing.Size(50, 22);
            this.tbMaali.TabIndex = 1;
            this.tbMaali.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaali
            // 
            this.lblMaali.AutoSize = true;
            this.lblMaali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaali.Location = new System.Drawing.Point(57, 0);
            this.lblMaali.Name = "lblMaali";
            this.lblMaali.Size = new System.Drawing.Size(54, 20);
            this.lblMaali.TabIndex = 0;
            this.lblMaali.Text = "Maalit";
            // 
            // lblVoitto1
            // 
            this.lblVoitto1.AutoSize = true;
            this.lblVoitto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoitto1.Location = new System.Drawing.Point(84, 94);
            this.lblVoitto1.Name = "lblVoitto1";
            this.lblVoitto1.Size = new System.Drawing.Size(88, 20);
            this.lblVoitto1.TabIndex = 11;
            this.lblVoitto1.Text = "VOITTAJA";
            this.lblVoitto1.Visible = false;
            // 
            // lblVoitto2
            // 
            this.lblVoitto2.AutoSize = true;
            this.lblVoitto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoitto2.Location = new System.Drawing.Point(811, 94);
            this.lblVoitto2.Name = "lblVoitto2";
            this.lblVoitto2.Size = new System.Drawing.Size(88, 20);
            this.lblVoitto2.TabIndex = 12;
            this.lblVoitto2.Text = "VOITTAJA";
            this.lblVoitto2.Visible = false;
            // 
            // lblTasapeli
            // 
            this.lblTasapeli.AutoSize = true;
            this.lblTasapeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasapeli.Location = new System.Drawing.Point(433, 94);
            this.lblTasapeli.Name = "lblTasapeli";
            this.lblTasapeli.Size = new System.Drawing.Size(88, 20);
            this.lblTasapeli.TabIndex = 13;
            this.lblTasapeli.Text = "TASAPELI";
            this.lblTasapeli.Visible = false;
            // 
            // lblOhje
            // 
            this.lblOhje.AutoSize = true;
            this.lblOhje.Location = new System.Drawing.Point(120, 170);
            this.lblOhje.Name = "lblOhje";
            this.lblOhje.Size = new System.Drawing.Size(264, 17);
            this.lblOhje.TabIndex = 42;
            this.lblOhje.Text = "Pelinro/ Etunimi/ Sukunimi/ Maalit/ Syötöt";
            // 
            // lblOhje2
            // 
            this.lblOhje2.AutoSize = true;
            this.lblOhje2.Location = new System.Drawing.Point(584, 170);
            this.lblOhje2.Name = "lblOhje2";
            this.lblOhje2.Size = new System.Drawing.Size(264, 17);
            this.lblOhje2.TabIndex = 43;
            this.lblOhje2.Text = "Pelinro/ Etunimi/ Sukunimi/ Maalit/ Syötöt";
            // 
            // lblOhjeMuokkaus
            // 
            this.lblOhjeMuokkaus.AutoSize = true;
            this.lblOhjeMuokkaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOhjeMuokkaus.Location = new System.Drawing.Point(229, 559);
            this.lblOhjeMuokkaus.Name = "lblOhjeMuokkaus";
            this.lblOhjeMuokkaus.Size = new System.Drawing.Size(568, 60);
            this.lblOhjeMuokkaus.TabIndex = 44;
            this.lblOhjeMuokkaus.Text = "Voit muokata vielä tehopisteitä tässä vaiheessa ennen tallennusta.\r\n(tuplaklikkaa" +
    " pelaajaa)\r\n\r\n";
            // 
            // pbVoitto1
            // 
            this.pbVoitto1.Image = ((System.Drawing.Image)(resources.GetObject("pbVoitto1.Image")));
            this.pbVoitto1.Location = new System.Drawing.Point(72, 117);
            this.pbVoitto1.Name = "pbVoitto1";
            this.pbVoitto1.Size = new System.Drawing.Size(100, 50);
            this.pbVoitto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVoitto1.TabIndex = 45;
            this.pbVoitto1.TabStop = false;
            this.pbVoitto1.Visible = false;
            // 
            // pbVoitto2
            // 
            this.pbVoitto2.Image = ((System.Drawing.Image)(resources.GetObject("pbVoitto2.Image")));
            this.pbVoitto2.Location = new System.Drawing.Point(815, 117);
            this.pbVoitto2.Name = "pbVoitto2";
            this.pbVoitto2.Size = new System.Drawing.Size(100, 50);
            this.pbVoitto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVoitto2.TabIndex = 46;
            this.pbVoitto2.TabStop = false;
            this.pbVoitto2.Visible = false;
            // 
            // pbTasan
            // 
            this.pbTasan.Image = ((System.Drawing.Image)(resources.GetObject("pbTasan.Image")));
            this.pbTasan.InitialImage = null;
            this.pbTasan.Location = new System.Drawing.Point(437, 117);
            this.pbTasan.Name = "pbTasan";
            this.pbTasan.Size = new System.Drawing.Size(84, 50);
            this.pbTasan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTasan.TabIndex = 47;
            this.pbTasan.TabStop = false;
            this.pbTasan.Visible = false;
            // 
            // FrmPelinYhteenveto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 637);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pbTasan);
            this.Controls.Add(this.pbVoitto2);
            this.Controls.Add(this.pbVoitto1);
            this.Controls.Add(this.lblOhjeMuokkaus);
            this.Controls.Add(this.lblOhje2);
            this.Controls.Add(this.lblOhje);
            this.Controls.Add(this.lblTasapeli);
            this.Controls.Add(this.lblVoitto2);
            this.Controls.Add(this.lblVoitto1);
            this.Controls.Add(this.pnlTehopisteet);
            this.Controls.Add(this.btnTallenna);
            this.Controls.Add(this.lbVierasYhteenveto);
            this.Controls.Add(this.lbKotiYhteenveto);
            this.Controls.Add(this.lblVierasMaalit);
            this.Controls.Add(this.lblKotiMaalit);
            this.Controls.Add(this.lblVierasJoukkue);
            this.Controls.Add(this.lblKotiJoukkue);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1049, 684);
            this.MinimumSize = new System.Drawing.Size(1049, 684);
            this.Name = "FrmPelinYhteenveto";
            this.Text = "Yhteenveto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPelinYhteenveto_FormClosing);
            this.Load += new System.EventHandler(this.FrmPelinYhteenveto_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlTehopisteet.ResumeLayout(false);
            this.pnlTehopisteet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoitto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoitto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTasan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jepToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblKotiJoukkue;
        private System.Windows.Forms.Label lblVierasJoukkue;
        private System.Windows.Forms.Label lblKotiMaalit;
        private System.Windows.Forms.Label lblVierasMaalit;
        private System.Windows.Forms.ListBox lbKotiYhteenveto;
        private System.Windows.Forms.ListBox lbVierasYhteenveto;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.Panel pnlTehopisteet;
        private System.Windows.Forms.Button btnPäivitä;
        private System.Windows.Forms.TextBox tbSyotto;
        private System.Windows.Forms.Label lblSyotto;
        private System.Windows.Forms.TextBox tbMaali;
        private System.Windows.Forms.Label lblMaali;
        private System.Windows.Forms.Label lblVoitto1;
        private System.Windows.Forms.Label lblVoitto2;
        private System.Windows.Forms.Label lblTasapeli;
        private System.Windows.Forms.Button btnVahMaali;
        private System.Windows.Forms.Button btnVahSyotto;
        private System.Windows.Forms.Button btnPeru;
        private System.Windows.Forms.Button btnLisSyotto;
        private System.Windows.Forms.Button btnLisMaali;
        private System.Windows.Forms.ToolStripMenuItem tallennaJaLopetaToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblOhje;
        private System.Windows.Forms.Label lblOhje2;
        private System.Windows.Forms.Label lblOhjeMuokkaus;
        private System.Windows.Forms.ToolStripStatusLabel tsslblVirhe;
        private System.Windows.Forms.PictureBox pbVoitto1;
        private System.Windows.Forms.PictureBox pbVoitto2;
        private System.Windows.Forms.PictureBox pbTasan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tallennaJaLopetaToolStripMenuItem1;
    }
}