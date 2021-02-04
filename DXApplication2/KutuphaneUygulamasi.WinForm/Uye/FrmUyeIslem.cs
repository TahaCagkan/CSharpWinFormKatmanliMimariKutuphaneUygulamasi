using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneUygulamasi.Entities;
using KutuphaneUygulamasi.Business.Servisler;
using KutuphaneUygulamasi.Business.Manager;
using KutuphaneUygulamasi.WinForm.Tanim;
using KutuphaneUygulamasi.WinForm.Sinif;

namespace KutuphaneUygulamasi.WinForm.Uye
{
    public partial class FrmUyeIslem : DevExpress.XtraEditors.XtraForm
    {
        //parametre olarak Uye entity si alıcam dışarıdan, forumun içerisinden gelen entity ile dependency injection yapıldı,
        //hangi forumdan geldiği belli olmadığı için bu yapıldı.
        private Entities.Uye _uyeEntity;
        private Entities.Telefon _telefonEntity;
        private Adres _adresEntity;

        //CRUD işlemi yapılıcak,Üye Çalışabilmek için IUyeService ihtiyacımız var
        IUyeService uyeService = new UyeManager();
        ITelefonService telefonService = new TelefonManager();
        IAdresService adresService = new AdresManager();
        ISinifService sinifService = new SinifManager();
        //Dışardan erişilebiliyor olması için FrmUye nin Kaydet için
        public bool kaydedildi = false;

