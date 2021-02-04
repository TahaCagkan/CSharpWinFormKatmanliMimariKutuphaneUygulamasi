using DevExpress.XtraEditors;
using KutuphaneUygulamasi.Business.Manager;
using KutuphaneUygulamasi.Business.Servisler;
using KutuphaneUygulamasi.WinForm.Uye;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneUygulamasi.WinForm.Sinif
{
    public partial class FrmSinif : DevExpress.XtraEditors.XtraForm
    {
        //Sınıf service ile çalışcağım için örneklendi
        ISinifService sinifService = new SinifManager();
        IUyeService uyeService = new UyeManager();

        //Sınıftaki bilgileri generci listelde tutucam örnek ismi sinifListe
        private List<Entities.Sinif> sinifListe;
        public FrmSinif()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            sinifService.OrnekOlustur(true);
            uyeService.OrnegeBagla(sinifService.OrnekOlustur(false));
            //Sınıf service içerisindeki List generic listele methodunu 
            sinifListe = sinifService.Listele();
            //grid'in DataSource na içerisine sinifListele değişkenindeki bilgileri ata(eşitle)
            gridControlSinif.DataSource = sinifListe;
        }

        private void gridSinif_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridControlUye.DataSource = sinifListe[gridSinif.FocusedRowHandle].Uyeler;
        }

        private void btnSinifEkle_Click(object sender, EventArgs e)
        {
            //FrmSinifIslem ulaşmak için örneklendi eğer kaydetme işlemi yapılmış ise sonra listeleme yap
            FrmSinifIslem formSinifIslem = new FrmSinifIslem(new Entities.Sinif());
            formSinifIslem.ShowDialog();
            if (formSinifIslem.kaydedildi)
            {
                Listele();
            }
        }

        private void btnSinifDuzenle_Click(object sender, EventArgs e)
        {
            //Düzenleme işlemi için grid içerisinden row seçili olması gerekmektedir.
            //FrmSinifIslem ulaşmak için örneklendi eğer düzenleme işlemi yapılmış ise sonra listeleme yap
            Entities.Sinif sinifEntity = (Entities.Sinif)gridSinif.GetFocusedRow();
            FrmSinifIslem formSinifIslem = new FrmSinifIslem(sinifEntity);
            formSinifIslem.ShowDialog();
            if (formSinifIslem.kaydedildi)
            {
                Listele();
            }
        }

        private void btnSinifSil_Click(object sender, EventArgs e)
        {
            //Silme işlemi için grid içerisinden row seçili olması gerekmektedir.
            Entities.Sinif sinifEntity = (Entities.Sinif)gridSinif.GetFocusedRow();
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //silincek Entity ulaştıktan sonra işlemi kaydet daha sonra listele
                sinifService.Sil(sinifEntity);
                sinifService.Kaydet();
                Listele();
            }

        }

        //Sınıf Grid Yenileme işlemi
        private void btnSinifGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }
        //Üye Ekleme işlemi
        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            FrmUyeIslem formUyeIslem = new FrmUyeIslem(new Entities.Uye());
            formUyeIslem.ShowDialog();
            if (formUyeIslem.kaydedildi)
            {
                Listele();
            }
        }
        //Üye Düzenleme işlemi
        private void btnUyeDuzenle_Click(object sender, EventArgs e)
        {
            //Düzenleme işlemi için grid içerisinden seçili olması gerekmektedir.
            Entities.Uye uyeEntity = (Entities.Uye)layoutUye.GetFocusedRow();
            FrmUyeIslem form = new FrmUyeIslem(uyeEntity);
            form.ShowDialog();
            if (form.kaydedildi)
            {
                Listele();
            }
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            //Silme işlemi için grid içerisinden row seçili olması gerekmektedir.
            Entities.Uye uyeEntity = (Entities.Uye)layoutUye.GetFocusedRow();
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //silincek Entity ulaştıktan sonra işlemi kaydet daha sonra listele
                uyeService.Sil(uyeEntity);
                uyeService.Kaydet();
                Listele();
            }
        }
        //grid güncelleme işlemi
        private void btnUyeGuncelle_Click(object sender, EventArgs e)
        {
            Listele();

        }

        private void btnUyeKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}