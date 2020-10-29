namespace Harjoitustyö_Severi_Moisio
{
    partial class FrmPelaajaTilastot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPelaajaTilastot));
            this.cbJoukkueet = new System.Windows.Forms.ComboBox();
            this.lblOhje = new System.Windows.Forms.Label();
            this.dgwTilastot = new System.Windows.Forms.DataGridView();
            this.lblVoitot = new System.Windows.Forms.Label();
            this.lblVoitotluku = new System.Windows.Forms.Label();
            this.lblTappiotluku = new System.Windows.Forms.Label();
            this.lblTappiot = new System.Windows.Forms.Label();
            this.lblTasanluku = new System.Windows.Forms.Label();
            this.lblTAsan = new System.Windows.Forms.Label();
            this.pnlTiedot = new System.Windows.Forms.Panel();
            this.btnTakaisin = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblVirhe = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.takaisinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTilastot)).BeginInit();
            this.pnlTiedot.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbJoukkueet
            // 
            this.cbJoukkueet.FormattingEnabled = true;
            this.cbJoukkueet.Location = new System.Drawing.Point(15, 35);
            this.cbJoukkueet.Name = "cbJoukkueet";
            this.cbJoukkueet.Size = new System.Drawing.Size(138, 24);
            this.cbJoukkueet.TabIndex = 0;
            this.cbJoukkueet.TextChanged += new System.EventHandler(this.cbJoukkueet_TextChanged);
            // 
            // lblOhje
            // 
            this.lblOhje.AutoSize = true;
            this.lblOhje.Location = new System.Drawing.Point(12, 12);
            this.lblOhje.Name = "lblOhje";
            this.lblOhje.Size = new System.Drawing.Size(141, 17);
            this.lblOhje.TabIndex = 1;
            this.lblOhje.Text = "Valitse ensin joukkue";
            // 
            // dgwTilastot
            // 
            this.dgwTilastot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTilastot.Location = new System.Drawing.Point(183, 0);
            this.dgwTilastot.Name = "dgwTilastot";
            this.dgwTilastot.RowHeadersWidth = 51;
            this.dgwTilastot.RowTemplate.Height = 24;
            this.dgwTilastot.Size = new System.Drawing.Size(756, 585);
            this.dgwTilastot.TabIndex = 2;
            this.dgwTilastot.Visible = false;
            // 
            // lblVoitot
            // 
            this.lblVoitot.AutoSize = true;
            this.lblVoitot.Location = new System.Drawing.Point(3, 0);
            this.lblVoitot.Name = "lblVoitot";
            this.lblVoitot.Size = new System.Drawing.Size(52, 17);
            this.lblVoitot.TabIndex = 3;
            this.lblVoitot.Text = "Voitot :";
            // 
            // lblVoitotluku
            // 
            this.lblVoitotluku.AutoSize = true;
            this.lblVoitotluku.Location = new System.Drawing.Point(83, 0);
            this.lblVoitotluku.Name = "lblVoitotluku";
            this.lblVoitotluku.Size = new System.Drawing.Size(44, 17);
            this.lblVoitotluku.TabIndex = 4;
            this.lblVoitotluku.Text = "Voitot";
            // 
            // lblTappiotluku
            // 
            this.lblTappiotluku.AutoSize = true;
            this.lblTappiotluku.Location = new System.Drawing.Point(83, 28);
            this.lblTappiotluku.Name = "lblTappiotluku";
            this.lblTappiotluku.Size = new System.Drawing.Size(57, 17);
            this.lblTappiotluku.TabIndex = 6;
            this.lblTappiotluku.Text = "TAppiot";
            // 
            // lblTappiot
            // 
            this.lblTappiot.AutoSize = true;
            this.lblTappiot.Location = new System.Drawing.Point(3, 28);
            this.lblTappiot.Name = "lblTappiot";
            this.lblTappiot.Size = new System.Drawing.Size(64, 17);
            this.lblTappiot.TabIndex = 5;
            this.lblTappiot.Text = "Tappiot :";
            // 
            // lblTasanluku
            // 
            this.lblTasanluku.AutoSize = true;
            this.lblTasanluku.Location = new System.Drawing.Point(83, 57);
            this.lblTasanluku.Name = "lblTasanluku";
            this.lblTasanluku.Size = new System.Drawing.Size(43, 17);
            this.lblTasanluku.TabIndex = 8;
            this.lblTasanluku.Text = "tasan";
            // 
            // lblTAsan
            // 
            this.lblTAsan.AutoSize = true;
            this.lblTAsan.Location = new System.Drawing.Point(3, 57);
            this.lblTAsan.Name = "lblTAsan";
            this.lblTAsan.Size = new System.Drawing.Size(74, 17);
            this.lblTAsan.TabIndex = 7;
            this.lblTAsan.Text = "Tasapelit :";
            // 
            // pnlTiedot
            // 
            this.pnlTiedot.Controls.Add(this.lblVoitot);
            this.pnlTiedot.Controls.Add(this.lblTasanluku);
            this.pnlTiedot.Controls.Add(this.lblVoitotluku);
            this.pnlTiedot.Controls.Add(this.lblTAsan);
            this.pnlTiedot.Controls.Add(this.lblTappiot);
            this.pnlTiedot.Controls.Add(this.lblTappiotluku);
            this.pnlTiedot.Location = new System.Drawing.Point(15, 98);
            this.pnlTiedot.Name = "pnlTiedot";
            this.pnlTiedot.Size = new System.Drawing.Size(141, 87);
            this.pnlTiedot.TabIndex = 9;
            this.pnlTiedot.Visible = false;
            // 
            // btnTakaisin
            // 
            this.btnTakaisin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTakaisin.Location = new System.Drawing.Point(0, 544);
            this.btnTakaisin.Name = "btnTakaisin";
            this.btnTakaisin.Size = new System.Drawing.Size(183, 41);
            this.btnTakaisin.TabIndex = 10;
            this.btnTakaisin.Text = "Takaisin";
            this.btnTakaisin.UseVisualStyleBackColor = true;
            this.btnTakaisin.Click += new System.EventHandler(this.btnTakaisin_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblVirhe});
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(939, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblVirhe
            // 
            this.tsslblVirhe.ForeColor = System.Drawing.Color.Red;
            this.tsslblVirhe.Name = "tsslblVirhe";
            this.tsslblVirhe.Size = new System.Drawing.Size(120, 20);
            this.tsslblVirhe.Text = "Virhe ilmoitukset";
            this.tsslblVirhe.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takaisinToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 28);
            // 
            // takaisinToolStripMenuItem
            // 
            this.takaisinToolStripMenuItem.Name = "takaisinToolStripMenuItem";
            this.takaisinToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.takaisinToolStripMenuItem.Text = "Takaisin";
            this.takaisinToolStripMenuItem.Click += new System.EventHandler(this.btnTakaisin_Click);
            // 
            // FrmPelaajaTilastot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 610);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnTakaisin);
            this.Controls.Add(this.pnlTiedot);
            this.Controls.Add(this.dgwTilastot);
            this.Controls.Add(this.lblOhje);
            this.Controls.Add(this.cbJoukkueet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(957, 657);
            this.MinimumSize = new System.Drawing.Size(957, 657);
            this.Name = "FrmPelaajaTilastot";
            this.Text = "JOUKKUE KOHTAISET TILASTOT";
            this.Load += new System.EventHandler(this.FrmPelaajaTilastot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTilastot)).EndInit();
            this.pnlTiedot.ResumeLayout(false);
            this.pnlTiedot.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbJoukkueet;
        private System.Windows.Forms.Label lblOhje;
        private System.Windows.Forms.DataGridView dgwTilastot;
        private System.Windows.Forms.Label lblVoitot;
        private System.Windows.Forms.Label lblVoitotluku;
        private System.Windows.Forms.Label lblTappiotluku;
        private System.Windows.Forms.Label lblTappiot;
        private System.Windows.Forms.Label lblTasanluku;
        private System.Windows.Forms.Label lblTAsan;
        private System.Windows.Forms.Panel pnlTiedot;
        private System.Windows.Forms.Button btnTakaisin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblVirhe;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem takaisinToolStripMenuItem;
    }
}