        public FrmUyeIslem(Entities.Uye uyeEntity)
        {
            InitializeComponent();
            uyeService.OrnekOlustur(true);
            telefonService.OrnegeBagla(uyeService.OrnekOlustur(false));
            adresService.OrnegeBagla(uyeService.OrnekOlustur(false));
            sinifService.OrnegeBagla(uyeService.OrnekOlustur(false));
            //dışarıdan uyeEntity içerde kullanmak için _uyeEntity eşitlendi
            _uyeEntity = uyeEntity;

            //EditValue eklenicek hangi kaynağıma _uyeEntity e,Durum kolonuna eklenicek,formatlı durum false
            toggleUyeDurum.DataBindings.Add("EditValue", _uyeEntity, "Durum", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTcNo.DataBindings.Add("Text", _uyeEntity, "TcKimlikNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtOkulNo.DataBindings.Add("Text", _uyeEntity, "OkulNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBarkodu.DataBindings.Add("Text", _uyeEntity, "Barkod", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdi.DataBindings.Add("Text", _uyeEntity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSoyadi.DataBindings.Add("Text", _uyeEntity, "Soyadi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtYabanciDil.DataBindings.Add("Text", _uyeEntity, "YabanciDil", false, DataSourceUpdateMode.OnPropertyChanged);
            txtKayitTarihi.DataBindings.Add("EditValue", _uyeEntity, "KayitTarih", true, DataSourceUpdateMode.OnPropertyChanged,DateTime.Now);
            txtAciklama.DataBindings.Add("Text", _uyeEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);

            //gridleri ilgili servislerle bağlanıyor,UyeId si _uyeEntity içeisindeki Id leri eşitle
            gridControlTelefonlar.DataSource = telefonService.BaglantiNesnesi(x => x.UyeId == _uyeEntity.Id);
            gridControlUyeAdres.DataSource = adresService.BaglantiNesnesi(x => x.UyeId == _uyeEntity.Id);
            SinifListele();

        }
        private void TelefonBinding()
        {
            txtUyeTelefon.DataBindings.Clear();
            txtUyeTelefonAdiSoyadi.DataBindings.Clear();
            txtUyeTelefonYakinlik.DataBindings.Clear();
            txtUyeAciklama.DataBindings.Clear();
            //Text özelliği,_telefonEntity sine yazılcak,false olması formatlı hali ile gelmeyecek dedim
            txtUyeTelefon.DataBindings.Add("Text",_telefonEntity, "Telefonu", false,DataSourceUpdateMode.OnPropertyChanged);
            txtUyeTelefonAdiSoyadi.DataBindings.Add("Text",_telefonEntity,"AdiSoyadi",false, DataSourceUpdateMode.OnPropertyChanged);
            txtUyeTelefonYakinlik.DataBindings.Add("Text",_telefonEntity,"Yakinlik",false,DataSourceUpdateMode.OnPropertyChanged);
            txtUyeTelefonAciklama.DataBindings.Add("Text",_telefonEntity,"Aciklama",false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void AdresBinding()
        {
            txtUyeAdresil.DataBindings.Clear();
            txtUyeAdresilce.DataBindings.Clear();
            txtUyeAdresSemt.DataBindings.Clear();
            txtUyeAdresBilgileri.DataBindings.Clear();
            txtUyeAdresAciklama.DataBindings.Clear();

            txtUyeAdresil.DataBindings.Add("Text", _adresEntity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUyeAdresilce.DataBindings.Add("Text", _adresEntity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUyeAdresSemt.DataBindings.Add("Text", _adresEntity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUyeAdresBilgileri.DataBindings.Add("Text", _adresEntity, "Adresi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUyeAdresAciklama.DataBindings.Add("Text", _adresEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void SinifListele()
        {
            searchSinif.Properties.DataSource = sinifService.Listele();
            //OkulTuru karşında gösterilecek
            searchSinif.Properties.DisplayMember = "OkulTuru";
            searchSinif.Properties.ValueMember = "Id";
            //Sınıf Id si 0 değil ise yükle
            if(_uyeEntity.SinifId != 0)
            {
                SinifYukle(_uyeEntity.SinifId);
            }
        }
        //Sınıf yükleme işlemi
        private void SinifYukle(int id)
        {
            //Sınıfın içerisindeki id ye ata
            _uyeEntity.SinifId = id;
            //ilgili id li Uye olan bilgileri getir
            var sinifEntity = sinifService.Getir(x => x.Id == id);
            searchSinif.EditValue = sinifEntity.Id;
            txtSinif.Text = sinifEntity.Sinifi;
            txtSinif.Text = sinifEntity.Sube;
            txtBolumu.Text = sinifEntity.Bolumu;
            txtSinifAciklama.Text = sinifEntity.Aciklama;
            //Üyeler içerisinden o sınıfa ait olanları yükle
            gridControlSinifListesi.DataSource = uyeService.Listele(x => x.SinifId == id);
        }

        //Yeni Kayıt Ekleme,Düzenleme,Kapat,Vazgeç için groupBarkodBilgi Aç ve Kapat 
        private void TelefonKayitAc()
        {
            groupUyeTelefonBilgi.Visible = true;
            groupMenu.Enabled = false;
            gridControlTelefonlar.Enabled = false;

            btnTelefonIslemEkle.Enabled = false;
            btnTelefonIslemDuzenle.Enabled = false;
            btnTelefonIslemSil.Enabled = false;
            btnTelefonIslemKaydet.Enabled = true;
            btnTelefonIslemVazgec.Enabled = true;
        }
        private void TelefonKayitKapat()
        {
            groupUyeTelefonBilgi.Visible = false;
            groupMenu.Enabled = true;
            gridControlTelefonlar.Enabled = true;

            btnTelefonIslemEkle.Enabled = true;
            btnTelefonIslemDuzenle.Enabled = true;
            btnTelefonIslemSil.Enabled = true;
            btnTelefonIslemKaydet.Enabled = false;
            btnTelefonIslemVazgec.Enabled = false;
        }

        private void AdresKayitAc()
        {
            groupUyeTelefonBilgi.Visible = true;
            groupMenu.Enabled = false;
            gridControlTelefonlar.Enabled = false;

            btnUyeAdresEkle.Enabled = false;
            btnUyeAdresDuzenle.Enabled = false;
            btnUyeAdresSil.Enabled = false;
            btnUyeAdresKaydet.Enabled = true;
            btnUyeAdresVazgec.Enabled = true;
        }
        private void AdresKayitKapat()
        {
            groupUyeTelefonBilgi.Visible = false;
            groupMenu.Enabled = true;
            gridControlTelefonlar.Enabled = true;

            btnUyeAdresEkle.Enabled = true;
            btnUyeAdresDuzenle.Enabled = true;
            btnUyeAdresSil.Enabled = true;
            btnUyeAdresKaydet.Enabled = false;
            btnUyeAdresVazgec.Enabled = false;
        }

        private void txtTelefonIslemEkle_Click(object sender, EventArgs e)
        {
            TelefonKayitAc();
            //telefonun örneğini oluştur
            _telefonEntity = new Telefon();
            TelefonBinding();
        }

        private void txtTelefonIslemDuzenle_Click(object sender, EventArgs e)
        {
            TelefonKayitAc();
            //Sana gelicek veri tipi Telefon tipindedir
            //Seçili olan Row,Binding olarak yolanmaktadır.
            _telefonEntity = (Telefon)layoutUyeTelefon.GetFocusedRow();
            TelefonBinding();
        }

        private void txtTelefonIslemKaydet_Click(object sender, EventArgs e)
        {
            //Sana gelicek veri tipi Telefon tipindedir
            _telefonEntity.UyeId = _uyeEntity.Id;
            //validasyondan geçmez ise null dönücek
            if (telefonService.EkleveyaGuncelle(_telefonEntity) != null)
            {
                TelefonKayitKapat();
            }
            TelefonBinding();
        }

        private void txtTelefonIslemVazgec_Click(object sender, EventArgs e)
        {
            TelefonKayitKapat();
            //vazgeçilse null olsun bilgiler
            _telefonEntity = null;
        }
        //Kaydetme işlemi
        private void btnUyeKaydet_Click(object sender, EventArgs e)
        {
            //validasyondan geçmez ise null dönücek
            if (uyeService.EkleveyaGuncelle(_uyeEntity)!= null)
            {
                kaydedildi = true;
                uyeService.Kaydet();
                this.Close();
            }
        }

        private void btnUyeKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPane1_SelectedPageChanging(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangingEventArgs e)
        {
            if (groupMenu.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void btnUyeAdresEkle_Click(object sender, EventArgs e)
        {
            AdresKayitAc();
            _adresEntity = new Adres();
            AdresBinding();
        }

        private void btnUyeAdresDuzenle_Click(object sender, EventArgs e)
        {
            AdresKayitAc();
            //Seçili olan Row,Binding olarak yolanmaktadır.
            _adresEntity = (Adres)layoutUyeAdres.GetFocusedRow();
            AdresBinding();

        }

        private void btnUyeAdresKaydet_Click(object sender, EventArgs e)
        {
            //Sana gelicek veri tipi Adres tipindedir
            _adresEntity.UyeId = _adresEntity.Id;
            //validasyondan geçmez ise null dönücek
            if (adresService.EkleveyaGuncelle(_adresEntity) != null)
            {
                AdresKayitKapat();
            }
        }

        private void btnUyeAdresVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Seçili Row göre silme işlemi
        private void btnTelefonIslemSil_Click(object sender, EventArgs e)
        {
           // Barkod silinecek = (Barkod)layoutBarkod.GetFocusedRow();
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //barkodService.Sil(silinecek);
                layoutUyeTelefon.DeleteSelectedRows();

            }
        }

        private void btnUyeAdresSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //barkodService.Sil(silinecek);
                layoutUyeAdres.DeleteSelectedRows();
            }
        }
        //Arama işlemi için tıkladığımızda,geri kalan textBox lara bilgileri yaz
        private void searchSinif_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            //0 eşit değil ise kayıt seçilmemiştir
            if (searchSinif.Properties.View.SelectedRowsCount != 0)
            {
                var id = (int)searchSinif.Properties.View.GetFocusedRowCellValue(colSinifId);
                //seçildiği anda id yi yolluyacak sonra yükleyecek
                SinifYukle(id);
            }
        }

        private void txtYabanciDil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //tanıma YabanciDil türüne göre ekleme yapılacak
            FrmTanim tanimForm = new FrmTanim(FrmTanim.Turu.YabanciDil);
            tanimForm.ShowDialog();
            if (tanimForm.secildi == true)
            {
                //Tanım Formu içerisindeki _tanimEntity nin Tanım bilgisini TextBox yazdır.
                txtYabanciDil.Text = tanimForm._tanimEntity.Tanimi;
            }
        }

        private void searchSinif_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                FrmSinifIslem formSinifIslem = new FrmSinifIslem(new Entities.Sinif());
                formSinifIslem.ShowDialog();
                //kaydedilme işlemi true ise Sınıfı Listele
                if (formSinifIslem.kaydedildi == true)
                {
                    SinifListele();
                }
            }
        }
    }
}