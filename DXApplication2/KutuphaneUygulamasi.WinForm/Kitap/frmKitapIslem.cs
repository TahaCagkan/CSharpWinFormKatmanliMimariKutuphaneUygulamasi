using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KutuphaneUygulamasi.Business.Servisler;
using KutuphaneUygulamasi.Business.Manager;
using KutuphaneUygulamasi.Entities;
using KutuphaneUygulamasi.WinForm.Yazar;
using KutuphaneUygulamasi.WinForm.Tanim;

namespace KutuphaneUygulamasi.WinForm.Kitap
{
    public partial class frmKitapIslem : DevExpress.XtraEditors.XtraForm
    {
        //parametre olarak kitap entity si alıcam dışarıdan, forumun içerisinden gelen entity ile dependency injection yapıldı,
        //hangi forumdan geldiği belli olmadığı için bu yapıldı.
        private Entities.Kitap _entity;
        private Barkod _barkodEntity;

        //CRUD işlemi yapılıcak,Kitapla Çalışabilmek için IKitapService ihtiyacımız var
        IKitapService kitapService = new KitapManager();
        //Barkodla çalışabilemk için IBarkodService ihtiyacımız var
        IBarkodService barkodService = new BarkodManager();
        IYazarService yazarService = new YazarManager();

        public frmKitapIslem(Entities.Kitap entity)
        {
            InitializeComponent();
            _entity = entity;
            //Eski olan daha önceki olan Dolu entity alırsak,txtKitapKodu na _entity aldığı veriyi ekle
            //txtKitapKodu.Text = _entity.KitapKodu;

            //EditValue eklenicek hangi kaynağıma _entity e,Durum kolonuna eklenicek,formatlı durum false
            toggleDurum.DataBindings.Add("EditValue",_entity,"Durum",false,DataSourceUpdateMode.OnPropertyChanged);
            toggleOducVerilebilir.DataBindings.Add("EditValue", _entity, "OduncVerilebilir", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTuru.DataBindings.Add("Text",_entity,"Turu",false,DataSourceUpdateMode.OnPropertyChanged);
            txtKitapKodu.DataBindings.Add("Text", _entity, "KitapKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIsbn.DataBindings.Add("Text", _entity, "ISBN", false, DataSourceUpdateMode.OnPropertyChanged);
            txtKitapAdi.DataBindings.Add("Text", _entity, "KitapAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtYayinEvi.DataBindings.Add("Text", _entity, "YayinEvi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBasimYili.DataBindings.Add("Text", _entity, "BasimYili", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBasimSayisi.DataBindings.Add("Text", _entity, "BasimSayisi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCiltSayisi.DataBindings.Add("Text", _entity, "CiltSayisi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSayfaSayisi.DataBindings.Add("Text", _entity, "SayfaSayisi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtDemirBasNo.DataBindings.Add("Text", _entity, "DemirbasNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);

            //Context kaydediyoruz
            kitapService.OrnekOlustur(true);
            //Daha önceden oluşturulumuş örneği barkodService örneğine bağladı
            barkodService.OrnegeBagla(kitapService.OrnekOlustur(false));
            yazarService.OrnegeBagla(kitapService.OrnekOlustur(false));

            //barkodService den gelene BaglantiNesnesi,gridControlBarkodlar gelen değişikleri anında aktarma
            gridControlBarkodlar.DataSource = barkodService.BaglantiNesnesi(x => x.KitapId == _entity.Id);
            //BarkodBinding();
            YazarListele();
        }

        private void YazarListele()
        {
            //Listeleme işlemini veri kaynağına bağlıyorum
            searchYazarAdi.Properties.DataSource = yazarService.Listele();
            searchYazarAdi.Properties.DisplayMember = "Adi";
            searchYazarAdi.Properties.DisplayMember = "Id";
            //sıfırdan farklı ise yazarı yükle
            if(_entity.YazarId != 0)
            {
                YazarYukle(_entity.YazarId);
            }     
        }

        private void BarkodBinding()
        {
            //Tekrar tekrar kayıt yapıldığı zaman hata ile karşılaşıldı.
            txtBilgiBarkodu.DataBindings.Clear();
            txtBilgiSalon.DataBindings.Clear();
            txtBilgiDolap.DataBindings.Clear();
            txtBilgiRaf.DataBindings.Clear();
            txtBilgiSira.DataBindings.Clear();
            txtBilgiAciklama.DataBindings.Clear();

            //Text eklenicek hangi kaynağıma _barkodEntity e,Barkodu kolonuna eklenicek,formatlı durum false
            txtBilgiBarkodu.DataBindings.Add("Text",_barkodEntity,"Barkodu",false,DataSourceUpdateMode.OnPropertyChanged);
            txtBilgiSalon.DataBindings.Add("Text", _barkodEntity, "Salon", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBilgiDolap.DataBindings.Add("Text", _barkodEntity, "Dolap", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBilgiRaf.DataBindings.Add("Text", _barkodEntity, "Raf", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBilgiSira.DataBindings.Add("Text", _barkodEntity, "Sira", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBilgiAciklama.DataBindings.Add("Text", _barkodEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            rtrKondisyon.DataBindings.Add("EditValue", _barkodEntity, "Kondisyon", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //_entity içerisine txtKitapKodu dan aldığı değeri gir
            //_entity.KitapKodu = txtKitapKodu.Text;

            //Eğer validasyondan geçen değer null döndürmedi ise kaydet
            if (kitapService.EkleveyaGuncelle(_entity) != null)
            {
                kitapService.Kaydet();
                this.Close();
            }
        }
        //Yeni Kayıt Ekleme için groupBarkodBilgi Aç ve Kapat 
        private void BarkodKayitAc()
        {
            groupBarkodBilgi.Visible = true;
            gridControlBarkodlar.Enabled = false;
            groupMenu.Enabled = false;
            btnIslemEkle.Enabled = false;
            btnIslemDuzenle.Enabled = false;
            btnIslemSil.Enabled = false;
            btnIslemKaydet.Enabled = true;
            btnIslemVazgec.Enabled = true;
        }
        private void BarkodKayitKapat()
        {
            groupBarkodBilgi.Visible = false;
            gridControlBarkodlar.Enabled = true;
            groupMenu.Enabled = true;
            btnIslemEkle.Enabled = true;
            btnIslemDuzenle.Enabled = true;
            btnIslemSil.Enabled = true;
            btnIslemKaydet.Enabled = false;
            btnIslemVazgec.Enabled = false;
        }
        private void btnIslemEkle_Click(object sender, EventArgs e)
        {
            BarkodKayitAc();
            //Yeni Kayıt ekleyeceğiz yeni barkod oluşturuluyor
            _barkodEntity = new Barkod();
            BarkodBinding();
        }

        private void btnIslemDuzenle_Click(object sender, EventArgs e)
        {
            BarkodKayitAc();
            //seçili olan barkodun kaydını atanıcak
            _barkodEntity = (Barkod)layoutBarkod.GetFocusedRow();
            BarkodBinding();

        }
        private void btnIslemKaydet_Click(object sender, EventArgs e)
        {
            //Barkod Tablosunun içerisinde KitapId si var,Kitap içerisindeki Id yi ,Barkod içerisine atanmaktadır.
            _barkodEntity.KitapId = _entity.Id;
            if (barkodService.EkleveyaGuncelle(_barkodEntity) != null)
            {
                BarkodKayitKapat();
            }                 
        }
        private void btnIslemVazgec_Click(object sender, EventArgs e)
        {
            _barkodEntity = null;
            BarkodKayitKapat();

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Açılan  searchYazarAdi pencere kağandığında yazar ile bilgileri TextBox lara ekle
        private void searchYazarAdi_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            //0 eşit değil ise kayıt seçilmemiştir
            if(searchYazarAdi.Properties.View.SelectedRowsCount !=0)
            {
                var id = (int)searchYazarAdi.Properties.View.GetFocusedRowCellValue(colYazarId);
                //seçildiği anda id yi yolluyacak
                YazarYukle(id);
            }

        }

        private void YazarYukle(int id)
        {
            _entity.YazarId = 1;
            var yazarEntity = yazarService.Getir(x => x.Id == id);
            searchYazarAdi.EditValue = yazarEntity.Id;
            txtYazarSoyadi.Text = yazarEntity.Soyadi;
            txtDogumYeri.Text = yazarEntity.DogumYeri;
            txtDogumYili.Text = yazarEntity.DogumYili.ToString();
            txtYazarAciklama.Text = yazarEntity.Aciklama;
            gridControlYazarKitap.DataSource = kitapService.Listele(c => c.YazarId == id);
        }

        private void searchYazarAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Index == 1)
            {
                FrmYazarIslem form = new FrmYazarIslem(new Entities.Yazar());
                form.ShowDialog();
                //Eğer yeni yazar kaydedilir ise yazarlar listelenecektir.
                if (form.kaydedildi == true)
                {
                    YazarListele();
                }
            }
        }

        private void txtTuru_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //tanıma kitap türüne göre ekleme yapılacak
            FrmTanim tanimForm = new FrmTanim(FrmTanim.Turu.KitapTuru);
            tanimForm.ShowDialog();
            if(tanimForm.secildi==true)
            {
                //Tanım Formu içerisindeki _tanimEntity nin Tanım bilgisini TextBox yazdır.
                txtTuru.Text = tanimForm._tanimEntity.Tanimi;
            }
        }
        //Silme işlemi
        private void btnIslemSil_Click(object sender, EventArgs e)
        {
            Barkod silinecek = (Barkod)layoutBarkod.GetFocusedRow();
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?","Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                barkodService.Sil(silinecek);

            }
        }
    }
}