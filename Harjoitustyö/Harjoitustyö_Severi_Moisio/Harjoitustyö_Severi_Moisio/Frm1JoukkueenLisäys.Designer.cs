namespace Harjoitustyö_Severi_Moisio
{
    partial class Frm1JoukkueenLisäys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm1JoukkueenLisäys));
            this.lblJoukkue = new System.Windows.Forms.Label();
            this.tbJoukkue = new System.Windows.Forms.TextBox();
            this.lblPelaaja = new System.Windows.Forms.Label();
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nupNumero = new System.Windows.Forms.NumericUpDown();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.lbPelaajat = new System.Windows.Forms.ListBox();
            this.btnValmis = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblVirhe = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaJaLopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisääPelaajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tpVihje = new System.Windows.Forms.ToolTip(this.components);
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.lblOhje = new System.Windows.Forms.Label();
            this.pnlJoukkueet = new System.Windows.Forms.Panel();
            this.cbJoukkueet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.epVirhe = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tallennaJaLopetaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lisääPelaajaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumero)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlJoukkueet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epVirhe)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJoukkue
            // 
            this.lblJoukkue.AutoSize = true;
            this.lblJoukkue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoukkue.Location = new System.Drawing.Point(12, 63);
            this.lblJoukkue.Name = "lblJoukkue";
            this.lblJoukkue.Size = new System.Drawing.Size(138, 20);
            this.lblJoukkue.TabIndex = 0;
            this.lblJoukkue.Text = "Joukkueen nimi";
            // 
            // tbJoukkue
            // 
            this.tbJoukkue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJoukkue.Location = new System.Drawing.Point(208, 63);
            this.tbJoukkue.Name = "tbJoukkue";
            this.tbJoukkue.Size = new System.Drawing.Size(193, 27);
            this.tbJoukkue.TabIndex = 1;
            this.tbJoukkue.Leave += new System.EventHandler(this.tbJoukkue_Leave);
            // 
            // lblPelaaja
            // 
            this.lblPelaaja.AutoSize = true;
            this.lblPelaaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaaja.Location = new System.Drawing.Point(20, 109);
            this.lblPelaaja.Name = "lblPelaaja";
            this.lblPelaaja.Size = new System.Drawing.Size(111, 18);
            this.lblPelaaja.TabIndex = 2;
            this.lblPelaaja.Text = "Lisää pelaajat";
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtunimi.Location = new System.Drawing.Point(20, 136);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(57, 18);
            this.lblEtunimi.TabIndex = 3;
            this.lblEtunimi.Text = "Etunimi";
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(208, 136);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(193, 22);
            this.tbEtunimi.TabIndex = 4;
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(208, 164);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(193, 22);
            this.tbSukunimi.TabIndex = 6;
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSukunimi.Location = new System.Drawing.Point(20, 164);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(69, 18);
            this.lblSukunimi.TabIndex = 5;
            this.lblSukunimi.Text = "Sukunimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero";
            // 
            // nupNumero
            // 
            this.nupNumero.Location = new System.Drawing.Point(208, 192);
            this.nupNumero.Name = "nupNumero";
            this.nupNumero.Size = new System.Drawing.Size(193, 22);
            this.nupNumero.TabIndex = 8;
            this.nupNumero.Validating += new System.ComponentModel.CancelEventHandler(this.nupNumero_Validating);
            this.nupNumero.Validated += new System.EventHandler(this.nupNumero_Validated);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLisaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaa.Location = new System.Drawing.Point(464, 164);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(161, 50);
            this.btnLisaa.TabIndex = 9;
            this.btnLisaa.Text = "Lisää pelaaja";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // lbPelaajat
            // 
            this.lbPelaajat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPelaajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPelaajat.FormattingEnabled = true;
            this.lbPelaajat.ItemHeight = 25;
            this.lbPelaajat.Location = new System.Drawing.Point(23, 229);
            this.lbPelaajat.Name = "lbPelaajat";
            this.lbPelaajat.Size = new System.Drawing.Size(378, 304);
            this.lbPelaajat.TabIndex = 10;
            this.tpVihje.SetToolTip(this.lbPelaajat, "Tupla klikkaamalla poistat pelaajan");
            this.lbPelaajat.Visible = false;
            this.lbPelaajat.DoubleClick += new System.EventHandler(this.lbPelaajat_DoubleClick);
            // 
            // btnValmis
            // 
            this.btnValmis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValmis.Location = new System.Drawing.Point(483, 461);
            this.btnValmis.Name = "btnValmis";
            this.btnValmis.Size = new System.Drawing.Size(161, 82);
            this.btnValmis.TabIndex = 11;
            this.btnValmis.Text = "Tallenna joukkue";
            this.btnValmis.UseVisualStyleBackColor = true;
            this.btnValmis.Click += new System.EventHandler(this.btnValmis_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblVirhe});
            this.statusStrip1.Location = new System.Drawing.Point(0, 567);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(657, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblVirhe
            // 
            this.tsslblVirhe.ForeColor = System.Drawing.Color.Red;
            this.tsslblVirhe.Name = "tsslblVirhe";
            this.tsslblVirhe.Size = new System.Drawing.Size(160, 20);
            this.tsslblVirhe.Text = "Virhe teksti tulee tähän";
            this.tsslblVirhe.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 30);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tallennaJaLopetaToolStripMenuItem,
            this.lisääPelaajaToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // tallennaJaLopetaToolStripMenuItem
            // 
            this.tallennaJaLopetaToolStripMenuItem.Name = "tallennaJaLopetaToolStripMenuItem";
            this.tallennaJaLopetaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tallennaJaLopetaToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.tallennaJaLopetaToolStripMenuItem.Text = "Tallenna ja lopeta";
            this.tallennaJaLopetaToolStripMenuItem.Click += new System.EventHandler(this.btnValmis_Click);
            // 
            // lisääPelaajaToolStripMenuItem
            // 
            this.lisääPelaajaToolStripMenuItem.Name = "lisääPelaajaToolStripMenuItem";
            this.lisääPelaajaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.lisääPelaajaToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.lisääPelaajaToolStripMenuItem.Text = "Lisää pelaaja";
            this.lisääPelaajaToolStripMenuItem.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.pasteToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(657, 31);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.btnValmis_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.pasteToolStripButton.Text = "Lisää pelaaja";
            this.pasteToolStripButton.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuokkaa.Location = new System.Drawing.Point(407, 61);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(87, 27);
            this.btnMuokkaa.TabIndex = 15;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Visible = false;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // lblOhje
            // 
            this.lblOhje.AutoSize = true;
            this.lblOhje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOhje.Location = new System.Drawing.Point(19, 536);
            this.lblOhje.Name = "lblOhje";
            this.lblOhje.Size = new System.Drawing.Size(297, 20);
            this.lblOhje.TabIndex = 16;
            this.lblOhje.Text = "Tuplaklikkaamalla voit poistaa pelaajan";
            this.lblOhje.Visible = false;
            // 
            // pnlJoukkueet
            // 
            this.pnlJoukkueet.Controls.Add(this.cbJoukkueet);
            this.pnlJoukkueet.Controls.Add(this.label2);
            this.pnlJoukkueet.Location = new System.Drawing.Point(444, 99);
            this.pnlJoukkueet.Name = "pnlJoukkueet";
            this.pnlJoukkueet.Size = new System.Drawing.Size(200, 56);
            this.pnlJoukkueet.TabIndex = 17;
            this.pnlJoukkueet.Visible = false;
            // 
            // cbJoukkueet
            // 
            this.cbJoukkueet.FormattingEnabled = true;
            this.cbJoukkueet.Location = new System.Drawing.Point(7, 20);
            this.cbJoukkueet.Name = "cbJoukkueet";
            this.cbJoukkueet.Size = new System.Drawing.Size(180, 24);
            this.cbJoukkueet.TabIndex = 1;
            this.cbJoukkueet.TextChanged += new System.EventHandler(this.cbJoukkueet_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valitse joukkue";
            // 
            // epVirhe
            // 
            this.epVirhe.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tallennaJaLopetaToolStripMenuItem1,
            this.lisääPelaajaToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(196, 52);
            // 
            // tallennaJaLopetaToolStripMenuItem1
            // 
            this.tallennaJaLopetaToolStripMenuItem1.Name = "tallennaJaLopetaToolStripMenuItem1";
            this.tallennaJaLopetaToolStripMenuItem1.Size = new System.Drawing.Size(195, 24);
            this.tallennaJaLopetaToolStripMenuItem1.Text = "Tallenna ja lopeta";
            this.tallennaJaLopetaToolStripMenuItem1.Click += new System.EventHandler(this.btnValmis_Click);
            // 
            // lisääPelaajaToolStripMenuItem1
            // 
            this.lisääPelaajaToolStripMenuItem1.Name = "lisääPelaajaToolStripMenuItem1";
            this.lisääPelaajaToolStripMenuItem1.Size = new System.Drawing.Size(195, 24);
            this.lisääPelaajaToolStripMenuItem1.Text = "Lisää pelaaja";
            this.lisääPelaajaToolStripMenuItem1.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // Frm1JoukkueenLisäys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 589);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pnlJoukkueet);
            this.Controls.Add(this.lblOhje);
            this.Controls.Add(this.btnMuokkaa);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnValmis);
            this.Controls.Add(this.lbPelaajat);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.nupNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSukunimi);
            this.Controls.Add(this.lblSukunimi);
            this.Controls.Add(this.tbEtunimi);
            this.Controls.Add(this.lblEtunimi);
            this.Controls.Add(this.lblPelaaja);
            this.Controls.Add(this.tbJoukkue);
            this.Controls.Add(this.lblJoukkue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(675, 636);
            this.MinimumSize = new System.Drawing.Size(675, 636);
            this.Name = "Frm1JoukkueenLisäys";
            this.Text = "Joukkueen Lisäys/ muokkaus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm1JoukkueenLisäys_FormClosing);
            this.Load += new System.EventHandler(this.Frm1JoukkueenLisäys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupNumero)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlJoukkueet.ResumeLayout(false);
            this.pnlJoukkueet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epVirhe)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJoukkue;
        private System.Windows.Forms.TextBox tbJoukkue;
        private System.Windows.Forms.Label lblPelaaja;
        private System.Windows.Forms.Label lblEtunimi;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupNumero;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.ListBox lbPelaajat;
        private System.Windows.Forms.Button btnValmis;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblVirhe;
        private System.Windows.Forms.ToolTip tpVihje;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tallennaJaLopetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lisääPelaajaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Label lblOhje;
        private System.Windows.Forms.Panel pnlJoukkueet;
        private System.Windows.Forms.ComboBox cbJoukkueet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider epVirhe;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tallennaJaLopetaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lisääPelaajaToolStripMenuItem1;
    }
}