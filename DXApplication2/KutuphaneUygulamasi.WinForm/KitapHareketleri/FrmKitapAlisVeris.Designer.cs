
namespace KutuphaneUygulamasi.WinForm.KitapHareketleri
{
    partial class FrmKitapAlisVeris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitapAlisVeris));
            this.btnUyeListKapat = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKitapHareketSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKitapHareketDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKitapHareketEkle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlKitapHareket = new DevExpress.XtraGrid.GridControl();
            this.layoutKitapHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUyeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerilisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerilisSuresi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeslimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOkulNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUyeBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUyeAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUyeSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeslimEdilmesiGerekenTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKacGunGecikti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitapHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutKitapHareket)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUyeListKapat
            // 
            this.btnUyeListKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUyeListKapat.ImageOptions.Image")));
            this.btnUyeListKapat.Location = new System.Drawing.Point(1028, 26);
            this.btnUyeListKapat.Name = "btnUyeListKapat";
            this.btnUyeListKapat.Size = new System.Drawing.Size(103, 44);
            this.btnUyeListKapat.TabIndex = 4;
            this.btnUyeListKapat.Text = "Kapat";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnUyeListKapat);
            this.groupControl1.Controls.Add(this.btnKitapHareketSil);
            this.groupControl1.Controls.Add(this.btnKitapHareketDuzenle);
            this.groupControl1.Controls.Add(this.btnKitapHareketEkle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 595);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1143, 72);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Menü";
            // 
            // btnKitapHareketSil
            // 
            this.btnKitapHareketSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnKitapHareketSil.Location = new System.Drawing.Point(247, 26);
            this.btnKitapHareketSil.Name = "btnKitapHareketSil";
            this.btnKitapHareketSil.Size = new System.Drawing.Size(103, 44);
            this.btnKitapHareketSil.TabIndex = 2;
            this.btnKitapHareketSil.Text = "Sil";
            // 
            // btnKitapHareketDuzenle
            // 
            this.btnKitapHareketDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.Image")));
            this.btnKitapHareketDuzenle.Location = new System.Drawing.Point(138, 26);
            this.btnKitapHareketDuzenle.Name = "btnKitapHareketDuzenle";
            this.btnKitapHareketDuzenle.Size = new System.Drawing.Size(103, 44);
            this.btnKitapHareketDuzenle.TabIndex = 1;
            this.btnKitapHareketDuzenle.Text = "Düzenle";
            // 
            // btnKitapHareketEkle
            // 
            this.btnKitapHareketEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnKitapHareketEkle.Location = new System.Drawing.Point(29, 26);
            this.btnKitapHareketEkle.Name = "btnKitapHareketEkle";
            this.btnKitapHareketEkle.Size = new System.Drawing.Size(103, 44);
            this.btnKitapHareketEkle.TabIndex = 0;
            this.btnKitapHareketEkle.Text = "Ekle";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.Image")));
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseImage = true;
            this.labelControl1.Appearance.Options.UseImageAlign = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1143, 55);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Kitap Hareket Listesi";
            // 
            // gridControlKitapHareket
            // 
            this.gridControlKitapHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKitapHareket.Location = new System.Drawing.Point(0, 55);
            this.gridControlKitapHareket.MainView = this.layoutKitapHareket;
            this.gridControlKitapHareket.Name = "gridControlKitapHareket";
            this.gridControlKitapHareket.Size = new System.Drawing.Size(1143, 540);
            this.gridControlKitapHareket.TabIndex = 8;
            this.gridControlKitapHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutKitapHareket});
            // 
            // layoutKitapHareket
            // 
            this.layoutKitapHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKitapId,
            this.colUyeId,
            this.colVerilisTarihi,
            this.colVerilisSuresi,
            this.colTeslimTarihi,
            this.colAciklama,
            this.colKitapKodu,
            this.colKitapAdi,
            this.colOkulNo,
            this.colUyeBarkod,
            this.colUyeAdi,
            this.colUyeSoyadi,
            this.colTeslimEdilmesiGerekenTarih,
            this.colKacGunGecikti,
            this.colDurumu});
            this.layoutKitapHareket.GridControl = this.gridControlKitapHareket;
            this.layoutKitapHareket.Name = "layoutKitapHareket";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colKitapId
            // 
            this.colKitapId.Caption = "Kitap Id";
            this.colKitapId.FieldName = "KitapId";
            this.colKitapId.Name = "colKitapId";
            this.colKitapId.Visible = true;
            this.colKitapId.VisibleIndex = 1;
            // 
            // colUyeId
            // 
            this.colUyeId.Caption = "Üye Id";
            this.colUyeId.FieldName = "UyeId";
            this.colUyeId.Name = "colUyeId";
            this.colUyeId.Visible = true;
            this.colUyeId.VisibleIndex = 2;
            // 
            // colVerilisTarihi
            // 
            this.colVerilisTarihi.Caption = "Veriliş Tarihi";
            this.colVerilisTarihi.FieldName = "VerilisTarihi";
            this.colVerilisTarihi.Name = "colVerilisTarihi";
            this.colVerilisTarihi.Visible = true;
            this.colVerilisTarihi.VisibleIndex = 3;
            // 
            // colVerilisSuresi
            // 
            this.colVerilisSuresi.Caption = "Veriliş Süresi";
            this.colVerilisSuresi.FieldName = "VerilisSuresi";
            this.colVerilisSuresi.Name = "colVerilisSuresi";
            this.colVerilisSuresi.Visible = true;
            this.colVerilisSuresi.VisibleIndex = 4;
            // 
            // colTeslimTarihi
            // 
            this.colTeslimTarihi.Caption = "Teslim Tarihi";
            this.colTeslimTarihi.FieldName = "TeslimTarihi";
            this.colTeslimTarihi.Name = "colTeslimTarihi";
            this.colTeslimTarihi.Visible = true;
            this.colTeslimTarihi.VisibleIndex = 5;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 9;
            // 
            // colKitapKodu
            // 
            this.colKitapKodu.Caption = "Kitap Kodu";
            this.colKitapKodu.FieldName = "Kitap.KitapKodu";
            this.colKitapKodu.Name = "colKitapKodu";
            this.colKitapKodu.Visible = true;
            this.colKitapKodu.VisibleIndex = 10;
            // 
            // colKitapAdi
            // 
            this.colKitapAdi.Caption = "Kitap Adı";
            this.colKitapAdi.FieldName = "Kitap.KitapAdi";
            this.colKitapAdi.Name = "colKitapAdi";
            this.colKitapAdi.Visible = true;
            this.colKitapAdi.VisibleIndex = 11;
            // 
            // colOkulNo
            // 
            this.colOkulNo.Caption = "Okul No";
            this.colOkulNo.FieldName = "Uye.OkulNo";
            this.colOkulNo.Name = "colOkulNo";
            this.colOkulNo.Visible = true;
            this.colOkulNo.VisibleIndex = 12;
            // 
            // colUyeBarkod
            // 
            this.colUyeBarkod.Caption = "Üye Barkodu";
            this.colUyeBarkod.FieldName = "Uye.Barkod";
            this.colUyeBarkod.Name = "colUyeBarkod";
            this.colUyeBarkod.Visible = true;
            this.colUyeBarkod.VisibleIndex = 13;
            // 
            // colUyeAdi
            // 
            this.colUyeAdi.Caption = "Adı";
            this.colUyeAdi.FieldName = "Uye.Adi";
            this.colUyeAdi.Name = "colUyeAdi";
            this.colUyeAdi.Visible = true;
            this.colUyeAdi.VisibleIndex = 14;
            // 
            // colUyeSoyadi
            // 
            this.colUyeSoyadi.Caption = "Üye Soyadı";
            this.colUyeSoyadi.FieldName = "Uye.Soyadi";
            this.colUyeSoyadi.Name = "colUyeSoyadi";
            this.colUyeSoyadi.Visible = true;
            this.colUyeSoyadi.VisibleIndex = 15;
            // 
            // colTeslimEdilmesiGerekenTarih
            // 
            this.colTeslimEdilmesiGerekenTarih.Caption = "Teslim Edilmesi Gereken Tarih";
            this.colTeslimEdilmesiGerekenTarih.FieldName = "colTeslimEdilmesiGerekenTarih";
            this.colTeslimEdilmesiGerekenTarih.Name = "colTeslimEdilmesiGerekenTarih";
            this.colTeslimEdilmesiGerekenTarih.UnboundExpression = "AddDays([VerilisTarihi], [VerilisSuresi])";
            this.colTeslimEdilmesiGerekenTarih.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.colTeslimEdilmesiGerekenTarih.Visible = true;
            this.colTeslimEdilmesiGerekenTarih.VisibleIndex = 7;
            // 
            // colKacGunGecikti
            // 
            this.colKacGunGecikti.Caption = "Kaç Gün Gecikti";
            this.colKacGunGecikti.FieldName = "colKacGunGecikti";
            this.colKacGunGecikti.Name = "colKacGunGecikti";
            this.colKacGunGecikti.UnboundExpression = "DateDiffDay([colTeslimEdilmesiGerekenTarih], Today())";
            this.colKacGunGecikti.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colKacGunGecikti.Visible = true;
            this.colKacGunGecikti.VisibleIndex = 6;
            // 
            // colDurumu
            // 
            this.colDurumu.Caption = "Durumu";
            this.colDurumu.FieldName = "colDurumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.UnboundExpression = "Iif([colKacGunGecikti] > 0, [colKacGunGecikti] + \'Gün Gecikti\', \'Gecikme Yok\')";
            this.colDurumu.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 8;
            // 
            // FrmKitapAlisVeris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 667);
            this.Controls.Add(this.gridControlKitapHareket);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmKitapAlisVeris";
            this.Text = "FrmKitapAlisVeris";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitapHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutKitapHareket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnUyeListKapat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKitapHareketSil;
        private DevExpress.XtraEditors.SimpleButton btnKitapHareketDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnKitapHareketEkle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlKitapHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView layoutKitapHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapId;
        private DevExpress.XtraGrid.Columns.GridColumn colUyeId;
        private DevExpress.XtraGrid.Columns.GridColumn colVerilisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colVerilisSuresi;
        private DevExpress.XtraGrid.Columns.GridColumn colTeslimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colOkulNo;
        private DevExpress.XtraGrid.Columns.GridColumn colUyeBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colUyeAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colUyeSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colTeslimEdilmesiGerekenTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colKacGunGecikti;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
    }
}