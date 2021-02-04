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

namespace KutuphaneUygulamasi.WinForm.Kitap
{
    public partial class frmKitap : DevExpress.XtraEditors.XtraForm
    {
        //Business katmanında IKitapService bağlantı kurduk,Kitap Managerda örnekledik 
        //CRUD işlemi yapılıcak,Kitapla Çalışabilmek için IKitapService ihtiyacımız var
        private IKitapService kitapService = new KitapManager();
        public frmKitap()
        {
            InitializeComponent();
            kitapService.OrnekOlustur(true);
            Listele();
        }
        private void Listele()
        {
            gridControlKitap.DataSource = kitapService.Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Yeni Kitap Ekleyeceğimiz zaman yeni bir Kitap oluşturucam
            frmKitapIslem from = new frmKitapIslem(new Entities.Kitap());
            from.ShowDialog();
        }
        //Düzeneleme işlemi
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32( gridKitap.GetFocusedRowCellValue(colId));
            //Düzenleme işleminde Kitap bilgilerine id si eşit olanları getirceğiz
            frmKitapIslem formDuzenle =new frmKitapIslem(kitapService.Getir(c =>c.Id== id));
            formDuzenle.ShowDialog();

        }
        //Silme işlemi
        private void btnSil_Click(object sender, EventArgs e)
        {
            Entities.Kitap silinecek = (Entities.Kitap)gridKitap.GetFocusedRow();
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Id sine göre silme işlemi yapıldı.
                kitapService.Sil(x => x.Id == silinecek.Id);
                kitapService.Kaydet();
                Listele();
            }
        }
    }
}