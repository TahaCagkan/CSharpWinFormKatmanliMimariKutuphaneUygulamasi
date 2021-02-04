namespace KutuphaneUygulamasi.WinForm.Kitap
{
    partial class frmKitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitap));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlKitap = new DevExpress.XtraGrid.GridControl();
            this.gridKitap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOduncVerilebilir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYayinEvi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBasimYili = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCiltSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSayfaSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBasimYeri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDemirbasNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).BeginInit();
            this.SuspendLayout();
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
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kitap Listesi";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnDuzenle);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 425);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1143, 72);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Menü";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(230, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(103, 44);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(121, 23);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(103, 44);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(12, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(103, 44);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // gridControlKitap
            // 
            this.gridControlKitap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKitap.Location = new System.Drawing.Point(0, 55);
            this.gridControlKitap.MainView = this.gridKitap;
            this.gridControlKitap.Name = "gridControlKitap";
            this.gridControlKitap.Size = new System.Drawing.Size(1143, 370);
            this.gridControlKitap.TabIndex = 2;
            this.gridControlKitap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKitap});
            // 
            // gridKitap
            // 
            this.gridKitap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDurum,
            this.colOduncVerilebilir,
            this.colKitapKodu,
            this.colKitapAdi,
            this.colISBN,
            this.colYayinEvi,
            this.colBasimYili,
            this.colCiltSayisi,
            this.colSayfaSayisi,
            this.colBasimYeri,
            this.colDemirbasNo,
            this.colAciklama,
            this.colId});
            this.gridKitap.GridControl = this.gridControlKitap;
            this.gridKitap.Name = "gridKitap";
            // 
            // colDurum
            // 
            this.colDurum.Caption = "Durumu";
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 0;
            this.colDurum.Width = 92;
            // 
            // colOduncVerilebilir
            // 
            this.colOduncVerilebilir.Caption = "Ödünç Verilebilir";
            this.colOduncVerilebilir.FieldName = "OduncVerilebilir";
            this.colOduncVerilebilir.Name = "colOduncVerilebilir";
            this.colOduncVerilebilir.Visible = true;
            this.colOduncVerilebilir.VisibleIndex = 1;
            this.colOduncVerilebilir.Width = 92;
            // 
            // colKitapKodu
            // 
            this.colKitapKodu.Caption = "Kitap Kodu";
            this.colKitapKodu.FieldName = "KitapKodu";
            this.colKitapKodu.Name = "colKitapKodu";
            this.colKitapKodu.Visible = true;
            this.colKitapKodu.VisibleIndex = 2;
            this.colKitapKodu.Width = 92;
            // 
            // colKitapAdi
            // 
            this.colKitapAdi.Caption = "Kitap Adı";
            this.colKitapAdi.FieldName = "KitapAdi";
            this.colKitapAdi.Name = "colKitapAdi";
            this.colKitapAdi.Visible = true;
            this.colKitapAdi.VisibleIndex = 3;
            this.colKitapAdi.Width = 171;
            // 
            // colISBN
            // 
            this.colISBN.Caption = "ISBN";
            this.colISBN.FieldName = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.Visible = true;
            this.colISBN.VisibleIndex = 4;
            this.colISBN.Width = 131;
            // 
            // colYayinEvi
            // 
            this.colYayinEvi.Caption = "Yayın Evi";
            this.colYayinEvi.FieldName = "YayinEvi";
            this.colYayinEvi.Name = "colYayinEvi";
            this.colYayinEvi.Visible = true;
            this.colYayinEvi.VisibleIndex = 5;
            this.colYayinEvi.Width = 178;
            // 
            // colBasimYili
            // 
            this.colBasimYili.Caption = "Basım Yılı";
            this.colBasimYili.FieldName = "BasimYili";
            this.colBasimYili.Name = "colBasimYili";
            this.colBasimYili.Visible = true;
            this.colBasimYili.VisibleIndex = 6;
            this.colBasimYili.Width = 56;
            // 
            // colCiltSayisi
            // 
            this.colCiltSayisi.Caption = "Cilt Sayısı";
            this.colCiltSayisi.FieldName = "CiltSayisi";
            this.colCiltSayisi.Name = "colCiltSayisi";
            this.colCiltSayisi.Visible = true;
            this.colCiltSayisi.VisibleIndex = 7;
            this.colCiltSayisi.Width = 56;
            // 
            // colSayfaSayisi
            // 
            this.colSayfaSayisi.Caption = "Sayfa Sayısı";
            this.colSayfaSayisi.FieldName = "SayfaSayisi";
            this.colSayfaSayisi.Name = "colSayfaSayisi";
            this.colSayfaSayisi.Visible = true;
            this.colSayfaSayisi.VisibleIndex = 8;
            this.colSayfaSayisi.Width = 46;
            // 
            // colBasimYeri
            // 
            this.colBasimYeri.Caption = "Basım Yeri";
            this.colBasimYeri.FieldName = "BasimYeri";
            this.colBasimYeri.Name = "colBasimYeri";
            this.colBasimYeri.Visible = true;
            this.colBasimYeri.VisibleIndex = 9;
            this.colBasimYeri.Width = 47;
            // 
            // colDemirbasNo
            // 
            this.colDemirbasNo.Caption = "Demir Baş No";
            this.colDemirbasNo.FieldName = "DemirbasNo";
            this.colDemirbasNo.Name = "colDemirbasNo";
            this.colDemirbasNo.Visible = true;
            this.colDemirbasNo.VisibleIndex = 10;
            this.colDemirbasNo.Width = 76;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 11;
            this.colAciklama.Width = 88;
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // frmKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 497);
            this.Controls.Add(this.gridControlKitap);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.IsMdiContainer = true;
            this.Name = "frmKitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitaplar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraGrid.GridControl gridControlKitap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKitap;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colOduncVerilebilir;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colISBN;
        private DevExpress.XtraGrid.Columns.GridColumn colYayinEvi;
        private DevExpress.XtraGrid.Columns.GridColumn colBasimYili;
        private DevExpress.XtraGrid.Columns.GridColumn colCiltSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colSayfaSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colBasimYeri;
        private DevExpress.XtraGrid.Columns.GridColumn colDemirbasNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}