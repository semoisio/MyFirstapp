namespace Harjoitustyö_Severi_Moisio
{
    partial class FrmTilastot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTilastot));
            this.dgwPelit = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takaisinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lbKotiajat = new System.Windows.Forms.ListBox();
            this.lblKotimaalit = new System.Windows.Forms.Label();
            this.lblVierasmaalit = new System.Windows.Forms.Label();
            this.lbVierasajat = new System.Windows.Forms.ListBox();
            this.lblOhje = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbLaji = new System.Windows.Forms.PictureBox();
            this.btnTakaisin = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.takaisinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPelit)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLaji)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwPelit
            // 
            this.dgwPelit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPelit.Location = new System.Drawing.Point(12, 82);
            this.dgwPelit.Name = "dgwPelit";
            this.dgwPelit.RowHeadersWidth = 51;
            this.dgwPelit.RowTemplate.Height = 24;
            this.dgwPelit.Size = new System.Drawing.Size(1089, 452);
            this.dgwPelit.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dgwPelit, "Klikkaa ottelua niin saat maalintekoajat näkyviin");
            this.dgwPelit.Click += new System.EventHandler(this.dgwPelit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jepToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1311, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jepToolStripMenuItem
            // 
            this.jepToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takaisinToolStripMenuItem});
            this.jepToolStripMenuItem.Name = "jepToolStripMenuItem";
            this.jepToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.jepToolStripMenuItem.Text = "Tiedosto";
            // 
            // takaisinToolStripMenuItem
            // 
            this.takaisinToolStripMenuItem.Name = "takaisinToolStripMenuItem";
            this.takaisinToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.takaisinToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.takaisinToolStripMenuItem.Text = "Takaisin";
            this.takaisinToolStripMenuItem.Click += new System.EventHandler(this.btnTakaisin_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1311, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Takaisin";
            this.toolStripButton1.Click += new System.EventHandler(this.btnTakaisin_Click);
            // 
            // lbKotiajat
            // 
            this.lbKotiajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKotiajat.FormattingEnabled = true;
            this.lbKotiajat.ItemHeight = 20;
            this.lbKotiajat.Location = new System.Drawing.Point(1107, 107);
            this.lbKotiajat.Name = "lbKotiajat";
            this.lbKotiajat.Size = new System.Drawing.Size(189, 84);
            this.lbKotiajat.TabIndex = 4;
            // 
            // lblKotimaalit
            // 
            this.lblKotimaalit.AutoSize = true;
            this.lblKotimaalit.Location = new System.Drawing.Point(1104, 84);
            this.lblKotimaalit.Name = "lblKotimaalit";
            this.lblKotimaalit.Size = new System.Drawing.Size(192, 17);
            this.lblKotimaalit.TabIndex = 5;
            this.lblKotimaalit.Text = "Kotijoukkueen maalintekoajat";
            // 
            // lblVierasmaalit
            // 
            this.lblVierasmaalit.AutoSize = true;
            this.lblVierasmaalit.Location = new System.Drawing.Point(1104, 216);
            this.lblVierasmaalit.Name = "lblVierasmaalit";
            this.lblVierasmaalit.Size = new System.Drawing.Size(208, 17);
            this.lblVierasmaalit.TabIndex = 7;
            this.lblVierasmaalit.Text = "Vierasjoukkueen maalintekoajat";
            // 
            // lbVierasajat
            // 
            this.lbVierasajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVierasajat.FormattingEnabled = true;
            this.lbVierasajat.ItemHeight = 20;
            this.lbVierasajat.Location = new System.Drawing.Point(1107, 236);
            this.lbVierasajat.Name = "lbVierasajat";
            this.lbVierasajat.Size = new System.Drawing.Size(189, 84);
            this.lbVierasajat.TabIndex = 6;
            // 
            // lblOhje
            // 
            this.lblOhje.AutoSize = true;
            this.lblOhje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOhje.Location = new System.Drawing.Point(12, 61);
            this.lblOhje.Name = "lblOhje";
            this.lblOhje.Size = new System.Drawing.Size(623, 18);
            this.lblOhje.TabIndex = 8;
            this.lblOhje.Text = "Valitse listalta rivi ja kyseisen ottelun maalintekoajat tulevat näkymään vieress" +
    "ä oleviin ruutuihin\r\n";
            // 
            // pbLaji
            // 
            this.pbLaji.Image = global::Harjoitustyö_Severi_Moisio.Properties.Resources.jääkiekko;
            this.pbLaji.Location = new System.Drawing.Point(1107, 342);
            this.pbLaji.Name = "pbLaji";
            this.pbLaji.Size = new System.Drawing.Size(189, 192);
            this.pbLaji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLaji.TabIndex = 9;
            this.pbLaji.TabStop = false;
            // 
            // btnTakaisin
            // 
            this.btnTakaisin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakaisin.Location = new System.Drawing.Point(1181, 540);
            this.btnTakaisin.Name = "btnTakaisin";
            this.btnTakaisin.Size = new System.Drawing.Size(115, 55);
            this.btnTakaisin.TabIndex = 10;
            this.btnTakaisin.Text = "Takaisin";
            this.btnTakaisin.UseVisualStyleBackColor = true;
            this.btnTakaisin.Click += new System.EventHandler(this.btnTakaisin_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takaisinToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 28);
            // 
            // takaisinToolStripMenuItem1
            // 
            this.takaisinToolStripMenuItem1.Name = "takaisinToolStripMenuItem1";
            this.takaisinToolStripMenuItem1.Size = new System.Drawing.Size(129, 24);
            this.takaisinToolStripMenuItem1.Text = "Takaisin";
            this.takaisinToolStripMenuItem1.Click += new System.EventHandler(this.btnTakaisin_Click);
            // 
            // FrmTilastot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 599);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnTakaisin);
            this.Controls.Add(this.pbLaji);
            this.Controls.Add(this.lblOhje);
            this.Controls.Add(this.lblVierasmaalit);
            this.Controls.Add(this.lbVierasajat);
            this.Controls.Add(this.lblKotimaalit);
            this.Controls.Add(this.lbKotiajat);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgwPelit);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1329, 646);
            this.MinimumSize = new System.Drawing.Size(1329, 646);
            this.Name = "FrmTilastot";
            this.Text = "Peli tilastot";
            this.Load += new System.EventHandler(this.FrmTilastot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPelit)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLaji)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPelit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jepToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListBox lbKotiajat;
        private System.Windows.Forms.Label lblKotimaalit;
        private System.Windows.Forms.Label lblVierasmaalit;
        private System.Windows.Forms.ListBox lbVierasajat;
        private System.Windows.Forms.Label lblOhje;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pbLaji;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button btnTakaisin;
        private System.Windows.Forms.ToolStripMenuItem takaisinToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem takaisinToolStripMenuItem1;
    }
}