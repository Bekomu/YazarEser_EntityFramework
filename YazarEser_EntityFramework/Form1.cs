using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazarEser_EntityFramework
{
    public partial class Form1 : Form
    {
        YazarEserEntities db = new YazarEserEntities();
        public Form1()
        {
            InitializeComponent();
            cboYazarlarAnasayfaYukle();
            lstYazarlarYazarlarYukle();
            cboYazarlarEserlerYukle();
            lstEserlerEserlerYukle();
        }

        private void lstEserlerEserlerYukle()
        {
            lstEserEserler.DataSource = null;
            if (cboYazarlarEserler.SelectedIndex != -1)
            {
                int seciliYazarId = (int)cboYazarlarEserler.SelectedValue;
                lstEserEserler.DataSource = db.Esers.Where(x => x.YazarId == seciliYazarId).ToList();
            }
        }

        //private void lstEserAnasayfaYukle()
        //{
        //    lstEserAnasayfa.DataSource = null;
        //    lstEserAnasayfa.DisplayMember = "Baslik";
        //    lstEserAnasayfa.ValueMember = "Id";
        //    lstEserAnasayfa.DataSource = db.Esers.ToList();
        //}

        private void cboYazarlarEserlerYukle()
        {
            cboYazarlarEserler.DataSource = null;
            cboYazarlarEserler.DisplayMember = "TamAd";
            cboYazarlarEserler.ValueMember = "Id";
            cboYazarlarEserler.DataSource = db.Yazars.ToList();
        }

        private void cboYazarlarAnasayfaYukle()
        {
            cboTamAd.DataSource = null;
            cboTamAd.DisplayMember = "TamAd";
            cboTamAd.ValueMember = "Id";
            cboTamAd.DataSource = db.Yazars.ToList();
        }

        private void lstYazarlarYazarlarYukle()
        {
            lstYazarlarYazarlar.DataSource = null;
            lstYazarlarYazarlar.DisplayMember = "TamAd";
            lstYazarlarYazarlar.ValueMember = "Id";
            lstYazarlarYazarlar.DataSource = db.Yazars.ToList();
        }

        private void cboTamAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lstEserAnasayfa.DataSource = null;
            //// TOKAT !! 
            if (cboTamAd.SelectedIndex != -1)
            {
                int yazarId = (int)cboTamAd.SelectedValue;
                lstEserAnasayfa.DataSource = db.Esers.Where(x => x.YazarId == yazarId).ToList();
            }
        }

        private void lstEserAnasayfa_SelectedIndexChanged(object sender, EventArgs e)
        {

            // eseri olmayanlarda önceki eser görünüyorrrrr !!!


            if (lstEserAnasayfa.SelectedIndex != -1)
            {
                int eserId = (int)lstEserAnasayfa.SelectedValue;
                txtEserAnasayfa.Text = db.Esers.First(x => x.Id == eserId).Icerik;
            }
            else
            {
                txtEserAnasayfa.Text = "";
            }
        }

        private void btnEkleYazar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTamAdYazarlar.Text) && !string.IsNullOrEmpty(txtResimYoluYazarlar.Text))
            {
                string tamAd = txtTamAdYazarlar.Text;
                string resimYolu = txtResimYoluYazarlar.Text;
                Yazar yeniYazar = new Yazar() { TamAd = tamAd, ResimYolu = resimYolu };
                db.Yazars.Add(yeniYazar);
                db.SaveChanges();
            }
            txtTamAdYazarlar.Text = "";
            txtResimYoluYazarlar.Text = "";
            cboYazarlarEserlerYukle();
            cboYazarlarAnasayfaYukle();
            lstYazarlarYazarlarYukle();
        }

        private void btnIptalYazar_Click(object sender, EventArgs e)
        {
            txtTamAdYazarlar.Text = "";
            txtResimYoluYazarlar.Text = "";
        }

        private void lstYazarlarYazarlar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int seciliYazarId = (int)lstYazarlarYazarlar.SelectedValue;
                Yazar silinecekYazar = (Yazar)db.Yazars.First(x => x.Id == seciliYazarId);
                db.Yazars.Remove(silinecekYazar);
                db.SaveChanges();
            }
            lstYazarlarYazarlarYukle();
            cboYazarlarAnasayfaYukle();
            cboYazarlarEserlerYukle();
        }
    }
}
