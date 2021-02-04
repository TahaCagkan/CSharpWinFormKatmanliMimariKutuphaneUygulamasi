
namespace KutuphaneUygulamasi.WinForm.Tanim
{
    partial class FrmTanim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTanim));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabTanimBilgi = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.btnIslemSec = new DevExpress.XtraEditors.SimpleButton();
            this.btnIslemVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnIslemKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnIslemSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnIslemDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnIslemEkle = new DevExpress.XtraEditors.SimpleButton();
            this.groupTanimBilgi = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTanimAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txtTanim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.colTanimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabTanimBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupTanimBilgi)).BeginInit();
            this.groupTanimBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanimAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanim.Properties)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(603, 55);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tanımlar";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabTanimBilgi);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 55);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabTanimBilgi});
            this.tabPane1.RegularSize = new System.Drawing.Size(603, 615);
            this.tabPane1.SelectedPage = this.tabTanimBilgi;
            this.tabPane1.Size = new System.Drawing.Size(603, 615);
            this.tabPane1.TabIndex = 4;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabTanimBilgi
            // 
            this.tabTanimBilgi.Caption = "Tanım Bilgi";
            this.tabTanimBilgi.Controls.Add(this.gridControl1);
            this.tabTanimBilgi.Controls.Add(this.groupControl5);
            this.tabTanimBilgi.Controls.Add(this.groupTanimBilgi);
            this.tabTanimBilgi.Name = "tabTanimBilgi";
            this.tabTanimBilgi.Size = new System.Drawing.Size(603, 586);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 261);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(603, 325);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTanimi,
            this.colAciklama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.btnIslemSec);
            this.groupControl5.Controls.Add(this.btnIslemVazgec);
            this.groupControl5.Controls.Add(this.btnIslemKaydet);
            this.groupControl5.Controls.Add(this.btnIslemSil);
            this.groupControl5.Controls.Add(this.btnIslemDuzenle);
            this.groupControl5.Controls.Add(this.btnIslemEkle);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl5.Location = new System.Drawing.Point(0, 181);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(603, 79);
            this.groupControl5.TabIndex = 2;
            this.groupControl5.Text = "İşlemler";
            // 
            // btnIslemSec
            // 
            this.btnIslemSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIslemSec.ImageOptions.Image")));
            this.btnIslemSec.Location = new System.Drawing.Point(6, 30);
            this.btnIslemSec.Name = "btnIslemSec";
            this.btnIslemSec.Size = new System.Drawing.Size(91, 44);
            this.btnIslemSec.TabIndex = 7;
            this.btnIslemSec.Text = "Seç";
            this.btnIslemSec.Click += new System.EventHandler(this.btnIslemSec_Click);
            // 
            // btnIslemVazgec
            // 
            this.btnIslemVazgec.Enabled = false;
            this.btnIslemVazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIslemVazgec.ImageOptions.Image")));
            this.btnIslemVazgec.Location = new System.Drawing.Point(491, 30);
            this.btnIslemVazgec.Name = "btnIslemVazgec";
            this.btnIslemVazgec.Size = new System.Drawing.Size(91, 44);
            this.btnIslemVazgec.TabIndex = 6;
            this.btnIslemVazgec.Text = "Vazgeç";
            this.btnIslemVazgec.Click += new System.EventHandler(this.btnIslemVazgec_Click);
            // 
            // btnIslemKaydet
            // 
            this.btnIslemKaydet.Enabled = false;
            this.btnIslemKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIslemKaydet.ImageOptions.Image")));
            this.btnIslemKaydet.Location = new System.Drawing.Point(394, 30);
            this.btnIslemKaydet.Name = "btnIslemKaydet";
            this.btnIslemKaydet.Size = new System.Drawing.Size(91, 44);
            this.btnIslemKaydet.TabIndex = 3;
            this.btnIslemKaydet.Text = "Kaydet";
            this.btnIslemKaydet.Click += new System.EventHandler(this.btnIslemKaydet_Click);
            // 
            // btnIslemSil
            // 
            this.btnIslemSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIslemSil.ImageOptions.Image")));
            this.btnIslemSil.Location = new System.Drawing.Point(297, 30);
            this.btnIslemSil.Name = "btnIslemSil";
            this.btnIslemSil.Size = new System.Drawing.Size(91, 44);
            this.btnIslemSil.TabIndex = 5;
            this.btnIslemSil.Text = "Sil";
            // 
            // btnIslemDuzenle
            // 
            this.btnIslemDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIslemDuzenle.ImageOptions.Image")));
            this.btnIslemDuzenle.Location = new System.Drawing.Point(200, 30);
            this.btnIslemDuzenle.Name = "btnIslemDuzenle";
            this.btnIslemDuzenle.Size = new System.Drawing.Size(91, 44);
            this.btnIslemDuzenle.TabIndex = 4;
            this.btnIslemDuzenle.Text = "Düzenle";
            this.btnIslemDuzenle.Click += new System.EventHandler(this.btnIslemDuzenle_Click);
            // 
            // btnIslemEkle
            // 
            this.btnIslemEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIslemEkle.ImageOptions.Image")));
            this.btnIslemEkle.Location = new System.Drawing.Point(103, 30);
            this.btnIslemEkle.Name = "btnIslemEkle";
            this.btnIslemEkle.Size = new System.Drawing.Size(91, 44);
            this.btnIslemEkle.TabIndex = 3;
            this.btnIslemEkle.Text = "Ekle";
            this.btnIslemEkle.Click += new System.EventHandler(this.btnIslemEkle_Click);
            // 
            // groupTanimBilgi
            // 
            this.groupTanimBilgi.Controls.Add(this.labelControl2);
            this.groupTanimBilgi.Controls.Add(this.txtTanimAciklama);
            this.groupTanimBilgi.Controls.Add(this.txtTanim);
            this.groupTanimBilgi.Controls.Add(this.labelControl20);
            this.groupTanimBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTanimBilgi.Location = new System.Drawing.Point(0, 0);
            this.groupTanimBilgi.Name = "groupTanimBilgi";
            this.groupTanimBilgi.Size = new System.Drawing.Size(603, 181);
            this.groupTanimBilgi.TabIndex = 0;
            this.groupTanimBilgi.Text = "Tanım Bilgisi";
            this.groupTanimBilgi.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl2.Location = new System.Drawing.Point(3, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 20);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Açıklama :";
            // 
            // txtTanimAciklama
            // 
            this.txtTanimAciklama.Location = new System.Drawing.Point(103, 56);
            this.txtTanimAciklama.Name = "txtTanimAciklama";
            this.txtTanimAciklama.Size = new System.Drawing.Size(481, 119);
            this.txtTanimAciklama.TabIndex = 26;
            // 
            // txtTanim
            // 
            this.txtTanim.Location = new System.Drawing.Point(103, 29);
            this.txtTanim.Name = "txtTanim";
            this.txtTanim.Size = new System.Drawing.Size(481, 20);
            this.txtTanim.TabIndex = 6;
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Options.UseTextOptions = true;
            this.labelControl20.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl20.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl20.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl20.Location = new System.Drawing.Point(3, 28);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(94, 20);
            this.labelControl20.TabIndex = 5;
            this.labelControl20.Text = "Tanım :";
            // 
            // colTanimi
            // 
            this.colTanimi.Caption = "Tanımı";
            this.colTanimi.FieldName = "Tanimi";
            this.colTanimi.Name = "colTanimi";
            this.colTanimi.OptionsColumn.AllowEdit = false;
            this.colTanimi.Visible = true;
            this.colTanimi.VisibleIndex = 0;
            this.colTanimi.Width = 249;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 1;
            this.colAciklama.Width = 329;
            // 
            // FrmTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 670);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTanim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanımlar";
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabTanimBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupTanimBilgi)).EndInit();
            this.groupTanimBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTanimAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanim.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabTanimBilgi;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.SimpleButton btnIslemVazgec;
        private DevExpress.XtraEditors.SimpleButton btnIslemKaydet;
        private DevExpress.XtraEditors.SimpleButton btnIslemSil;
        private DevExpress.XtraEditors.SimpleButton btnIslemDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnIslemEkle;
        private DevExpress.XtraEditors.GroupControl groupTanimBilgi;
        private DevExpress.XtraEditors.MemoEdit txtTanimAciklama;
        private DevExpress.XtraEditors.TextEdit txtTanim;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnIslemSec;
        private DevExpress.XtraGrid.Columns.GridColumn colTanimi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
    }
}