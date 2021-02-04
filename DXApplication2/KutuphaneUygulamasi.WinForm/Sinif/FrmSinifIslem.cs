using DevExpress.XtraEditors;
using KutuphaneUygulamasi.Business.Manager;
using KutuphaneUygulamasi.Business.Servisler;
using KutuphaneUygulamasi.WinForm.Tanim;
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
    public partial class FrmSinifIslem : DevExpress.XtraEditors.XtraForm
    {
        //parametre olarak Sınıf entity si alıcam dışarıdan, forumun içerisinden gelen entity ile dependency injection yapıldı,
        //hangi forumdan geldiği belli olmadığı için bu yapıldı.
        ISinifService sinifService = new SinifManager();
        private Entities.Sinif _sinifEntity;
        //Dışardan erişilebiliyor olması için FrmSinif nin Kaydet için
        public bool kaydedildi = false;
        public FrmSinifIslem(Entities.Sinif sinifEntity)
        {
            InitializeComponent();
            //dışarıdan uyeEntity içerde kullanmak için _uyeEntity eşitlendi
            _sinifEntity = sinifEntity;
            sinifService.OrnekOlustur(true);

            //EditValue eklenicek hangi kaynağıma _sinifEntity e,Sınıf kolonuna eklenicek,formatlı durum false
            txtOkulTuru.DataBindings.Add("Text", _sinifEntity, "OkulTuru", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSinif.DataBindings.Add("Text", _sinifEntity, "Sinifi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSube.DataBindings.Add("Text", _sinifEntity, "Sube", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBolumu.DataBindings.Add("Text", _sinifEntity, "Bolumu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSinifAciklama.DataBindings.Add("Text", _sinifEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void txtOkulTuru_Click(object sender, EventArgs e)
        {

            //tanıma Okul türüne göre ekleme yapılacak
            FrmTanim tanimForm = new FrmTanim(FrmTanim.Turu.OkulTuru);
            tanimForm.ShowDialog();
            if (tanimForm.secildi == true)
            {
                //Tanım Formu içerisindeki _tanimEntity nin Tanım bilgisini TextBox yazdır.
                txtOkulTuru.Text = tanimForm._tanimEntity.Tanimi;
            }

        }

        private void txtBolumu_Click(object sender, EventArgs e)
        {
            //tanıma Okul türüne göre ekleme yapılacak
            FrmTanim tanimForm = new FrmTanim(FrmTanim.Turu.Bolum);
            tanimForm.ShowDialog();
            if (tanimForm.secildi == true)
            {
                //Tanım Formu içerisindeki _tanimEntity nin Tanım bilgisini TextBox yazdır.
                txtBolumu.Text = tanimForm._tanimEntity.Tanimi;
            }
        }

        private void btnSinifKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSinifKaydet_Click(object sender, EventArgs e)
        {
            //validasyondan geçmez ise null dönücek

            if (sinifService.EkleveyaGuncelle(_sinifEntity) != null)
            {
                kaydedildi = true;
                sinifService.Kaydet();
                this.Close();
            }
        }
    }
}