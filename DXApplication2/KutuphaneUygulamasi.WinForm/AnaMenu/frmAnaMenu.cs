using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KutuphaneUygulamasi.WinForm.Kitap;
using KutuphaneUygulamasi.WinForm.KitapHareketleri;
using KutuphaneUygulamasi.WinForm.Uye;
namespace KutuphaneUygulamasi.WinForm
{
    public partial class frmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmAnaMenu()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKitap formKitap = new frmKitap();
            formKitap.MdiParent = this;
            formKitap.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUye formUye = new FrmUye();
            formUye.MdiParent = this;
            formUye.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKitapAlisVeris formKitapAlisVeris = new FrmKitapAlisVeris();
            formKitapAlisVeris.MdiParent = this;
            formKitapAlisVeris.Show();
        }
    }
}
