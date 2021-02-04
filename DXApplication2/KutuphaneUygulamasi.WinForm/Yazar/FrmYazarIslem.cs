using DevExpress.XtraEditors;
using KutuphaneUygulamasi.Business.Manager;
using KutuphaneUygulamasi.Business.Servisler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneUygulamasi.WinForm.Yazar
{
    public partial class FrmYazarIslem : DevExpress.XtraEditors.XtraForm
    {
        //Service katmanından Yazar bilgilerini,Manager kısmından YazarManager ile örnekledik
        //CRUD işlemi yapılıcak,Yazar ile Çalışabilmek için IYazarService ihtiyacımız var
        IYazarService yazarService = new YazarManager();
        IKitapService kitapService = new KitapManager();

        //parametre olarak yazarEntity si alıcam dışarıdan, forumun içerisinden gelen entity ile dependency injection yapıldı,
        //hangi forumdan geldiği belli olmadığı için bu yapıldı.
        private Entities.Yazar _yazarEntity;
        //bool tütünde kaydedilme işlemi kontolü için sağlandı
        public bool kaydedildi = false;


        public FrmYazarIslem(Entities.Yazar yazarEntity)
        {
            InitializeComponent();

            //Örnek oluşturma işlemi
            yazarService.OrnekOlustur(true);
            //Örneği bağlandı
            kitapService.OrnegeBagla(yazarService.OrnekOlustur(false));
            _yazarEntity = yazarEntity;
            //Yazar ile Bilgileri TextBox doldurulmaktadır.
            txtYazarAdi.DataBindings.Add("Text", _yazarEntity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtYazarSoyadi.DataBindings.Add("Text", _yazarEntity, "Soyadi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtDogumYeri.DataBindings.Add("Text", _yazarEntity, "DogumYili", false, DataSourceUpdateMode.OnPropertyChanged);
            txtDogumYili.DataBindings.Add("Text", _yazarEntity, "DogumYeri", false, DataSourceUpdateMode.OnPropertyChanged);
            txtYazarAciklama.DataBindings.Add("Text", _yazarEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            //Bilgiler yüklenirken doldurulucak
            gridControlYazarKitapListe.DataSource = kitapService.Listele(x => x.YazarId == _yazarEntity.Id);
        }
        //Kaydetme işlemi
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            yazarService.EkleveyaGuncelle(_yazarEntity);
            yazarService.Kaydet();
            kaydedildi = true;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}