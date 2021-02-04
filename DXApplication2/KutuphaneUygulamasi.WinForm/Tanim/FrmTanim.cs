using DevExpress.XtraEditors;
using KutuphaneUygulamasi.Business.Manager;
using KutuphaneUygulamasi.Business.Servisler;
using KutuphaneUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneUygulamasi.WinForm.Tanim
{
    public partial class FrmTanim : DevExpress.XtraEditors.XtraForm
    {
        //Service katmanından Tanım bilgilerini,Manager kısmından YazarManager ile örnekledik
        //CRUD işlemi yapılıcak,Yazar ile Çalışabilmek için IYazarService ihtiyacımız var
        ITanimService tanimService = new TanimManager();

        //hangi forumdan geldiği belli olmadığı için bu yapıldı.
        public Entities.Tanim _tanimEntity;
        public bool secildi = false;
        private Turu _tur;
        //Tür tipine göre örnek oluşturma
        public FrmTanim(Turu tur)
        {
            InitializeComponent();
            _tur = tur;
            //Örnek oluşturma
            tanimService.OrnekOlustur(true);
            gridControl1.DataSource = tanimService.BaglantiNesnesi(x => x.Turu == tur.ToString());
            //TanimBinding();
        }

        private void BaslikBilgi()
        {
            switch (_tur)
            {
                case Turu.KitapTuru:
                    //lblBasliik.Text = "Kitap Türleri";
                    break;
                case Turu.YabanciDil:
                    //lblBaslik.Text ="Yabancı Dil Seçimi";
                    break;
                default:
                    break;
            }
        }

        public enum Turu
        {
            KitapTuru,
            YabanciDil,
            OkulTuru,
            Bolum
        }

        private void TanimBinding()
        {
            txtTanim.DataBindings.Clear();
            txtTanimAciklama.DataBindings.Clear();

            txtTanim.DataBindings.Add("Text", "_tanimEntity","Tanimi",false,DataSourceUpdateMode.OnPropertyChanged);
            txtTanimAciklama.DataBindings.Add("Text", "_tanimEntity", "Aciklama",false,DataSourceUpdateMode.OnPropertyChanged);
        }
        //Yeni Kayıt Ekleme için groupBarkodBilgi Aç ve Kapat 
        private void KayitAc()
        {

            btnIslemEkle.Enabled = false;
            btnIslemDuzenle.Enabled = false;
            btnIslemSil.Enabled = false;
            btnIslemKaydet.Enabled = true;
            btnIslemVazgec.Enabled = true;
            groupTanimBilgi.Visible = true;
            btnIslemSec.Enabled = false;
            gridControl1.Enabled = false;
        }
        private void KayitKapat()
        {
            btnIslemEkle.Enabled = true;
            btnIslemDuzenle.Enabled = true;
            btnIslemSil.Enabled = true;
            btnIslemKaydet.Enabled = false;
            btnIslemVazgec.Enabled = false;
            groupTanimBilgi.Visible = false;
            btnIslemSec.Enabled = true;
            gridControl1.Enabled = true;
        }

        private void btnIslemEkle_Click(object sender, EventArgs e)
        {
            KayitAc();
            //Yeni entity oluşturulucak daha sonra Binding işlemi getirildi
            _tanimEntity = new Entities.Tanim();
            TanimBinding();
        }

        private void btnIslemDuzenle_Click(object sender, EventArgs e)
        {
            KayitAc();
            _tanimEntity = (Entities.Tanim)gridView1.GetFocusedRow();
            TanimBinding();
        }

        private void btnIslemKaydet_Click(object sender, EventArgs e)
        {
            //dışardan gelen Tür bilgilerini içerdeki _tur bilgilerine eşitledik,gelen Tür bilgilerini içerdeki Tür bilgilerine eşitledikki,kaydederken boştu şuanda dolu olmaktadır.
            _tanimEntity.Turu = _tur.ToString();
            //Boş değil ise işleme devam et
            if(tanimService.EkleveyaGuncelle(_tanimEntity)!= null)
            {
                //Kaydetme işlemi
                tanimService.Kaydet();
                KayitKapat();
            }
        }

        private void btnIslemVazgec_Click(object sender, EventArgs e)
        {
            _tanimEntity = null;
            KayitKapat();
        }

        private void btnIslemSec_Click(object sender, EventArgs e)
        {
            secildi = true;
            //_tanimEntity seçili olan veriyi gönder
            _tanimEntity = (Entities.Tanim)gridView1.GetFocusedRow();
            this.Close();
         
        }
    }
}