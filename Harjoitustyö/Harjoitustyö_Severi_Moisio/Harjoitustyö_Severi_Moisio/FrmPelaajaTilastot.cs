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
    public partial class FrmPelaajaTilastot : Form
    {
        string valittulaji;
        List<string> joukkueet = new List<string>();
        List<Joukkue> joukkue = new List<Joukkue>();
        List<Pelaajayhteenveto> pelaajat = new List<Pelaajayhteenveto>();
        public FrmPelaajaTilastot(string laj)
        {
            InitializeComponent();
            valittulaji = laj;
        }
        /// <summary>
        /// Hakee joukkueet tiedostosta ja lisää comboboxiin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPelaajaTilastot_Load(object sender, EventArgs e)
        {
            try
            {
                joukkueet = Funktioni.PuraXML(valittulaji + "Joukkueet.XML");
                if (joukkueet == null)
                {
                    lblOhje.Text = "Yhtään joukkuetta ei ole lisätty";
                }
                else
                {
                    foreach (string s in joukkueet)
                    {
                        cbJoukkueet.Items.Add(s);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Päivitetään uusi joukkue näkymään. Ja merkataan vihreällä paras pistemies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbJoukkueet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i, paras, arvo, parasindex = 0;
                string maali, maali2, syotto;
                List<int> indeksit = new List<int>();
                List<int> tarkistettuindeks = new List<int>();

                pelaajat.Clear();
                Joukkue j = default;
                Pelaajayhteenveto p;
                joukkue = j.PuraXML(cbJoukkueet.Text + ".XML");
                if (joukkue != null)
                {
                    tsslblVirhe.Visible = false;
                    lblVoitotluku.Text = joukkue[0].voitot.ToString();
                    lblTappiotluku.Text = joukkue[0].tappiot.ToString();
                    lblTasanluku.Text = joukkue[0].tasapelit.ToString();
                    pnlTiedot.Visible = true;
                    foreach (Joukkue jo in joukkue)
                    {
                        p.etunimi = jo.pelaaja.etunimi;
                        p.sukunimi = jo.pelaaja.sukunimi;
                        p.pelinumero = jo.pelaaja.pelinumero;
                        p.maalit = jo.pelaaja.pisteet.maalit;
                        p.syotot = jo.pelaaja.pisteet.syotot;
                        pelaajat.Add(p);
                    }
                    dgwTilastot.Visible = true;
                    dgwTilastot.DataSource = null;
                    dgwTilastot.DataSource = pelaajat;
                    dgwTilastot.Refresh();

                    maali = dgwTilastot.Rows[0].Cells[3].Value.ToString();
                    syotto = dgwTilastot.Rows[0].Cells[4].Value.ToString();
                    paras = int.Parse(maali) + int.Parse(syotto);
                    indeksit.Add(0); // laitetaan aluksi parhaaksi eka pelaaja
                    for (i = 1; i < dgwTilastot.RowCount; i++)
                    {
                        maali = dgwTilastot.Rows[i].Cells[3].Value.ToString();
                        syotto = dgwTilastot.Rows[i].Cells[4].Value.ToString();
                        arvo = int.Parse(maali) + int.Parse(syotto);
                        if (arvo > paras) // lisätään paras indeksi listaan
                        {
                            paras = arvo;
                            parasindex = i;
                            indeksit.Clear();
                            indeksit.Add(i);
                        }
                        else if (arvo == paras) // jos samat pisteet laitetaan indeksi listan jatkoksi
                        {
                            indeksit.Add(i);
                        }

                    }
                    tarkistettuindeks.Add(indeksit[0]);// tarkistetutksi indeksiksi parhaaksi laitetaan indeksit listan eka alkio
                    // alla verrataan maaleja jos useita pelaajia samoissa pisteissä. Jos maalitkin samat niin pisteit ei voida erotella
                    if (indeksit.Count > 1) // jos samoja pisteitä vain yksi ei tarkisteta
                    {
                        parasindex = indeksit[0];
                        for (i = 1; i < indeksit.Count; i++)
                        {
                            maali = dgwTilastot.Rows[parasindex].Cells[3].Value.ToString();
                            maali2 = dgwTilastot.Rows[indeksit[i]].Cells[3].Value.ToString();

                            if (int.Parse(maali) > int.Parse(maali2)) // verrataan maaleja keskenään
                            {
                                tarkistettuindeks.Clear();
                                tarkistettuindeks.Add(parasindex);
                            }
                            else if (int.Parse(maali) < int.Parse(maali2))
                            {
                                tarkistettuindeks.Clear();
                                tarkistettuindeks.Add(indeksit[i]);
                                parasindex = indeksit[i];
                            }
                            else
                            {
                                tarkistettuindeks.Add(indeksit[i]);
                            }
                        }
                    }
                    foreach (int k in tarkistettuindeks)
                    {
                        for (i = 0; i < 5; i++)
                        {
                            dgwTilastot.Rows[k].Cells[i].Style.BackColor = Color.Green;
                        }
                    }
                }
                else
                {
                    tsslblVirhe.Visible = true;
                    tsslblVirhe.Text = "Joukkueen tiedot on käyty poistamassa";
                    pnlTiedot.Visible = false;
                    dgwTilastot.DataSource = null;
                    dgwTilastot.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }

        private void btnTakaisin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
