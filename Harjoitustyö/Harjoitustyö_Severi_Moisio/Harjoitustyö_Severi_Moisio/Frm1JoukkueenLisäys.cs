using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinunFunktiot;
using System.IO;

namespace Harjoitustyö_Severi_Moisio
{
    public partial class Frm1JoukkueenLisäys : Form
    {
        bool muokkaus, tallennettu = false;
        string laji;
        int voitot, tappiot, tasapelit, alkuperainen; // käytetään muokkaustilassa
        List<string> joukkueet = new List<string>();
        List<int> numtarkistus = new List<int>();// käytetään tarkistamaan käytetyt numerot
        List<Joukkue> joukkueJaPelaajat = new List<Joukkue>(); //ALKUPERÄINEN JOUKKUE
        List<Joukkue> muokattujoukkue = new List<Joukkue>();// tähän lisätään joukkue muokkaus tilassa
        /// <summary>
        /// Otetaan välitetyt tiedot haltuun
        /// </summary>
        /// <param name="l"></param>
        /// <param name="k"></param>
        /// <param name="muok"></param>
        public Frm1JoukkueenLisäys(string l, List<string> k, bool muok)
        {
            // Alla otetaan haltuun välitetyt tiedot
            InitializeComponent();
            laji = l;
            joukkueet = k;
            muokkaus = muok;
        }
        /// <summary>
        /// Lisätään pelaaja listboxiin ja tarkistetaan ettei ole samaa numeroa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            int i;
            bool loytyi = false;
            string spelaaja;
            lbPelaajat.Visible = true;
            lblOhje.Visible = true;
            // Numeron tarkistus
            for (i = 0; i < numtarkistus.Count; i++)
            {
                 if (numtarkistus[i] == (int)nupNumero.Value)
                 {
                    loytyi = true;
                 }
            }
            if (tbEtunimi.Text.Length == 0 || tbSukunimi.Text.Length == 0)
            {
                tsslblVirhe.Text = "Pelaajan etu- ja sukunimi pakollinen";
                tsslblVirhe.Visible = true;
            }
            else if (loytyi == true)
            {
                tsslblVirhe.Text = "Samaa pelinumeroa ei voida käyttää";
                tsslblVirhe.Visible = true;
            }           
            else
            {
                spelaaja = tbEtunimi.Text.ToUpper() + " " + tbSukunimi.Text.ToUpper() + " " + nupNumero.Value.ToString();
                lbPelaajat.Items.Add(spelaaja);
                tsslblVirhe.Visible = false;
                numtarkistus.Add((int)nupNumero.Value); // listään numero tarkistus listaan
            }
        }
        /// <summary>
        /// Laitetaan joukkueen nimi TB pois käytöstä ettei vahingossa muokata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbJoukkue_Leave(object sender, EventArgs e)//tämä tee uudestaan ei leaven alle.
        {
            tbJoukkue.Enabled = false;
            btnMuokkaa.Visible = true;
        }
        /// <summary>
        /// lisätään joukkue ja pelaajat XML tiedostoon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValmis_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr;
                int i = 0;
                // varmistetaan halutaanko lopettaa vaikka kentät tyhjät
                if (tbJoukkue.Text.Length == 0 || lbPelaajat.Items.Count == 0)
                {
                    dr = MessageBox.Show("Et ole lisännyt joukkuetta ja pelaajia.\nHaluatko varmasti lopettaa?", "Info", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == dr)
                    {
                        tallennettu = true;
                        this.Close();
                    }
                }
                else
                {
                    tallennettu = true;
                    if (!File.Exists(tbJoukkue.Text.ToUpper() + ".XML"))
                    {
                        string[] taulu = new string[lbPelaajat.Items.Count];
                        string[] purettu = new string[3];
                        Joukkue j = default;
                        // tällä saadaan listboxin sisältä taulukkoon
                        foreach (string s in lbPelaajat.Items)
                        {
                            taulu[i] = s;
                            i += 1;
                        }
                        for (i = 0; i < lbPelaajat.Items.Count; i++)
                        {
                            purettu = taulu[i].Split(' '); // puretaan taulu 
                            j.nimi = tbJoukkue.Text.ToUpper();
                            j.voitot = 0;
                            j.tappiot = 0;
                            j.tasapelit = 0;
                            j.laji = laji;
                            j.pelaaja.etunimi = purettu[0];
                            j.pelaaja.sukunimi = purettu[1];
                            j.pelaaja.pelinumero = purettu[2];
                            j.pelaaja.pisteet.maalit = 0;
                            j.pelaaja.pisteet.syotot = 0;
                            joukkueJaPelaajat.Add(j);
                        }
                        j.KirjoitaXML(joukkueJaPelaajat, tbJoukkue.Text.ToUpper() + ".XML");
                        if (laji == "jaakiekko")
                        {
                            for (int ji = 0; ji < joukkueet.Count; ji++)
                            {
                                string s = joukkueet[ji];
                                if (s == tbJoukkue.Text.ToUpper())
                                {
                                    joukkueet.RemoveAt(ji);
                                    ji--;
                                }
                            }
                            joukkueet.Add(tbJoukkue.Text.ToUpper());
                            Funktioni.KirjoitaXML(joukkueet, "JaakiekkoJoukkueet.XML");
                        }
                        else if (laji == "jalkapallo")
                        {
                            joukkueet.Add(tbJoukkue.Text.ToUpper());
                            Funktioni.KirjoitaXML(joukkueet, "JalkapalloJoukkueet.XML");
                        }
                        else
                        {
                            joukkueet.Add(tbJoukkue.Text.ToUpper());
                            Funktioni.KirjoitaXML(joukkueet, "SalibandyJoukkueet.XML");
                        }
                        this.Close();
                    }
                    else
                    {
                        dr = MessageBox.Show("Joukkue on jo olemassa. Kirjoitetaanko päälle?", "Info", MessageBoxButtons.YesNo);
                        if (DialogResult.Yes == dr)
                        {

                            string[] taulu = new string[lbPelaajat.Items.Count];
                            string[] purettu = new string[3];
                            Joukkue j = default;
                            // tällä saadaan listboxin sisältä taulukkoon
                            foreach (string s in lbPelaajat.Items)
                            {
                                taulu[i] = s;
                                i += 1;
                            }
                            for (i = 0; i < lbPelaajat.Items.Count; i++)
                            {
                                purettu = taulu[i].Split(' '); // puretaan taulu 
                                j.nimi = tbJoukkue.Text.ToUpper();
                                j.voitot = voitot; // säilytetään tappioiden voittojen ja tasapelien määrät
                                j.tappiot = tappiot;
                                j.tasapelit = tasapelit;
                                j.laji = laji;
                                j.pelaaja.etunimi = purettu[0];
                                j.pelaaja.sukunimi = purettu[1];
                                j.pelaaja.pelinumero = purettu[2];
                                if (i < alkuperainen) // verrataan alkuperäiseen listaan
                                {
                                    j.pelaaja.pisteet.maalit = joukkueJaPelaajat[i].pelaaja.pisteet.maalit;
                                    j.pelaaja.pisteet.syotot = joukkueJaPelaajat[i].pelaaja.pisteet.syotot;
                                }
                                else // jos ei ole alkuperäisellä lsitalla enää alustenaan pisteet nollaksi
                                {
                                    j.pelaaja.pisteet.maalit = 0;
                                    j.pelaaja.pisteet.syotot = 0;
                                }
                                muokattujoukkue.Add(j);
                            }
                            j.KirjoitaXML(muokattujoukkue, tbJoukkue.Text.ToUpper() + ".xml");
                            this.Close();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Poistetaan pelaaja listboxista ja numero numeroiden tarkistus listasta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbPelaajat_DoubleClick(object sender, EventArgs e)
        {
            if (lbPelaajat.Items.Count > 0)
            {
                try 
                {
                    string[] purettu = new string[3];
                    string rivi;
                    int i, numero;
                    rivi = lbPelaajat.SelectedItem.ToString();
                    if (lbPelaajat.SelectedIndex < alkuperainen)//poistaa pelaajan alkuperäiseltä listalta
                    {
                        joukkueJaPelaajat.RemoveAt(lbPelaajat.SelectedIndex);
                    }
                    //poistaa pelaajan listalta
                    if (lbPelaajat.Items.Count > 0)
                    {
                        lbPelaajat.Items.RemoveAt(lbPelaajat.SelectedIndex);
                    }
                    purettu = rivi.Split(' ');
                    for (i = 0; i < numtarkistus.Count; i++)
                    {
                        numero = numtarkistus[i];
                        if (numero == int.Parse(purettu[2]))
                        {
                            numtarkistus.RemoveAt(i);
                        }
                    }
                    alkuperainen -= 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Virhe");
                }
            }
        }
        /// <summary>
        /// Jos tullaan muokkaus napista formille laitetaan joukkueen valinta näkymään
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm1JoukkueenLisäys_Load(object sender, EventArgs e)
        {
            try
            {
                if (muokkaus == true && joukkueet.Count > 0)
                {
                    tsslblVirhe.Visible = false;
                    pnlJoukkueet.Visible = true;
                    foreach (string s in joukkueet)
                    {
                        cbJoukkueet.Items.Add(s);
                    }
                }
                else if (muokkaus == true)
                {
                    tsslblVirhe.Text = "Yhtään joukkuetta ei ole vielä lisätty. Voit lisätä joukkueen nyt.";
                    tsslblVirhe.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Annetaan mahdollisuus muokata joukkueen nimeä
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            tbJoukkue.Enabled = true;
            btnMuokkaa.Visible = false;
        }
        /// <summary>
        /// Lisätään joukkueen tiedot lisboxiin muokkaus tilassa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbJoukkueet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbEtunimi.Text = string.Empty;
                tbSukunimi.Text = string.Empty;
                nupNumero.Value = 0;
                numtarkistus.Clear();
                lbPelaajat.Items.Clear();
                lbPelaajat.Visible = true;
                lblOhje.Visible = true;
                Joukkue j = default;
                string pelaaja;
                joukkueJaPelaajat = j.PuraXML(cbJoukkueet.Text + ".XML");
                tbJoukkue.Text = cbJoukkueet.Text;
                if (joukkueJaPelaajat != null)
                {
                    voitot = joukkueJaPelaajat[0].voitot;
                    tappiot = joukkueJaPelaajat[0].tappiot;
                    tasapelit = joukkueJaPelaajat[0].tasapelit;
                    tsslblVirhe.Visible = false;
                    foreach (Joukkue jo in joukkueJaPelaajat)
                    {
                        pelaaja = jo.pelaaja.etunimi + " " + jo.pelaaja.sukunimi + " " + jo.pelaaja.pelinumero;
                        lbPelaajat.Items.Add(pelaaja);
                        numtarkistus.Add(int.Parse(jo.pelaaja.pelinumero));
                    }
                }
                else
                {
                    tsslblVirhe.Text = "Joukkueen tiedot on käyty poistamassa. Voit lisätä pelaajat nyt.";
                    tsslblVirhe.Visible = true;
                }
                alkuperainen = lbPelaajat.Items.Count;// käytetään muokkauksessa ottamaan alkuperäisen listan koko
            } // yllä otetaan talteen alkuperäisen listan koko
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nYritä korjata virhe muokkaamalla joukkuetta nyt", "Virhe");
                tbJoukkue.Text = cbJoukkueet.Text;
            }
        }
        /// <summary>
        /// Jos validointi aktiivisena niin pystyy sulkemaan sovelluksen.
        /// Kysytyään vatmuus lomakkeelta poistumiseen, kun ei ole tallennettu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm1JoukkueenLisäys_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tallennettu == false)
            {
                DialogResult dr;
                dr = MessageBox.Show("Haluatko varmasti lopettaa kesken?", "INFO", MessageBoxButtons.YesNo);

                if (DialogResult.No == dr)
                {
                    e.Cancel = true;
                }
            }
            AutoValidate = AutoValidate.Disable;
        }
        /// <summary>
        /// Varmuuden vuoks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nupNumero_Validated(object sender, EventArgs e)
        {
            epVirhe.SetError(nupNumero, "");
        }
        /// <summary>
        /// Varmuuden vuoks tarkistus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nupNumero_Validating(object sender, CancelEventArgs e)
        {
            int tarkiste;
            bool oikein;
            string tar;

            tar = nupNumero.Value.ToString();
            oikein = int.TryParse(tar, out tarkiste);

            if (oikein == false)
            {
                epVirhe.SetError(nupNumero, "Väärin annettu arvo");
                e.Cancel = true;
            }
        }
    }
}
