using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using MinunFunktiot;

namespace Harjoitustyö_Severi_Moisio
{
    public partial class FrmAloitus : Form
    {
        bool muokkaus;
        string laji; // käytetään välittämään tieto lajista seuraavalle joukkueen lisäys lomakkeelle.
        List<string> joukkueet = new List<string>();
        List<Joukkue> joukkueJaPelaajat = new List<Joukkue>();
        string osJaakiekko = "jaakiekkoJoukkueet.XML";
        string osJalkapallo = "jalkapalloJoukkueet.XML";
        string osSalibandy = "salibandyJoukkueet.XML";
        public FrmAloitus()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Tämä päästää vaihtamaan lajia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVaihda_Click(object sender, EventArgs e)
        {
            pnlJoukkueet.Visible = false;
            pnlAloitus.Enabled = true;
            lblOhje.Visible = false;
            lblOhje.Text = "Joukkueita ei ole vielä lisätty. Aloita lisäämällä joukkueet";
            lblOhje.ForeColor = Color.OliveDrab;
            cbKotijoukkue.Items.Clear();
            cbVierasjoukkue.Items.Clear();
            cbKotijoukkue.Text = "";
            cbVierasjoukkue.Text = "";

        }
        /// <summary>
        /// Avataan joukkueiden valinta näkymä. Katsotaan mikä laji valittuna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValitseJoukkueet_Click(object sender, EventArgs e)
        {
            try
            {
                tsslblVirhe.Visible = false;
                int i;
                joukkueet.Clear();
                if (rbJaakiekko.Checked == true)
                {
                    pnlJoukkueet.Visible = true;
                    pnlAloitus.Enabled = false;
                    laji = "jaakiekko";
                    if (File.Exists(osJaakiekko))
                    {
                        joukkueet = Funktioni.PuraXML(osJaakiekko); // oma funktio
                        for (i = 0; i < joukkueet.Count; i++)
                        {
                            cbKotijoukkue.Items.Add(joukkueet[i]);
                            cbVierasjoukkue.Items.Add(joukkueet[i]);
                        }
                    }
                    else
                    {
                        lblOhje.Visible = true;
                    }
                }

                else if (rbJalkapallo.Checked == true)
                {
                    pnlJoukkueet.Visible = true;
                    pnlAloitus.Enabled = false;
                    laji = "jalkapallo";
                    if (File.Exists(osJalkapallo))
                    {
                        joukkueet = Funktioni.PuraXML(osJalkapallo); // oma funktio
                        for (i = 0; i < joukkueet.Count; i++)
                        {
                            cbKotijoukkue.Items.Add(joukkueet[i]);
                            cbVierasjoukkue.Items.Add(joukkueet[i]);
                        }
                    }
                    else
                    {
                        lblOhje.Visible = true;
                    }
                }
                else if (rbSalibandy.Checked == true)
                {
                    pnlJoukkueet.Visible = true;
                    pnlAloitus.Enabled = false;
                    laji = "salibandy";
                    if (File.Exists(osSalibandy))
                    {
                        joukkueet = Funktioni.PuraXML(osSalibandy); // oma funktio
                        for (i = 0; i < joukkueet.Count; i++)
                        {
                            cbKotijoukkue.Items.Add(joukkueet[i]);
                            cbVierasjoukkue.Items.Add(joukkueet[i]);
                        }
                    }
                    else
                    {
                        lblOhje.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Avataan uusi formi ja sen sulkeuduttua päivitetään joukkueet comboboxeihin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLisaajoukkue_Click(object sender, EventArgs e)
        {
            try
            {
                muokkaus = false;
                Frm1JoukkueenLisäys lisa = new Frm1JoukkueenLisäys(laji, joukkueet, muokkaus);
                lisa.ShowDialog();
                int i;
                // alla lisätään joukkueet comboboxeihin
                if (laji == "jaakiekko")
                {
                    if (File.Exists(osJaakiekko))
                    {
                        cbKotijoukkue.Items.Clear();
                        cbVierasjoukkue.Items.Clear();
                        joukkueet = Funktioni.PuraXML(osJaakiekko);
                        for (i = 0; i < joukkueet.Count; i++)
                        {
                            cbKotijoukkue.Items.Add(joukkueet[i]);
                            cbVierasjoukkue.Items.Add(joukkueet[i]);
                        }
                    }
                }
                else if (laji == "jalkapallo")
                {
                    if (File.Exists(osJalkapallo))
                    {
                        cbKotijoukkue.Items.Clear();
                        cbVierasjoukkue.Items.Clear();
                        joukkueet = Funktioni.PuraXML(osJalkapallo);
                        for (i = 0; i < joukkueet.Count; i++)
                        {
                            cbKotijoukkue.Items.Add(joukkueet[i]);
                            cbVierasjoukkue.Items.Add(joukkueet[i]);
                        }
                    }
                }
                else
                {
                    if (File.Exists(osSalibandy))
                    {
                        cbKotijoukkue.Items.Clear();
                        cbVierasjoukkue.Items.Clear();
                        joukkueet = Funktioni.PuraXML(osSalibandy);
                        for (i = 0; i < joukkueet.Count; i++)
                        {
                            cbKotijoukkue.Items.Add(joukkueet[i]);
                            cbVierasjoukkue.Items.Add(joukkueet[i]);
                        }
                    }
                }
                // Alla tarkastetaan onko tarpeeksi joukkueita lisätty. Jos ei annetaan ohjeet
                if (cbKotijoukkue.Items.Count < 2)
                {
                    lblOhje.Text = "Lisää vähintään 2 joukkuetta";
                    lblOhje.ForeColor = Color.Red;
                }
                else
                {
                    lblOhje.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Tehdään eka tarvittavat virheen tarkistukset, jos kaikki kunnossa aloitetaan peli.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAloita_Click(object sender, EventArgs e)
        {
            try
            {
                bool koti = File.Exists(cbKotijoukkue.Text + ".XML");
                bool vieras = File.Exists(cbVierasjoukkue.Text + ".XML");
                if (cbKotijoukkue.Text.Length == 0)
                {
                    lblVirhe.Visible = true;
                    lblVirhe.Text = "Valitse ensin molemmat joukkueet";
                }
                else if (cbVierasjoukkue.Text.Length == 0)
                {
                    lblVirhe.Visible = true;
                    lblVirhe.Text = "Valitse ensin molemmat joukkueet";
                }
                else if (cbKotijoukkue.Text == cbVierasjoukkue.Text)
                {
                    lblVirhe.Visible = true;
                    lblVirhe.Text = "Molemmat joukkueet eivät voi olla samat";
                }
                else if (File.Exists(cbKotijoukkue.Text + ".XML") && File.Exists(cbVierasjoukkue.Text + ".XML"))
                { //aloitetaan peli ja laitetaan aloitus näkymä alkutilaan
                    lblVirhe.Visible = false;
                    FrmPeli peli = new FrmPeli(cbKotijoukkue.Text, cbVierasjoukkue.Text, laji);
                    peli.ShowDialog();
                    pnlJoukkueet.Visible = false;
                    pnlAloitus.Enabled = true;
                    cbKotijoukkue.Items.Clear();
                    cbVierasjoukkue.Items.Clear();
                    cbKotijoukkue.Text = string.Empty;
                    cbVierasjoukkue.Text = string.Empty;
                }
                else
                {
                    if (koti == false)
                    {
                        tsslblVirhe.Visible = true;
                        tsslblVirhe.Text = "Kotijoukkueen tiedot on käyty poistamassa. Käy päivittämässä tiedot";
                        tsslblVirhe.ForeColor = Color.Red;
                    }
                    else if (vieras == false)
                    {
                        tsslblVirhe.Visible = true;
                        tsslblVirhe.Text = "Vierasjoukkueen tiedot on käyty poistamassa. Käy päivittämässä tiedot";
                        tsslblVirhe.ForeColor = Color.Red;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Tästä päästään pelienyhteenveto tilasto formille
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (rbJaakiekko.Checked == true)
            {
                laji = "jaakiekko";
                tsslblVirhe.Visible = false;
            }
            else if (rbJalkapallo.Checked == true)
            {
                laji = "jalkapallo";
                tsslblVirhe.Visible = false;
            }
            else if (rbSalibandy.Checked == true)
            {
                laji = "salibandy";
                tsslblVirhe.Visible = false;
            }
            else
            {
                tsslblVirhe.Visible = true;
                tsslblVirhe.Text = "Valitse eka laji";
                tsslblVirhe.ForeColor = Color.Red;
            }
            if (File.Exists(laji + "Pelit.XML") && laji != null)
            {
                tsslblVirhe.Visible = false;
                FrmTilastot tilastot = new FrmTilastot(laji);
                tilastot.ShowDialog();
            }
            else if ((File.Exists(laji + "Pelit.XML")) == false && laji != null)
            {
                tsslblVirhe.Visible = true;
                tsslblVirhe.Text = "Yhtään lajin peliä ei ole vielä pelattu";
                tsslblVirhe.ForeColor = Color.Red;
            }
        }
        /// <summary>
        /// Avataan joukkuekojtaiset tilastot formi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPelaajaTilastot_Click(object sender, EventArgs e)
        {
            if (rbJaakiekko.Checked == true)
            {
                laji = "jaakiekko";
                tsslblVirhe.Visible = false;
                FrmPelaajaTilastot tila = new FrmPelaajaTilastot(laji);
                tila.ShowDialog();
            }
            else if (rbJalkapallo.Checked == true)
            {
                laji = "jalkapallo";
                tsslblVirhe.Visible = false;
                FrmPelaajaTilastot tila = new FrmPelaajaTilastot(laji);
                tila.ShowDialog();
            }
            else if (rbSalibandy.Checked == true)
            {
                laji = "salibandy";
                tsslblVirhe.Visible = false;
                FrmPelaajaTilastot tila = new FrmPelaajaTilastot(laji);
                tila.ShowDialog();
            }
            else
            {
                tsslblVirhe.Visible = true;
                tsslblVirhe.Text = "Valitse eka laji";
                tsslblVirhe.ForeColor = Color.Red;
            }                      
        }
        /// <summary>
        /// Jos sulkemassa sovellusta kysytään varmuus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAloitus_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Haluatko varmasti poistua sovelluksesta?", "INFO", MessageBoxButtons.YesNo);

            if (DialogResult.No == dr)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Päästään joukkueen lisäys formille muokkaus tilassa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                muokkaus = true;
                Frm1JoukkueenLisäys lisa = new Frm1JoukkueenLisäys(laji, joukkueet, muokkaus);
                lisa.ShowDialog();
                int i;
                if (laji == "jaakiekko")
                {
                    if (File.Exists(osJaakiekko))
                    {
                        cbKotijoukkue.Items.Clear();
                        cbVierasjoukkue.Items.Clear();
                        joukkueet = Funktioni.PuraXML(osJaakiekko);
                        for (i = 0; i < joukkueet.Count; i++)
                        {
                            cbKotijoukkue.Items.Add(joukkueet[i]);
                            cbVierasjoukkue.Items.Add(joukkueet[i]);
                        }
                    }

                }
                else if (laji == "jalkapallo")
                {
                    if (File.Exists(osJalkapallo))
                    {
                        cbKotijoukkue.Items.Clear();
                        cbVierasjoukkue.Items.Clear();
                        joukkueet = Funktioni.PuraXML(osJalkapallo);
                        for (i = 0; i < joukkueet.Count; i++)
                        {
                            cbKotijoukkue.Items.Add(joukkueet[i]);
                            cbVierasjoukkue.Items.Add(joukkueet[i]);
                        }
                    }
                }
                else
                {
                    if (File.Exists(osSalibandy))
                    {
                        cbKotijoukkue.Items.Clear();
                        cbVierasjoukkue.Items.Clear();
                        joukkueet = Funktioni.PuraXML(osSalibandy);
                        for (i = 0; i < joukkueet.Count; i++)
                        {
                            cbKotijoukkue.Items.Add(joukkueet[i]);
                            cbVierasjoukkue.Items.Add(joukkueet[i]);
                        }
                    }
                }
                if (cbKotijoukkue.Items.Count < 2)
                {
                    lblOhje.Text = "Lisää vähintään 2 joukkuetta";
                    lblOhje.ForeColor = Color.Red;
                }
                else
                {
                    lblOhje.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Toolstripin kautta mahdollista sulkea sovellus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suljeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Haluatko varmasti poistua sovelluksesta?", "INFO", MessageBoxButtons.YesNo);

            if (DialogResult.Yes == dr)
            {
                Application.Exit();
            }

        }
    }
}
