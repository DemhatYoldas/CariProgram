namespace CariUI
{
    partial class XtraGrubcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraGrubcs));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            gC1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryBtnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            repositoryBtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            txtGrubName = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gC1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGrubName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnClose);
            layoutControl1.Controls.Add(btnSave);
            layoutControl1.Controls.Add(gC1);
            layoutControl1.Controls.Add(txtGrubName);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(738, 588);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // btnClose
            // 
            btnClose.Appearance.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Appearance.Options.UseFont = true;
            btnClose.ImageOptions.Image = (Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.Location = new Point(12, 76);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(714, 36);
            btnClose.StyleController = layoutControl1;
            btnClose.TabIndex = 7;
            btnClose.Text = "Kapat";
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Appearance.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Appearance.Options.UseFont = true;
            btnSave.ImageOptions.Image = (Image)resources.GetObject("btnSave.ImageOptions.Image");
            btnSave.Location = new Point(12, 36);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(714, 36);
            btnSave.StyleController = layoutControl1;
            btnSave.TabIndex = 6;
            btnSave.Text = "Kaydet";
            btnSave.Click += btnSave_Click;
            // 
            // gC1
            // 
            gC1.Location = new Point(12, 231);
            gC1.MainView = gridView1;
            gC1.Name = "gC1";
            gC1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryBtnDelete, repositoryBtnEdit });
            gC1.Size = new Size(714, 345);
            gC1.TabIndex = 5;
            gC1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colName, colDurum, colEdit });
            gridView1.GridControl = gC1;
            gridView1.Name = "gridView1";
            // 
            // colId
            // 
            colId.Caption = "#";
            colId.FieldName = "id";
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 0;
            // 
            // colName
            // 
            colName.Caption = "Grub Adı";
            colName.FieldName = "Grubadi";
            colName.Name = "colName";
            colName.Visible = true;
            colName.VisibleIndex = 1;
            // 
            // colDurum
            // 
            colDurum.Caption = "Durum";
            colDurum.FieldName = "Durum";
            colDurum.Name = "colDurum";
            colDurum.Visible = true;
            colDurum.VisibleIndex = 2;
            // 
            // colEdit
            // 
            colEdit.Caption = "Güncelle";
            colEdit.ColumnEdit = repositoryBtnEdit;
            colEdit.Name = "colEdit";
            colEdit.Visible = true;
            colEdit.VisibleIndex = 3;
            // 
            // repositoryBtnEdit
            // 
            repositoryBtnEdit.AutoHeight = false;
            repositoryBtnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo) });
            repositoryBtnEdit.Name = "repositoryBtnEdit";
            repositoryBtnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryBtnEdit.ButtonClick += repositoryBtnEdit_ButtonClick;
            // 
            // repositoryBtnDelete
            // 
            repositoryBtnDelete.AutoHeight = false;
            repositoryBtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            repositoryBtnDelete.ContextImageOptions.Image = (Image)resources.GetObject("repositoryBtnDelete.ContextImageOptions.Image");
            repositoryBtnDelete.Name = "repositoryBtnDelete";
            repositoryBtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryBtnDelete.Click += repositoryBtnDelete_Click;
            // 
            // txtGrubName
            // 
            txtGrubName.EditValue = "";
            txtGrubName.Location = new Point(87, 12);
            txtGrubName.Name = "txtGrubName";
            txtGrubName.Size = new Size(639, 20);
            txtGrubName.StyleController = layoutControl1;
            txtGrubName.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4 });
            Root.Name = "Root";
            Root.Size = new Size(738, 588);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = txtGrubName;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(718, 24);
            layoutControlItem1.Text = "Cari Grub Adı";
            layoutControlItem1.TextSize = new Size(63, 13);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 104);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(718, 115);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = gC1;
            layoutControlItem2.Location = new Point(0, 219);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(718, 349);
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = btnSave;
            layoutControlItem3.Location = new Point(0, 24);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(718, 40);
            layoutControlItem3.TextSize = new Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = btnClose;
            layoutControlItem4.Location = new Point(0, 64);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(718, 40);
            layoutControlItem4.TextSize = new Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // XtraGrubcs
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 588);
            Controls.Add(layoutControl1);
            IconOptions.LargeImage = (Image)resources.GetObject("XtraGrubcs.IconOptions.LargeImage");
            Name = "XtraGrubcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cari Bölüm Ekle";
            Load += XtraGrubcs_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gC1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGrubName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl gC1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtGrubName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnEdit;
    }
}