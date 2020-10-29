using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitustyö_Severi_Moisio
{
    public partial class FrmPelinYhteenveto : Form
    {
        List<Joukkue> kotiLista = new List<Joukkue>();
        List<Joukkue> vierasLista = new List<Joukkue>();
        List<string> kotimaali = new List<string>();// otetaan talteen maalintekoaika
        List<string> vierasmaali = new List<string>();
        List<Peli> pelit = new List<Peli>(); // tähän saadaan edelliset pelit ja päivitetään tämän pelin tulokset.
        ListBox lbkoti, lbvieras; // näilläotetaan talteen edellisen formin listboxit
        ListBox lb; //käytetään lisboxien päivutyksessä.
        string lbrivi, alku, loppu, la;
        string[] taulu = new string[5]; // käytetään listboxien muokkaukseen
        int mKoti, mVieras;
        bool tallennettu = false; // katsotaan tallenetaanko 
        /// <summary>
        /// Alustetaan näkymää
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPelinYhteenveto_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (string s in lbkoti.Items)
                {
                    lbKotiYhteenveto.Items.Add(s);
                }
                foreach (string s in lbvieras.Items)
                {
                    lbVierasYhteenveto.Items.Add(s);
                }
                //alla osoitetaan voittaja tai tasapeli.
                if (mKoti == mVieras)
                {
                    lblTasapeli.Visible = true;
                    pbTasan.Visible = true;
                }
                else if (mKoti > mVieras)
                {
                    lblVoitto1.Visible = true;
                    pbVoitto1.Visible = true;
                }
                else
                {
                    lblVoitto2.Visible = true;
                    pbVoitto2.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Lisää maalin tb:n
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLisMaali_Click(object sender, EventArgs e)
        {
            try
            {
                tbMaali.Text = (int.Parse(tbMaali.Text) + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Vähentää maalin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVahMaali_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(tbMaali.Text) > 0)
                {
                    tbMaali.Text = (int.Parse(tbMaali.Text) - 1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Lisää syötön
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLisSyotto_Click(object sender, EventArgs e)
        {
            try
            {
                tbSyotto.Text = (int.Parse(tbSyotto.Text) + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Vähennetään syöttö
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVahSyotto_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(tbSyotto.Text) > 0)
                {
                    tbSyotto.Text = (int.Parse(tbSyotto.Text) - 1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Kysytään varmuus lopettamiseen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPelinYhteenveto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tallennettu == false)
            {
                DialogResult dr;
                dr = MessageBox.Show("Et ole tallentanut peliä.\nHaluatko varmasti lopettaa?", "INFO", MessageBoxButtons.YesNo);

                if (DialogResult.No == dr)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Perutaan tehopisteiden muokkaus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            pnlTehopisteet.Visible = false;
            lbKotiYhteenveto.Enabled = true;
            lbVierasYhteenveto.Enabled = true;
        }
        /// <summary>
        /// Muokataan pelaajan tehopisteitä. Tuplaklikatusta indexistä. Toimii molemmille listboxeille.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbKotiYhteenveto_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                lb = (ListBox)sender;
                if (lb.Items.Count > 0 && lb.SelectedIndex >= 0)
                {
                    pnlTehopisteet.Visible = true;
                    lbrivi = lb.SelectedItem.ToString();
                    lbrivi = lbrivi.Replace(" ", "");
                    taulu = lbrivi.Split('/');
                    tbMaali.Text = taulu[3];
                    tbSyotto.Text = taulu[4];
                    lbKotiYhteenveto.Enabled = false;
                    lbVierasYhteenveto.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Tallenetaan pelaajien tehopistemuutokset ja joukkueen tilastot tiedostoon.
        /// Lisäksi tallentaan ottelun tiedot tiedostoon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTallenna_Click(object sender, EventArgs e)
        {
            try
            {
                if (pnlTehopisteet.Visible == true) //jos tehopisteiden muokkaus kesken ei päästetä tallentamaan.
                {
                    tsslblVirhe.Text = "Sinulla on vielä tehopisteiden muokkaus kesken";
                    tsslblVirhe.ForeColor = Color.Red;
                }
                else
                {
                    tallennettu = true;
                    tsslblVirhe.Visible = false;
                    Peli p;
                    Joukkue joukkue = default;
                    int j, ehto = kotiLista.Count, apuri;
                    string nimi, voitot, tappiot, tasapelit, laji, etunimi, sukunimi, pelinumero, maalit, syotot;
                    // Tallenetaan kotijoukkueen tiedot.
                    foreach (string rivi in lbKotiYhteenveto.Items)
                    {
                        lbrivi = rivi; // listboxin rivi
                        lbrivi = lbrivi.Replace(" ", "");// muokataan haluttuun muotoon
                        taulu = lbrivi.Split('/');// laitetaan tiedot taulukkoon
                        for (j = 0; j < ehto; j++)
                        {
                            if (kotiLista[j].pelaaja.pelinumero == taulu[0])
                            {
                                // alla otetaan pelaajan tiedot talteen
                                nimi = kotiLista[j].nimi;
                                voitot = kotiLista[j].voitot.ToString();
                                tappiot = kotiLista[j].tappiot.ToString();
                                tasapelit = kotiLista[j].tasapelit.ToString();
                                laji = kotiLista[j].laji;
                                etunimi = kotiLista[j].pelaaja.etunimi;
                                sukunimi = kotiLista[j].pelaaja.sukunimi;
                                pelinumero = kotiLista[j].pelaaja.pelinumero;
                                maalit = kotiLista[j].pelaaja.pisteet.maalit.ToString();
                                syotot = kotiLista[j].pelaaja.pisteet.syotot.ToString();
                                kotiLista.RemoveAt(j);// poistetaan kyseinen pelaaja/ joukue listalta
                                                      // muokataan tappiota/voittoa/tasapeliä
                                if (lblVoitto1.Visible == true)
                                {
                                    apuri = int.Parse(voitot);
                                    apuri += 1;
                                    voitot = apuri.ToString();
                                }
                                else if (lblVoitto2.Visible == true)
                                {
                                    apuri = int.Parse(tappiot);
                                    apuri += 1;
                                    tappiot = apuri.ToString();
                                }
                                else
                                {
                                    apuri = int.Parse(tasapelit);
                                    apuri += 1;
                                    tasapelit = apuri.ToString();
                                }
                                //alla lisätään muokatut tiedot listaan
                                joukkue.nimi = nimi;
                                joukkue.voitot = int.Parse(voitot);
                                joukkue.tappiot = int.Parse(tappiot);
                                joukkue.tasapelit = int.Parse(tasapelit);
                                joukkue.laji = laji;
                                joukkue.pelaaja.etunimi = etunimi;
                                joukkue.pelaaja.sukunimi = sukunimi;
                                joukkue.pelaaja.pelinumero = pelinumero;
                                joukkue.pelaaja.pisteet.maalit = int.Parse(maalit) + int.Parse(taulu[3]);
                                joukkue.pelaaja.pisteet.syotot = int.Parse(syotot) + int.Parse(taulu[4]);
                                kotiLista.Add(joukkue);
                                ehto -= 1; // miinustetaan ehtoa yhdellä ettei tutki enää juuri muokattua listan kohtaa
                                j -= 1; // minustetaan j:tä että saadaan tarkistukseen kaikki kohdat
                            }
                        }
                    }
                    joukkue.KirjoitaXML(kotiLista, lblKotiJoukkue.Text + ".XML");
                    ehto = vierasLista.Count;
                    // Tallennetaan vierasjoukkueen tiedot
                    foreach (string rivi in lbVierasYhteenveto.Items)
                    {
                        lbrivi = rivi;
                        lbrivi = lbrivi.Replace(" ", "");// muokataan haluttuun muotoon
                        taulu = lbrivi.Split('/');
                        for (j = 0; j < ehto; j++)
                        {
                            if (vierasLista[j].pelaaja.pelinumero == taulu[0])
                            {
                                nimi = vierasLista[j].nimi;
                                voitot = vierasLista[j].voitot.ToString();
                                tappiot = vierasLista[j].tappiot.ToString();
                                tasapelit = vierasLista[j].tasapelit.ToString();
                                laji = vierasLista[j].laji;
                                etunimi = vierasLista[j].pelaaja.etunimi;
                                sukunimi = vierasLista[j].pelaaja.sukunimi;
                                pelinumero = vierasLista[j].pelaaja.pelinumero;
                                maalit = vierasLista[j].pelaaja.pisteet.maalit.ToString();
                                syotot = vierasLista[j].pelaaja.pisteet.syotot.ToString();
                                vierasLista.RemoveAt(j);
                                if (lblVoitto1.Visible == true)
                                {
                                    apuri = int.Parse(tappiot);
                                    apuri += 1;
                                    tappiot = apuri.ToString();
                                }
                                else if (lblVoitto2.Visible == true)
                                {
                                    apuri = int.Parse(voitot);
                                    apuri += 1;
                                    voitot = apuri.ToString();
                                }
                                else
                                {
                                    apuri = int.Parse(tasapelit);
                                    apuri += 1;
                                    tasapelit = apuri.ToString();
                                }
                                joukkue.nimi = nimi;
                                joukkue.voitot = int.Parse(voitot);
                                joukkue.tappiot = int.Parse(tappiot);
                                joukkue.tasapelit = int.Parse(tasapelit);
                                joukkue.laji = laji;
                                joukkue.pelaaja.etunimi = etunimi;
                                joukkue.pelaaja.sukunimi = sukunimi;
                                joukkue.pelaaja.pelinumero = pelinumero;
                                joukkue.pelaaja.pisteet.maalit = int.Parse(maalit) + int.Parse(taulu[3]);
                                joukkue.pelaaja.pisteet.syotot = int.Parse(syotot) + int.Parse(taulu[4]);
                                vierasLista.Add(joukkue);
                                ehto -= 1;
                                j -= 1;
                            }
                        }
                    }
                    joukkue.KirjoitaXML(vierasLista, lblVierasJoukkue.Text + ".XML");

                    // tallennetaan pelin tiedot XML tiedostoon tietueen kautta.
                    p.kotijoukkue = lblKotiJoukkue.Text;
                    p.vierasjoukkue = lblVierasJoukkue.Text;
                    p.lopputulos = lblKotiMaalit.Text + " - " + lblVierasMaalit.Text;
                    alku = alku.Remove(0, 12);
                    p.alkamisAika = alku;
                    loppu = loppu.Remove(0, 15);
                    p.loppumisAika = loppu;
                    p.kotimaalintekoaika = new List<string>();
                    p.vierasmaalintekoaika = new List<string>();
                    p.kotimaalintekoaika = kotimaali;
                    p.vierasmaalintekoaika = vierasmaali;
                    // alla katsotaan minkä lajin peli kyseessä ja kirjoitetaan tiedot tiedostoon
                    if (la == "jaakiekko")
                    {
                        pelit = p.puraXML(la + "Pelit.XML");
                        if (pelit != null)
                        {
                            pelit.Add(p);
                        }
                        else// jos lista on null joudutaan luomaan lista jottai ohjelma ei kaadu.
                        {
                            pelit = new List<Peli>();
                            pelit.Add(p);
                        }
                        p.kirjoitaXML(pelit, la + "Pelit.XML");
                    }
                    else if (la == "jalkapallo")
                    {
                        pelit = p.puraXML(la + "Pelit.XML");
                        if (pelit != null)
                        {
                            pelit.Add(p);
                        }
                        else
                        {
                            pelit = new List<Peli>();
                            pelit.Add(p);
                        }
                        p.kirjoitaXML(pelit, la + "Pelit.XML");
                    }
                    else
                    {
                        pelit = p.puraXML(la + "Pelit.XML");
                        if (pelit != null)
                        {
                            pelit.Add(p);
                        }
                        else
                        {
                            pelit = new List<Peli>();
                            pelit.Add(p);
                        }
                        p.kirjoitaXML(pelit, la + "Pelit.XML");
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        // päivitetään muokatut tehopisteet listboxiin
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lb.Items.Count > 0)
                {
                    taulu[3] = tbMaali.Text;
                    taulu[4] = tbSyotto.Text;
                    lbrivi = taulu[0] + " / " + taulu[1] + " / " + taulu[2] + " / " + taulu[3]
                        + " / " + taulu[4];
                    lb.Items.Insert(lb.SelectedIndex, lbrivi);
                    lb.Items.RemoveAt(lb.SelectedIndex);
                    pnlTehopisteet.Visible = false;
                    lbKotiYhteenveto.Enabled = true;
                    lbVierasYhteenveto.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }

        /// <summary>
        /// Otetaan haltuun listat missä molemmat joukkueet sekä lisboxit mihin tehty muutokset tehopisteihin.
        /// </summary>
        /// <param name="koti"></param>
        /// <param name="vieras"></param>
        /// <param name="kotilist"></param>
        /// <param name="vieraslist"></param>
        public FrmPelinYhteenveto(ListBox koti, ListBox vieras, List<Joukkue> kotilist, List<Joukkue> vieraslist, int kMaalit, int vMaalit,
                                    List<string> k , List<string> v, string peliAlk, string peliLop, string ko, string vi, string laj)
        {
            InitializeComponent();
            lbkoti = koti; //kotijoukkue listbox
            lbvieras = vieras; // vierasjoukkue listbox
            kotiLista = kotilist; //kotijoukkueen lista
            vierasLista = vieraslist; // vierasjoukkue listassa
            lblKotiMaalit.Text = kMaalit.ToString(); // sijoitetaan tulos
            lblVierasMaalit.Text = vMaalit.ToString();
            kotimaali = k; // kotijoukkueen maalien ajat
            vierasmaali = v; // vierasjoukkueen maalien ajat
            mKoti = kMaalit;
            mVieras = vMaalit;
            alku = peliAlk;
            loppu = peliLop;
            lblKotiJoukkue.Text = ko;
            lblVierasJoukkue.Text = vi;
            la = laj;// saadaan laji talteen että tallennetaan tiedostoon oikein.
        }
    }
}
