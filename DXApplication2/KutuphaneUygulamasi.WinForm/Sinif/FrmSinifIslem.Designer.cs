
namespace KutuphaneUygulamasi.WinForm.Sinif
{
    partial class FrmSinifIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinifIslem));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnSinifKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSinifKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl42 = new DevExpress.XtraEditors.LabelControl();
            this.txtSinifAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl43 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl44 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl45 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl46 = new DevExpress.XtraEditors.LabelControl();
            this.txtOkulTuru = new DevExpress.XtraEditors.ButtonEdit();
            this.txtBolumu = new DevExpress.XtraEditors.ButtonEdit();
            this.txtSinif = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtSube = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupMenu)).BeginInit();
            this.groupMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinifAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOkulTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBolumu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(601, 55);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "SınıfListesi";
            // 
            // groupMenu
            // 
            this.groupMenu.Controls.Add(this.btnSinifKapat);
            this.groupMenu.Controls.Add(this.btnSinifKaydet);
            this.groupMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupMenu.Location = new System.Drawing.Point(0, 288);
            this.groupMenu.Name = "groupMenu";
            this.groupMenu.Size = new System.Drawing.Size(601, 73);
            this.groupMenu.TabIndex = 4;
            this.groupMenu.Text = "Menü";
            // 
            // btnSinifKapat
            // 
            this.btnSinifKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUyeKapat.ImageOptions.Image")));
            this.btnSinifKapat.Location = new System.Drawing.Point(486, 26);
            this.btnSinifKapat.Name = "btnSinifKapat";
            this.btnSinifKapat.Size = new System.Drawing.Size(103, 44);
            this.btnSinifKapat.TabIndex = 2;
            this.btnSinifKapat.Text = "Kapat";
            this.btnSinifKapat.Click += new System.EventHandler(this.btnSinifKapat_Click);
            // 
            // btnSinifKaydet
            // 
            this.btnSinifKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUyeKaydet.ImageOptions.Image")));
            this.btnSinifKaydet.Location = new System.Drawing.Point(377, 26);
            this.btnSinifKaydet.Name = "btnSinifKaydet";
            this.btnSinifKaydet.Size = new System.Drawing.Size(103, 44);
            this.btnSinifKaydet.TabIndex = 1;
            this.btnSinifKaydet.Text = "Kaydet";
            this.btnSinifKaydet.Click += new System.EventHandler(this.btnSinifKaydet_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtSube);
            this.groupControl1.Controls.Add(this.txtSinif);
            this.groupControl1.Controls.Add(this.txtBolumu);
            this.groupControl1.Controls.Add(this.txtOkulTuru);
            this.groupControl1.Controls.Add(this.labelControl42);
            this.groupControl1.Controls.Add(this.txtSinifAciklama);
            this.groupControl1.Controls.Add(this.labelControl43);
            this.groupControl1.Controls.Add(this.labelControl44);
            this.groupControl1.Controls.Add(this.labelControl45);
            this.groupControl1.Controls.Add(this.labelControl46);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 55);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(601, 233);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Sınıf Bilgileri";
            // 
            // labelControl42
            // 
            this.labelControl42.Appearance.Options.UseTextOptions = true;
            this.labelControl42.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl42.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl42.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl42.Location = new System.Drawing.Point(14, 130);
            this.labelControl42.Name = "labelControl42";
            this.labelControl42.Size = new System.Drawing.Size(94, 92);
            this.labelControl42.TabIndex = 33;
            this.labelControl42.Text = "Açıklama :";
            // 
            // txtSinifAciklama
            // 
            this.txtSinifAciklama.Location = new System.Drawing.Point(114, 130);
            this.txtSinifAciklama.Name = "txtSinifAciklama";
            this.txtSinifAciklama.Size = new System.Drawing.Size(473, 92);
            this.txtSinifAciklama.TabIndex = 35;
            // 
            // labelControl43
            // 
            this.labelControl43.Appearance.Options.UseTextOptions = true;
            this.labelControl43.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl43.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl43.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl43.Location = new System.Drawing.Point(14, 103);
            this.labelControl43.Name = "labelControl43";
            this.labelControl43.Size = new System.Drawing.Size(94, 20);
            this.labelControl43.TabIndex = 40;
            this.labelControl43.Text = "Bölümü :";
            // 
            // labelControl44
            // 
            this.labelControl44.Appearance.Options.UseTextOptions = true;
            this.labelControl44.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl44.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl44.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl44.Location = new System.Drawing.Point(14, 51);
            this.labelControl44.Name = "labelControl44";
            this.labelControl44.Size = new System.Drawing.Size(94, 20);
            this.labelControl44.TabIndex = 38;
            this.labelControl44.Text = "Sınıfı :";
            // 
            // labelControl45
            // 
            this.labelControl45.Appearance.Options.UseTextOptions = true;
            this.labelControl45.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl45.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl45.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl45.Location = new System.Drawing.Point(14, 77);
            this.labelControl45.Name = "labelControl45";
            this.labelControl45.Size = new System.Drawing.Size(94, 20);
            this.labelControl45.TabIndex = 36;
            this.labelControl45.Text = "Şubesi :";
            // 
            // labelControl46
            // 
            this.labelControl46.Appearance.Options.UseTextOptions = true;
            this.labelControl46.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl46.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl46.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl46.Location = new System.Drawing.Point(14, 25);
            this.labelControl46.Name = "labelControl46";
            this.labelControl46.Size = new System.Drawing.Size(94, 20);
            this.labelControl46.TabIndex = 34;
            this.labelControl46.Text = "Okul Türü :";
            // 
            // txtOkulTuru
            // 
            this.txtOkulTuru.Location = new System.Drawing.Point(114, 26);
            this.txtOkulTuru.Name = "txtOkulTuru";
            this.txtOkulTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtOkulTuru.Size = new System.Drawing.Size(243, 20);
            this.txtOkulTuru.TabIndex = 43;
            this.txtOkulTuru.Click += new System.EventHandler(this.txtOkulTuru_Click);
            // 
            // txtBolumu
            // 
            this.txtBolumu.Location = new System.Drawing.Point(114, 104);
            this.txtBolumu.Name = "txtBolumu";
            this.txtBolumu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtBolumu.Size = new System.Drawing.Size(243, 20);
            this.txtBolumu.TabIndex = 44;
            this.txtBolumu.Click += new System.EventHandler(this.txtBolumu_Click);
            // 
            // txtSinif
            // 
            this.txtSinif.Location = new System.Drawing.Point(114, 53);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSinif.Properties.Items.AddRange(new object[] {
            "9.Sınıf",
            "10.Sınıf",
            "11.Sınıf",
            "12.Sınıf"});
            this.txtSinif.Size = new System.Drawing.Size(243, 20);
            this.txtSinif.TabIndex = 45;
            // 
            // txtSube
            // 
            this.txtSube.Location = new System.Drawing.Point(114, 79);
            this.txtSube.Name = "txtSube";
            this.txtSube.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSube.Properties.Items.AddRange(new object[] {
            "A Şubesi",
            "B Şubesi",
            "C Şubesi",
            "D Şubesi"});
            this.txtSube.Size = new System.Drawing.Size(243, 20);
            this.txtSube.TabIndex = 46;
            // 
            // FrmSinifIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 361);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupMenu);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSinifIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınıf İşlem";
            ((System.ComponentModel.ISupportInitialize)(this.groupMenu)).EndInit();
            this.groupMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSinifAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOkulTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBolumu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupMenu;
        private DevExpress.XtraEditors.SimpleButton btnSinifKapat;
        private DevExpress.XtraEditors.SimpleButton btnSinifKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl42;
        private DevExpress.XtraEditors.MemoEdit txtSinifAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl43;
        private DevExpress.XtraEditors.LabelControl labelControl44;
        private DevExpress.XtraEditors.LabelControl labelControl45;
        private DevExpress.XtraEditors.LabelControl labelControl46;
        private DevExpress.XtraEditors.ButtonEdit txtOkulTuru;
        private DevExpress.XtraEditors.ButtonEdit txtBolumu;
        private DevExpress.XtraEditors.ComboBoxEdit txtSinif;
        private DevExpress.XtraEditors.ComboBoxEdit txtSube;
    }
}