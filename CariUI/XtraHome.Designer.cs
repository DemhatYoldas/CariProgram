namespace CariUI
{
    partial class XtraHome
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraHome));
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btncarilistes = new DevExpress.XtraBars.BarButtonItem();
            btnGrubekle = new DevExpress.XtraBars.BarButtonItem();
            btnclose = new DevExpress.XtraBars.BarButtonItem();
            btnCariEkleme = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, ribbonControl1.SearchEditItem, btncarilistes, btnGrubekle, btnclose, btnCariEkleme, barButtonItem1 });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 6;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbonControl1.Size = new Size(890, 150);
            // 
            // btncarilistes
            // 
            btncarilistes.Caption = "Cari Listele";
            btncarilistes.Id = 1;
            btncarilistes.ImageOptions.Image = (Image)resources.GetObject("btncarilistes.ImageOptions.Image");
            btncarilistes.ImageOptions.LargeImage = (Image)resources.GetObject("btncarilistes.ImageOptions.LargeImage");
            btncarilistes.Name = "btncarilistes";
            // 
            // btnGrubekle
            // 
            btnGrubekle.Caption = "Cari Bölüm Ekle";
            btnGrubekle.Id = 2;
            btnGrubekle.ImageOptions.Image = (Image)resources.GetObject("btnGrubekle.ImageOptions.Image");
            btnGrubekle.ImageOptions.LargeImage = (Image)resources.GetObject("btnGrubekle.ImageOptions.LargeImage");
            btnGrubekle.Name = "btnGrubekle";
            btnGrubekle.ItemClick += btnGrubekle_ItemClick;
            // 
            // btnclose
            // 
            btnclose.Caption = "Kapat";
            btnclose.Id = 3;
            btnclose.ImageOptions.Image = (Image)resources.GetObject("btnclose.ImageOptions.Image");
            btnclose.ImageOptions.LargeImage = (Image)resources.GetObject("btnclose.ImageOptions.LargeImage");
            btnclose.Name = "btnclose";
            btnclose.ItemClick += btnclose_ItemClick;
            // 
            // btnCariEkleme
            // 
            btnCariEkleme.Caption = "Cari EKleme";
            btnCariEkleme.Id = 4;
            btnCariEkleme.ImageOptions.Image = (Image)resources.GetObject("btnCariEkleme.ImageOptions.Image");
            btnCariEkleme.ImageOptions.LargeImage = (Image)resources.GetObject("btnCariEkleme.ImageOptions.LargeImage");
            btnCariEkleme.Name = "btnCariEkleme";
            btnCariEkleme.ItemClick += btnCariEkleme_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2, ribbonPageGroup3 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Cari Takip";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(btncarilistes);
            ribbonPageGroup1.ItemLinks.Add(btnCariEkleme);
            ribbonPageGroup1.ItemLinks.Add(btnGrubekle);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Kayıt";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(btnclose);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "Kapat";
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "DENEME";
            barButtonItem1.Id = 5;
            barButtonItem1.ImageOptions.Image = (Image)resources.GetObject("barButtonItem1.ImageOptions.Image");
            barButtonItem1.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem1.ImageOptions.LargeImage");
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.ItemClick += barButtonItem1_ItemClick;
            // 
            // XtraHome
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 467);
            Controls.Add(ribbonControl1);
            IsMdiContainer = true;
            Name = "XtraHome";
            Text = "Cari Programı";
            WindowState = FormWindowState.Maximized;
            Load += XtraHome_Load;
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btncarilistes;
        private DevExpress.XtraBars.BarButtonItem btnGrubekle;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnclose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnCariEkleme;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}