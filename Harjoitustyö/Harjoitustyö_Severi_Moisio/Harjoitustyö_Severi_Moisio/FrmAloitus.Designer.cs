namespace Harjoitustyö_Severi_Moisio
{
    partial class FrmAloitus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAloitus));
            this.pnlAloitus = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pelienYhteenvetoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tilastotToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vaihdaLajiaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnValitseJoukkueet = new System.Windows.Forms.Button();
            this.gbLaji = new System.Windows.Forms.GroupBox();
            this.rbSalibandy = new System.Windows.Forms.RadioButton();
            this.rbJalkapallo = new System.Windows.Forms.RadioButton();
            this.rbJaakiekko = new System.Windows.Forms.RadioButton();
            this.lblAloitusOhje = new System.Windows.Forms.Label();
            this.btnPelienYhteenveto = new System.Windows.Forms.Button();
            this.btnPelaajaTilastot = new System.Windows.Forms.Button();
            this.pnlJoukkueet = new System.Windows.Forms.Panel();
            this.btnMuokkaaJoukkuetta = new System.Windows.Forms.Button();
            this.lblVirhe = new System.Windows.Forms.Label();
            this.lblOhje = new System.Windows.Forms.Label();
            this.btnAloita = new System.Windows.Forms.Button();
            this.btnVaihda = new System.Windows.Forms.Button();
            this.btnLisaajoukkue = new System.Windows.Forms.Button();
            this.cbVierasjoukkue = new System.Windows.Forms.ComboBox();
            this.cbKotijoukkue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblVirhe = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pelienYhteenvetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tilastotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vaihdaLajiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suljeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlAloitus.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.gbLaji.SuspendLayout();
            this.pnlJoukkueet.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAloitus
            // 
            this.pnlAloitus.ContextMenuStrip = this.contextMenuStrip1;
            this.pnlAloitus.Controls.Add(this.btnValitseJoukkueet);
            this.pnlAloitus.Controls.Add(this.gbLaji);
            this.pnlAloitus.Controls.Add(this.lblAloitusOhje);
            resources.ApplyResources(this.pnlAloitus, "pnlAloitus");
            this.pnlAloitus.Name = "pnlAloitus";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pelienYhteenvetoToolStripMenuItem1,
            this.tilastotToolStripMenuItem1,
            this.vaihdaLajiaToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // pelienYhteenvetoToolStripMenuItem1
            // 
            this.pelienYhteenvetoToolStripMenuItem1.Name = "pelienYhteenvetoToolStripMenuItem1";
            resources.ApplyResources(this.pelienYhteenvetoToolStripMenuItem1, "pelienYhteenvetoToolStripMenuItem1");
            this.pelienYhteenvetoToolStripMenuItem1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tilastotToolStripMenuItem1
            // 
            this.tilastotToolStripMenuItem1.Name = "tilastotToolStripMenuItem1";
            resources.ApplyResources(this.tilastotToolStripMenuItem1, "tilastotToolStripMenuItem1");
            this.tilastotToolStripMenuItem1.Click += new System.EventHandler(this.btnPelaajaTilastot_Click);
            // 
            // vaihdaLajiaToolStripMenuItem1
            // 
            this.vaihdaLajiaToolStripMenuItem1.Name = "vaihdaLajiaToolStripMenuItem1";
            resources.ApplyResources(this.vaihdaLajiaToolStripMenuItem1, "vaihdaLajiaToolStripMenuItem1");
            this.vaihdaLajiaToolStripMenuItem1.Click += new System.EventHandler(this.btnVaihda_Click);
            // 
            // btnValitseJoukkueet
            // 
            this.btnValitseJoukkueet.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.btnValitseJoukkueet, "btnValitseJoukkueet");
            this.btnValitseJoukkueet.Name = "btnValitseJoukkueet";
            this.toolTip1.SetToolTip(this.btnValitseJoukkueet, resources.GetString("btnValitseJoukkueet.ToolTip"));
            this.btnValitseJoukkueet.UseVisualStyleBackColor = true;
            this.btnValitseJoukkueet.Click += new System.EventHandler(this.btnValitseJoukkueet_Click);
            // 
            // gbLaji
            // 
            this.gbLaji.ContextMenuStrip = this.contextMenuStrip1;
            this.gbLaji.Controls.Add(this.rbSalibandy);
            this.gbLaji.Controls.Add(this.rbJalkapallo);
            this.gbLaji.Controls.Add(this.rbJaakiekko);
            resources.ApplyResources(this.gbLaji, "gbLaji");
            this.gbLaji.Name = "gbLaji";
            this.gbLaji.TabStop = false;
            this.toolTip1.SetToolTip(this.gbLaji, resources.GetString("gbLaji.ToolTip"));
            // 
            // rbSalibandy
            // 
            resources.ApplyResources(this.rbSalibandy, "rbSalibandy");
            this.rbSalibandy.Name = "rbSalibandy";
            this.rbSalibandy.UseVisualStyleBackColor = true;
            // 
            // rbJalkapallo
            // 
            resources.ApplyResources(this.rbJalkapallo, "rbJalkapallo");
            this.rbJalkapallo.Name = "rbJalkapallo";
            this.rbJalkapallo.UseVisualStyleBackColor = true;
            // 
            // rbJaakiekko
            // 
            resources.ApplyResources(this.rbJaakiekko, "rbJaakiekko");
            this.rbJaakiekko.Name = "rbJaakiekko";
            this.rbJaakiekko.UseVisualStyleBackColor = true;
            // 
            // lblAloitusOhje
            // 
            resources.ApplyResources(this.lblAloitusOhje, "lblAloitusOhje");
            this.lblAloitusOhje.Name = "lblAloitusOhje";
            // 
            // btnPelienYhteenveto
            // 
            this.btnPelienYhteenveto.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.btnPelienYhteenveto, "btnPelienYhteenveto");
            this.btnPelienYhteenveto.Name = "btnPelienYhteenveto";
            this.toolTip1.SetToolTip(this.btnPelienYhteenveto, resources.GetString("btnPelienYhteenveto.ToolTip"));
            this.btnPelienYhteenveto.UseVisualStyleBackColor = true;
            this.btnPelienYhteenveto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPelaajaTilastot
            // 
            this.btnPelaajaTilastot.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.btnPelaajaTilastot, "btnPelaajaTilastot");
            this.btnPelaajaTilastot.Name = "btnPelaajaTilastot";
            this.toolTip1.SetToolTip(this.btnPelaajaTilastot, resources.GetString("btnPelaajaTilastot.ToolTip"));
            this.btnPelaajaTilastot.UseVisualStyleBackColor = true;
            this.btnPelaajaTilastot.Click += new System.EventHandler(this.btnPelaajaTilastot_Click);
            // 
            // pnlJoukkueet
            // 
            this.pnlJoukkueet.ContextMenuStrip = this.contextMenuStrip1;
            this.pnlJoukkueet.Controls.Add(this.btnMuokkaaJoukkuetta);
            this.pnlJoukkueet.Controls.Add(this.lblVirhe);
            this.pnlJoukkueet.Controls.Add(this.lblOhje);
            this.pnlJoukkueet.Controls.Add(this.btnAloita);
            this.pnlJoukkueet.Controls.Add(this.btnVaihda);
            this.pnlJoukkueet.Controls.Add(this.btnLisaajoukkue);
            this.pnlJoukkueet.Controls.Add(this.cbVierasjoukkue);
            this.pnlJoukkueet.Controls.Add(this.cbKotijoukkue);
            this.pnlJoukkueet.Controls.Add(this.label1);
            this.pnlJoukkueet.Controls.Add(this.label2);
            this.pnlJoukkueet.Controls.Add(this.label3);
            this.pnlJoukkueet.Controls.Add(this.label4);
            resources.ApplyResources(this.pnlJoukkueet, "pnlJoukkueet");
            this.pnlJoukkueet.Name = "pnlJoukkueet";
            // 
            // btnMuokkaaJoukkuetta
            // 
            resources.ApplyResources(this.btnMuokkaaJoukkuetta, "btnMuokkaaJoukkuetta");
            this.btnMuokkaaJoukkuetta.Name = "btnMuokkaaJoukkuetta";
            this.toolTip1.SetToolTip(this.btnMuokkaaJoukkuetta, resources.GetString("btnMuokkaaJoukkuetta.ToolTip"));
            this.btnMuokkaaJoukkuetta.UseVisualStyleBackColor = true;
            this.btnMuokkaaJoukkuetta.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblVirhe
            // 
            resources.ApplyResources(this.lblVirhe, "lblVirhe");
            this.lblVirhe.ContextMenuStrip = this.contextMenuStrip1;
            this.lblVirhe.ForeColor = System.Drawing.Color.Red;
            this.lblVirhe.Name = "lblVirhe";
            // 
            // lblOhje
            // 
            resources.ApplyResources(this.lblOhje, "lblOhje");
            this.lblOhje.ContextMenuStrip = this.contextMenuStrip1;
            this.lblOhje.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblOhje.Name = "lblOhje";
            // 
            // btnAloita
            // 
            this.btnAloita.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.btnAloita, "btnAloita");
            this.btnAloita.Name = "btnAloita";
            this.btnAloita.UseVisualStyleBackColor = true;
            this.btnAloita.Click += new System.EventHandler(this.btnAloita_Click);
            // 
            // btnVaihda
            // 
            this.btnVaihda.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.btnVaihda, "btnVaihda");
            this.btnVaihda.Name = "btnVaihda";
            this.toolTip1.SetToolTip(this.btnVaihda, resources.GetString("btnVaihda.ToolTip"));
            this.btnVaihda.UseVisualStyleBackColor = true;
            this.btnVaihda.Click += new System.EventHandler(this.btnVaihda_Click);
            // 
            // btnLisaajoukkue
            // 
            this.btnLisaajoukkue.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.btnLisaajoukkue, "btnLisaajoukkue");
            this.btnLisaajoukkue.Name = "btnLisaajoukkue";
            this.btnLisaajoukkue.UseVisualStyleBackColor = true;
            this.btnLisaajoukkue.Click += new System.EventHandler(this.btnLisaajoukkue_Click);
            // 
            // cbVierasjoukkue
            // 
            this.cbVierasjoukkue.ContextMenuStrip = this.contextMenuStrip1;
            this.cbVierasjoukkue.FormattingEnabled = true;
            resources.ApplyResources(this.cbVierasjoukkue, "cbVierasjoukkue");
            this.cbVierasjoukkue.Name = "cbVierasjoukkue";
            this.toolTip1.SetToolTip(this.cbVierasjoukkue, resources.GetString("cbVierasjoukkue.ToolTip"));
            // 
            // cbKotijoukkue
            // 
            this.cbKotijoukkue.ContextMenuStrip = this.contextMenuStrip1;
            this.cbKotijoukkue.FormattingEnabled = true;
            resources.ApplyResources(this.cbKotijoukkue, "cbKotijoukkue");
            this.cbKotijoukkue.Name = "cbKotijoukkue";
            this.toolTip1.SetToolTip(this.cbKotijoukkue, resources.GetString("cbKotijoukkue.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ContextMenuStrip = this.contextMenuStrip1;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ContextMenuStrip = this.contextMenuStrip1;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ContextMenuStrip = this.contextMenuStrip1;
            this.label4.Name = "label4";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblVirhe});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // tsslblVirhe
            // 
            this.tsslblVirhe.Name = "tsslblVirhe";
            resources.ApplyResources(this.tsslblVirhe, "tsslblVirhe");
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Controls.Add(this.btnPelaajaTilastot);
            this.panel1.Controls.Add(this.btnPelienYhteenveto);
            this.panel1.Controls.Add(this.pnlJoukkueet);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.pnlAloitus);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jepToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // jepToolStripMenuItem
            // 
            this.jepToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pelienYhteenvetoToolStripMenuItem,
            this.tilastotToolStripMenuItem,
            this.vaihdaLajiaToolStripMenuItem,
            this.suljeToolStripMenuItem});
            this.jepToolStripMenuItem.Name = "jepToolStripMenuItem";
            resources.ApplyResources(this.jepToolStripMenuItem, "jepToolStripMenuItem");
            // 
            // pelienYhteenvetoToolStripMenuItem
            // 
            this.pelienYhteenvetoToolStripMenuItem.Name = "pelienYhteenvetoToolStripMenuItem";
            resources.ApplyResources(this.pelienYhteenvetoToolStripMenuItem, "pelienYhteenvetoToolStripMenuItem");
            this.pelienYhteenvetoToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // tilastotToolStripMenuItem
            // 
            this.tilastotToolStripMenuItem.Name = "tilastotToolStripMenuItem";
            resources.ApplyResources(this.tilastotToolStripMenuItem, "tilastotToolStripMenuItem");
            this.tilastotToolStripMenuItem.Click += new System.EventHandler(this.btnPelaajaTilastot_Click);
            // 
            // vaihdaLajiaToolStripMenuItem
            // 
            this.vaihdaLajiaToolStripMenuItem.Name = "vaihdaLajiaToolStripMenuItem";
            resources.ApplyResources(this.vaihdaLajiaToolStripMenuItem, "vaihdaLajiaToolStripMenuItem");
            this.vaihdaLajiaToolStripMenuItem.Click += new System.EventHandler(this.btnVaihda_Click);
            // 
            // suljeToolStripMenuItem
            // 
            this.suljeToolStripMenuItem.Name = "suljeToolStripMenuItem";
            resources.ApplyResources(this.suljeToolStripMenuItem, "suljeToolStripMenuItem");
            this.suljeToolStripMenuItem.Click += new System.EventHandler(this.suljeToolStripMenuItem_Click);
            // 
            // FrmAloitus
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Name = "FrmAloitus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAloitus_FormClosing);
            this.pnlAloitus.ResumeLayout(false);
            this.pnlAloitus.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbLaji.ResumeLayout(false);
            this.gbLaji.PerformLayout();
            this.pnlJoukkueet.ResumeLayout(false);
            this.pnlJoukkueet.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAloitus;
        private System.Windows.Forms.Button btnValitseJoukkueet;
        private System.Windows.Forms.GroupBox gbLaji;
        private System.Windows.Forms.RadioButton rbSalibandy;
        private System.Windows.Forms.RadioButton rbJalkapallo;
        private System.Windows.Forms.RadioButton rbJaakiekko;
        private System.Windows.Forms.Label lblAloitusOhje;
        private System.Windows.Forms.Button btnPelienYhteenveto;
        private System.Windows.Forms.Button btnPelaajaTilastot;
        private System.Windows.Forms.Panel pnlJoukkueet;
        private System.Windows.Forms.Label lblVirhe;
        private System.Windows.Forms.Label lblOhje;
        private System.Windows.Forms.Button btnAloita;
        private System.Windows.Forms.Button btnVaihda;
        private System.Windows.Forms.Button btnLisaajoukkue;
        private System.Windows.Forms.ComboBox cbVierasjoukkue;
        private System.Windows.Forms.ComboBox cbKotijoukkue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblVirhe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pelienYhteenvetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tilastotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vaihdaLajiaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pelienYhteenvetoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tilastotToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vaihdaLajiaToolStripMenuItem1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnMuokkaaJoukkuetta;
        private System.Windows.Forms.ToolStripMenuItem suljeToolStripMenuItem;
    }
}

