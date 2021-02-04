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

namespace KutuphaneUygulamasi.WinForm.Uye
{
    public partial class FrmUye : DevExpress.XtraEditors.XtraForm
    {
        //Business katmanında IUyeService bağlantı kurduk,UyeManager örnekledik 
        //CRUD işlemi yapılıcak,Uye Çalışabilmek için IUyeService ihtiyacımız var
        IUyeService uyeService = new UyeManager();
        public FrmUye()
        {
            InitializeComponent();
            uyeService.OrnekOlustur(true);
        }

        //grid dataSource kullanarak Listeleme işlemi
        private void Listele()
        {
            gridControlKitap.DataSource = uyeService.Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmUyeIslem formUyeIslem = new FrmUyeIslem(new Entities.Uye());
            formUyeIslem.ShowDialog();

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            //Entities den Uye ttipinde gelicek
            Entities.Uye uyeEntity = (Entities.Uye)gridKitap.GetFocusedRow();

            FrmUyeIslem formUyeIslem = new FrmUyeIslem(uyeEntity);
            formUyeIslem.ShowDialog();

        }

        private void btnUyeListKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}