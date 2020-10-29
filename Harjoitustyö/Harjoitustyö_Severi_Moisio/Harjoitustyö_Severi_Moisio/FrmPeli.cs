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

namespace Harjoitustyö_Severi_Moisio
{
    public partial class FrmPeli : Form
    {
        List<Joukkue> kotiLista = new List<Joukkue>(); // kotijoukkueen pelaajat
        List<string> kotimaali = new List<string>();// otetaan talteen maalintekoaika
        List<string> vierasmaali = new List<string>();// otetaan talteen maalin tekoaika
        List<Joukkue> vierasLista = new List<Joukkue>();// vierasjoukkueen pelaajat
        string[] taulu = new string[5]; // käytetään listboxien muokkaukseen
        string nyt, kotijoukkue, vierasjoukkue, laji, lbrivi;// tällä saadaan aloitus ja lopetus aika.
        int minuutit, sekunnit,kMinuutit ,kSekunnit , era = 1, kMaalit = 0, vMaalit = 0; // käytetään pelikelloon ja tulostauluun
        bool nopeutus = false;
        ListBox lb; //käytetään lisboxien päivutyksessä.

        /// <summary>
        /// Tehopisteiden muokkausta. Käytetään molemmissa listboxeissa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbKoti_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                lb = (ListBox)sender;
                if (lb.Items.Count > 0 && lb.SelectedIndex >= 0)
                {
                    pnlKotiTehopiste.Visible = true;
                    lbrivi = lb.SelectedItem.ToString();
                    lbrivi = lbrivi.Replace(" ", "");
                    taulu = lbrivi.Split('/'); // erotellaan rivin tiedot taulukkoon
                    tbKotiMaali.Text = taulu[3];
                    tbKotiSyotot.Text = taulu[4];
                    lbKoti.Enabled = false;
                    lbVieras.Enabled = false;
                }
                btnAloita.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Lisätään koti joukkueelle maali ja otetaan aika talteen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKotiPlus_Click(object sender, EventArgs e)
        {
            try
            { 
                kMaalit += 1;
                lblKotiMaalit.Text = kMaalit.ToString();
                kotimaali.Add(nyt); // nyt alustetaan timertick:ssä
                pnlKoti.Visible = false;
                pnlVieras.Visible = false;
                btnMaali.Enabled = true;
                btnPeru.Visible = false;
                btnAloita.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Vähennetään kotijoukkueelta maali ja otetaan maalintekoaika pois listalta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKotiMiinus_Click(object sender, EventArgs e)
        {
            try
            { 
                if (kMaalit > 0)
                {
                    kMaalit -= 1;
                    lblKotiMaalit.Text = kMaalit.ToString();
                    kotimaali.RemoveAt(kotimaali.Count - 1);
                    pnlKoti.Visible = false;
                    pnlVieras.Visible = false;
                    btnMaali.Enabled = true;
                    btnPeru.Visible = false;
                }
                btnAloita.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Avataan tuloksen muokkaus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaali_Click(object sender, EventArgs e)
        {
            btnKelaa.Enabled = false;
            pnlKoti.Visible = true;
            pnlVieras.Visible = true;
            btnMaali.Enabled = false;
            btnPeru.Visible = true;
            tmrPeliaika.Enabled = false;
            btnAloita.Text = "Käynnistä";
            tmrPeliaika.Interval = 1000;
            nopeutus = false;
            btnKelaa.Text = "Nopeuta";
            btnAloita.Focus();
        }
        /// <summary>
        /// Suljetaan tuloksen muokkaus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPeru_Click(object sender, EventArgs e)
        {
            pnlKoti.Visible = false;
            pnlVieras.Visible = false;
            btnMaali.Enabled = true;
            btnPeru.Visible = false;
            btnAloita.Focus();
        }
        /// <summary>
        /// Lopetus mahdollisuus kesken pelin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Haluatko varmasti lopettaa kesken?", "INFO", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            btnAloita.Focus();
        }
        /// <summary>
        /// Ei toiminut halutusti. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPeli_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            string s;
            s = sender.ToString();
            if (s == "Harjoitustyö_Severi_Moisio.FrmPeli, Text: Peli")
            {
                DialogResult dr;
                dr = MessageBox.Show("Haluatko varmasti jättää pelin kesken?", "INFO", MessageBoxButtons.YesNo);

                if (DialogResult.No == dr)
                {
                    e.Cancel = true;
                }
                btnAloita.Focus();
            }
            */
        }
        /// <summary>
        /// Lisää pelaajalle maalin tehopisteiden muokkauksessa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLisMaali_Click(object sender, EventArgs e)
        {
            try
            { 
                tbKotiMaali.Text = (int.Parse(tbKotiMaali.Text) + 1).ToString();
                btnAloita.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Vähentää pelaajalle maalin tehopisteiden muokkauksessa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVahMaali_Click(object sender, EventArgs e)
        {
            try
            { 
                if (int.Parse(tbKotiMaali.Text) > 0)
                {
                    tbKotiMaali.Text = (int.Parse(tbKotiMaali.Text) - 1).ToString();
                }
                btnAloita.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Lisää pelaajalle syötön tehopisteiden muokkauksessa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLisSyotto_Click(object sender, EventArgs e)
        {
            try
            { 
                tbKotiSyotot.Text = (int.Parse(tbKotiSyotot.Text) + 1).ToString();
                btnAloita.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Vähentää pelaajalle syötön tehopisteiden muokkauksessa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVahSyotto_Click(object sender, EventArgs e)
        {
            try
            { 
                if (int.Parse(tbKotiSyotot.Text) > 0)
                {
                    tbKotiSyotot.Text = (int.Parse(tbKotiSyotot.Text) - 1).ToString();
                }
            btnAloita.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Saa pois näkyvistä avustus tekstin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            if (lblOhjeMuokkaus.Visible == false)
            {
                lblOhjeMuokkaus.Visible = true;
            }
            else
            {
                lblOhjeMuokkaus.Visible = false;
            }
            btnAloita.Focus();
        }

        /// <summary>
        /// Perutaan muokkaus halutessaan.btnPeru oikeasti lähettäjä
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            pnlKotiTehopiste.Visible = false;
            lbKoti.Enabled = true;
            lbVieras.Enabled = true;
            btnAloita.Focus();
        }
        /// <summary>
        /// Lisätään vierasjoukkueelle maali tuloksen muokkauksessa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVierasPlus_Click(object sender, EventArgs e)
        {
            try
            { 
                vMaalit += 1;
                lblVierasMaalit.Text = vMaalit.ToString();
                vierasmaali.Add(nyt);
                pnlKoti.Visible = false;
                pnlVieras.Visible = false;
                btnMaali.Enabled = true;
                btnPeru.Visible = false;
                btnAloita.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Vähennetään vierasjoukkueelle maali tuloksen muokkauksessa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVierasMiinus_Click(object sender, EventArgs e)
        {
            try
            { 
                if (vMaalit > 0)
                {
                    vMaalit -= 1;
                    lblVierasMaalit.Text = vMaalit.ToString();
                    vierasmaali.RemoveAt(vierasmaali.Count - 1);
                    pnlKoti.Visible = false;
                    pnlVieras.Visible = false;
                    btnMaali.Enabled = true;
                    btnPeru.Visible = false;
                }
                btnAloita.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }

        /// <summary>
        /// Tiedetään milloinka pelipäättyy kun tämä päivittyy. Avataan yhteenveto lomake
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsslblPelipaattyi_TextChanged(object sender, EventArgs e)
        {
            FrmPelinYhteenveto yht = new FrmPelinYhteenveto(lbKoti, lbVieras, kotiLista, vierasLista, kMaalit, vMaalit,
                                                            kotimaali, vierasmaali, tsslblPelialkoi.Text, tsslblPelipaattyi.Text,
                                                            lblKotijoukkue.Text, lblVierasjoukkue.Text, laji);
            yht.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// Tehopisteiden muokkausta. Käytetään molemmille listboxeille.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKotiMuokkaa_Click(object sender, EventArgs e)
        {
            try
            { 
                if (lb.Items.Count > 0)
                {
                    taulu[3] = tbKotiMaali.Text; // taulu luoto doubleclick funktiossa
                    taulu[4] = tbKotiSyotot.Text; // tässä päivitetään tiedot
                    lbrivi = taulu[0] + " / " + taulu[1] + " / " + taulu[2] + " / " + taulu[3]
                        + " / " + taulu[4]; 
                    lb.Items.Insert(lb.SelectedIndex, lbrivi);// lisätään päivitetty tieto taulukkoon vanhaan kohtaan
                    lb.Items.RemoveAt(lb.SelectedIndex); // poistetaan vanha rivi pois
                    pnlKotiTehopiste.Visible = false;
                    lbKoti.Enabled = true;
                    lbVieras.Enabled = true;
                }
                btnAloita.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Alustetaan pelikello ja otetaan haltuun välitetyt tiedot 
        /// </summary>
        /// <param name="koti"></param>
        /// <param name="vieras"></param>
        /// <param name="laj"></param>
        public FrmPeli(string koti, string vieras, string laj)
        {
            InitializeComponent();
            kotijoukkue = koti;
            vierasjoukkue = vieras;
            lblEraNum.Text = "1";
            laji = laj;
            Funktioni.AlustaPeli(laj, out minuutit, out sekunnit);
            if (laji == "jalkapallo")// jos laji jalkapallo erän sjasta lukee puoliaika ja laiteaan pelikello näyttämääm oikelaal
            {
                btnAloita.Text = "Aloita puoliaika";
                lblEra.Text = "Puoliaika";
                lblPeliaika.Text = "0" + minuutit.ToString() + " : " + "0" + sekunnit.ToString();
            }
            else
            {
                lblPeliaika.Text = minuutit.ToString() + " : " + "0" + sekunnit.ToString();
            }
        }
        /// <summary>
        /// Pelikellon asetukset lajista riippuen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrPeliaika_Tick(object sender, EventArgs e)
        {
            try
            { 
                // pyöritetään pelinkokonais aikaa/ ei pelikello
                if (kSekunnit == 59)
                {
                    kMinuutit += 1;
                    kSekunnit = 0;
                }
                else
                {
                    kSekunnit += 1;
                }
                //Alla laitetaan näkymään kokonais aika halutulla tavalla
                if (kSekunnit < 10 && kMinuutit < 10)
                {
                    lblKokaika.Text = "0" + kMinuutit.ToString() + " : 0" + kSekunnit.ToString();
                    nyt = "0" + kMinuutit.ToString() + " : 0" + kSekunnit.ToString();
                }
                else if (kSekunnit < 10)
                {
                    lblKokaika.Text = kMinuutit.ToString() + " : 0" + kSekunnit.ToString();
                    nyt = kMinuutit.ToString() + " : 0" + kSekunnit.ToString();
                }
                else if (kMinuutit < 10 && kSekunnit > 9)
                {
                    lblKokaika.Text = "0" + kMinuutit.ToString() + " : " + kSekunnit.ToString();
                    nyt = "0" + kMinuutit.ToString() + " : " + kSekunnit.ToString();
                }
                else
                {
                    lblKokaika.Text = kMinuutit.ToString() + " : " + kSekunnit.ToString();
                    nyt = kMinuutit.ToString() + " : " + kSekunnit.ToString();
                }
                // Peli kellon pyöritys lajista riippuen.
                if (laji == "jaakiekko")
                {
                    // saadaan kello pyörii
                    if (sekunnit == 0)
                    {
                        minuutit -= 1;
                        sekunnit = 59;
                    }
                    else
                    {
                        sekunnit -= 1;
                    }
                    //saadaan peliaika näkymään halutusti
                    if (sekunnit < 10 && minuutit < 10)
                    {
                        lblPeliaika.Text = "0" + minuutit.ToString() + " : 0" + sekunnit.ToString();
                    }
                    else if (sekunnit < 10)
                    {
                        lblPeliaika.Text = minuutit.ToString() + " : 0" + sekunnit.ToString();
                    }
                    else if (minuutit < 10 && sekunnit > 9)
                    {
                        lblPeliaika.Text = "0" + minuutit.ToString() + " : " + sekunnit.ToString();
                    }
                    else
                    {
                        lblPeliaika.Text = minuutit.ToString() + " : " + sekunnit.ToString();
                    }
                    //erän ja peliajan nollaus kun erä vaihtuu
                    if (sekunnit <= 0 && minuutit <= 0 && era < 3)
                    {
                        btnAloita.Text = "Aloita erä";
                        tmrPeliaika.Enabled = false;
                        minuutit = 20;
                        sekunnit = 0;
                        era += 1;
                        lblEraNum.Text = era.ToString();
                        lblPeliaika.Text = minuutit.ToString() + " : 0" + sekunnit.ToString();
                        tmrPeliaika.Interval = 1000;
                        nopeutus = false;
                        btnKelaa.Enabled = false;
                    }
                    else if (era > 2 && sekunnit <= 0 && minuutit <= 0) //kun peli päättyy tehdään eri temput
                    {
                        nyt = DateTime.Now.ToString("ddd dd.MM.yyyy klo. HH:mm:ss");
                        tmrPeliaika.Enabled = false;
                        tsslblPelipaattyi.Visible = true;
                        tsslblPelipaattyi.Text = "Peli päättyi : " + nyt;
                        btnAloita.Enabled = false;
                        btnKelaa.Enabled = false;
                    }
                }
                else if (laji == "jalkapallo")
                {
                    // saadaan kello pyörii
                    if (sekunnit == 59)
                    {
                        minuutit += 1;
                        sekunnit = 0;
                    }
                    else
                    {
                        sekunnit += 1;
                    }
                    //saadaan peliaika näkymään halutusti
                    if (sekunnit < 10 && minuutit < 10)
                    {
                        lblPeliaika.Text = "0" + minuutit.ToString() + " : 0" + sekunnit.ToString();
                    }
                    else if (sekunnit < 10)
                    {
                        lblPeliaika.Text = minuutit.ToString() + " : 0" + sekunnit.ToString();
                    }
                    else if (minuutit < 10 && sekunnit > 9)
                    {
                        lblPeliaika.Text = "0" + minuutit.ToString() + " : " + sekunnit.ToString();
                    }
                    else
                    {
                        lblPeliaika.Text = minuutit.ToString() + " : " + sekunnit.ToString();
                    }
                    //erän ja peliajan nollaus
                    if (sekunnit >= 0 && minuutit >= 45 && era < 2)
                    {
                        btnAloita.Text = "Aloita puoliaika";
                        tmrPeliaika.Enabled = false;
                        minuutit = 45;
                        sekunnit = 0;
                        era += 1;
                        lblEraNum.Text = era.ToString();
                        lblPeliaika.Text = minuutit.ToString() + " : 0" + sekunnit.ToString();
                        tmrPeliaika.Interval = 1000;
                        nopeutus = false;
                        btnKelaa.Enabled = false;
                    }
                    else if (era > 1 && sekunnit >= 0 && minuutit >= 90) // peli päätttyy tehdään eri temput
                    {
                        nyt = DateTime.Now.ToString("ddd dd.MM.yyyy klo. HH:mm:ss");
                        tmrPeliaika.Enabled = false;
                        tsslblPelipaattyi.Visible = true;
                        tsslblPelipaattyi.Text = "Peli päättyi : " + nyt;
                        btnAloita.Enabled = false;
                        btnKelaa.Enabled = false;
                    }
                }
                else if (laji == "salibandy")
                {
                    // saadaan kello pyörii
                    if (sekunnit == 0)
                    {
                        minuutit -= 1;
                        sekunnit = 59;
                    }
                    else
                    {
                        sekunnit -= 1;
                    }
                    //saadaan peliaika näkymään halutusti
                    if (sekunnit < 10 && minuutit < 10)
                    {
                        lblPeliaika.Text = "0" + minuutit.ToString() + " : 0" + sekunnit.ToString();
                    }
                    else if (sekunnit < 10)
                    {
                        lblPeliaika.Text = minuutit.ToString() + " : 0" + sekunnit.ToString();
                    }
                    else if (minuutit < 10 && sekunnit > 9)
                    {
                        lblPeliaika.Text = "0" + minuutit.ToString() + " : " + sekunnit.ToString();
                    }
                    else
                    {
                        lblPeliaika.Text = minuutit.ToString() + " : " + sekunnit.ToString();
                    }
                    //erän ja peliajan nollaus
                    if (sekunnit <= 0 && minuutit <= 0 && era < 3)
                    {
                        btnAloita.Text = "Aloita erä";
                        tmrPeliaika.Enabled = false;
                        minuutit = 15;
                        sekunnit = 0;
                        era += 1;
                        lblEraNum.Text = era.ToString();
                        lblPeliaika.Text = minuutit.ToString() + " : 0" + sekunnit.ToString();
                        tmrPeliaika.Interval = 1000;
                        nopeutus = false;
                        btnKelaa.Enabled = false;
                    }
                    else if (era > 2 && sekunnit <= 0 && minuutit <= 0) // peli päättyy
                    {
                        nyt = DateTime.Now.ToString("ddd dd.MM.yyyy klo. HH:mm:ss");
                        tmrPeliaika.Enabled = false;
                        tsslblPelipaattyi.Visible = true;
                        tsslblPelipaattyi.Text = "Peli päättyi : " + nyt;
                        btnAloita.Enabled = false;
                        btnKelaa.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Saadaan nopeutettua pelikelloa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKelaa_Click(object sender, EventArgs e)
        {
            if (nopeutus == false)
            {
                tmrPeliaika.Interval = 20;
                nopeutus = true;
                btnKelaa.Text = "Hidasta"; 
            }
            else
            {
                tmrPeliaika.Interval = 1000;
                nopeutus = false;
                btnKelaa.Text = "Nopeuta";
            }
            btnAloita.Focus();
        }

        /// <summary>
        /// Alustetaan joukkueet ja lisäteen ne listboxeihin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmJaakiekkoPeli_Load(object sender, EventArgs e)
        {
            
            string listbox;
            Joukkue j = default;
            try
            {
                lblKotijoukkue.Text = kotijoukkue;
                lblVierasjoukkue.Text = vierasjoukkue;
                lblKotiMaalit.Text = kMaalit.ToString();
                lblVierasMaalit.Text = vMaalit.ToString();
            
                kotiLista = j.PuraXML(kotijoukkue + ".XML");
                // lisätään joukkueet listboxseihin           
                    foreach (Joukkue jo in kotiLista)
                    {
                        listbox = jo.pelaaja.pelinumero + " / " + jo.pelaaja.etunimi + " / "
                             + jo.pelaaja.sukunimi + " / " + "0"
                             + " / " + "0";
                        lbKoti.Items.Add(listbox);
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nKotijoukkue", "Virhe");
                this.Close();
            }
            try
            {
                vierasLista = j.PuraXML(vierasjoukkue + ".XML");
                foreach (Joukkue jo in vierasLista)
                {
                    listbox = jo.pelaaja.pelinumero + " / " + jo.pelaaja.etunimi + " / "
                         + jo.pelaaja.sukunimi + " / " + "0"
                         + " / " + "0";
                    lbVieras.Items.Add(listbox);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nVierasjoukkue", "Virhe");
                this.Close();
            }
            btnAloita.Focus();
        }
        /// <summary>
        /// Kellon pysäytys ja käynnistys.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAloita_Click(object sender, EventArgs e)
        {
            if (tmrPeliaika.Enabled == false)
            {
                btnKelaa.Enabled = true;
                käynnistäPysäytäKelloToolStripMenuItem.Enabled = true;
                tmrPeliaika.Enabled = true;
                btnAloita.Text = "Pysäytä";
                // alla otetaan talteen erän alkamis aika. Näihin mennään vain pelin alussa.
                if (laji == "jaakiekko")
                {
                    if (minuutit == 20 && era == 1)
                    {
                        nyt = DateTime.Now.ToString("ddd dd.MM.yyyy klo. HH:mm:ss");
                        tsslblPelialkoi.Visible = true;
                        tsslblPelialkoi.Text = "Peli alkoi: " + nyt;
                    }
                }
                else if (laji == "jalkapallo")
                {
                    if (minuutit == 0 && era == 1)
                    {
                        nyt = DateTime.Now.ToString("ddd dd.MM.yyyy klo. HH:mm:ss");
                        tsslblPelialkoi.Visible = true;
                        tsslblPelialkoi.Text = "Peli alkoi: " + nyt;
                    }
                }
                else if (laji == "salibandy")
                {
                    if (minuutit == 15 && era == 1)
                    {
                        nyt = DateTime.Now.ToString("ddd dd.MM.yyyy klo. HH:mm:ss");
                        tsslblPelialkoi.Visible = true;
                        tsslblPelialkoi.Text = "Peli alkoi: " + nyt;
                    }
                }
            }
            else
            {
                btnAloita.Text = "Käynnistä";
                btnKelaa.Text = "Nopeuta";
                tmrPeliaika.Interval = 1000;
                nopeutus = false;
                btnKelaa.Enabled = false;
                tmrPeliaika.Enabled = false;
            }
            btnAloita.Focus();
        }
    }
}
