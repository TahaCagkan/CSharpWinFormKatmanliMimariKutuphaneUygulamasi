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

namespace KutuphaneUygulamasi.WinForm.KitapHareketleri
{
    public partial class FrmKitapAlisVeris : DevExpress.XtraEditors.XtraForm
    {
        //KitapHareketleri ile çalışcağım için service çağırıldı
        IKitapHareketService kitapHareketService = new KitapHareketManager();
        public FrmKitapAlisVeris()
        {
            InitializeComponent();
            //Örneğini oluşturuldu
            kitapHareketService.OrnekOlustur(true);
            //grid listlenmesi DataSource na görre yapıldı,servistei Listele List generic method çağrıldı
            gridControlKitapHareket.DataSource = kitapHareketService.Listele();
        }
    }
}