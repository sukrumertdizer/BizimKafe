using BizimKafe.DATA.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BizimKafe.UI
{
    public partial class UrunlerForm : Form
    {
        private readonly KafeVeri _db;

        public UrunlerForm(KafeVeri db)
        {
            InitializeComponent();
            _db = db;
            UrunleriListele();
        }

        private void UrunleriListele()
        {
            dgvUrunler.DataSource = _db.Urunler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtUrunAd.Text == "")
            {
                MessageBox.Show("Lütfen ürün giriniz!");
                return;
            }
            if (btnEkle.Text == "EKLE")
            {
                _db.Urunler.Add(new Urun() { UrunAd = txtUrunAd.Text, BirimFiyat = nudBirimFiyat.Value });
                UrunleriListele();
            }
            else
            {
                DataGridViewRow satir = dgvUrunler.SelectedRows[0];
                Urun urun = (Urun)satir.DataBoundItem;
                urun.BirimFiyat = nudBirimFiyat.Value;
                urun.UrunAd = txtUrunAd.Text;
                UrunleriListele();
                btnEkle.Text = "EKLE";
                btnIptal.Visible = false;
                txtUrunAd.Clear();
                nudBirimFiyat.Value = 0;
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Önce ürün seçiniz");
                return;
            }

            DialogResult dr = MessageBox.Show("Seçili ürünü silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
                return;

            DataGridViewRow satir = dgvUrunler.SelectedRows[0];
            Urun urun = (Urun)satir.DataBoundItem; //DataBoundItem satırla ilişkili nesneye ulaşmak için
            _db.Urunler.Remove(urun);
            UrunleriListele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            btnEkle.Text = "KAYDET";
            btnIptal.Visible = true;
            DataGridViewRow satir = dgvUrunler.SelectedRows[0];
            Urun urun = (Urun)satir.DataBoundItem;
            txtUrunAd.Text = urun.UrunAd;
            nudBirimFiyat.Value = urun.BirimFiyat;

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            btnEkle.Text = "EKLE";
            btnIptal.Visible = false;
            txtUrunAd.Clear();
            nudBirimFiyat.Value = 0;
        }
    }
}
