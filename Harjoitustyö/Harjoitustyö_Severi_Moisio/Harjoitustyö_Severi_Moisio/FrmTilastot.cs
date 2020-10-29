using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Harjoitustyö_Severi_Moisio
{
    public partial class FrmTilastot : Form
    {
        string valittulaji;
        List<Peli> pelatutpelit = new List<Peli>();
        List<string> maalintekoajat = new List<string>();
        string[] tulos = new string[2];
        string sarake;
        public FrmTilastot(string laj)
        {
            InitializeComponent();
            valittulaji = laj;
        }
        /// <summary>
        /// Alustetaan formi. Lisätään pelit datagridiin ja värjätään solut riippuen pelin tuloksesta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTilastot_Load(object sender, EventArgs e)
        {
            int i; // käytetään for silmukassa alempana
            try
            { 
                Peli p = default;
                pelatutpelit = p.puraXML(valittulaji + "Pelit.XML");
                dgwPelit.DataSource = pelatutpelit;
                dgwPelit.Refresh();
                foreach (DataGridViewColumn sarake in dgwPelit.Columns)
                {
                    sarake.Width = 150;
                }
                dgwPelit.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nKäy poistamassa XML asiakirja", "virhe");
            }
            try
            {
                if (valittulaji == "jaakiekko")
                {
                    pbLaji.Image = Harjoitustyö_Severi_Moisio.Properties.Resources.jääkiekko;
                }
                else if (valittulaji == "jalkapallo")
                {
                    pbLaji.Image = Harjoitustyö_Severi_Moisio.Properties.Resources.jalkapallo;
                }
                else
                {
                    pbLaji.Image = Harjoitustyö_Severi_Moisio.Properties.Resources.salibandy;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
            // värjätään soluja osoittamaan tulosta
            try
            {
                for (i = 0; i < dgwPelit.RowCount; i++)
                {
                    sarake = dgwPelit.Rows[i].Cells[2].Value.ToString();
                    tulos = sarake.Split('-');
                    if (int.Parse(tulos[0]) > int.Parse(tulos[1]))
                    {
                        dgwPelit.Rows[i].Cells[0].Style.BackColor = Color.Green;
                        dgwPelit.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    }
                    else if (int.Parse(tulos[0]) < int.Parse(tulos[1]))
                    {
                        dgwPelit.Rows[i].Cells[1].Style.BackColor = Color.Green;
                        dgwPelit.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        dgwPelit.Rows[i].Cells[1].Style.BackColor = Color.LightGray;
                        dgwPelit.Rows[i].Cells[0].Style.BackColor = Color.LightGray;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Viedään maalien tekoajat listboxeihin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgwPelit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwPelit.RowCount > 0)
                {
                    lbKotiajat.Items.Clear();
                    lbVierasajat.Items.Clear();
                    int i = 1;
                    Peli p = default;
                    pelatutpelit = p.puraXML(valittulaji + "Pelit.XML");
                    if (pelatutpelit != null)
                    {
                        maalintekoajat = pelatutpelit[dgwPelit.CurrentRow.Index].kotimaalintekoaika;
                        foreach (string s in maalintekoajat)
                        {
                            lbKotiajat.Items.Add(i + ". " + s);
                            i++;
                        }
                        maalintekoajat = pelatutpelit[dgwPelit.CurrentRow.Index].vierasmaalintekoaika;
                        i = 1;
                        foreach (string s in maalintekoajat)
                        {
                            lbVierasajat.Items.Add(i + ". " + s);
                            i++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }
        }
        /// <summary>
        /// Suljetaan sivu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTakaisin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
