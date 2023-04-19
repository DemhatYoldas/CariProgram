namespace CariUI
{
    partial class XtraForm1
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
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar1 = new DevExpress.XtraBars.Bar();
            bar2 = new DevExpress.XtraBars.Bar();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            grub = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            tür = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            lookUpEdit3 = new DevExpress.XtraEditors.LookUpEdit();
            Ulke = new DevExpress.XtraLayout.LayoutControlItem();
            lookUpEdit4 = new DevExpress.XtraEditors.LookUpEdit();
            sehir = new DevExpress.XtraLayout.LayoutControlItem();
            lookUpEdit5 = new DevExpress.XtraEditors.LookUpEdit();
            ilce = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tür).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ulke).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sehir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit5.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ilce).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(lookUpEdit5);
            layoutControl1.Controls.Add(lookUpEdit4);
            layoutControl1.Controls.Add(lookUpEdit3);
            layoutControl1.Controls.Add(simpleButton1);
            layoutControl1.Controls.Add(lookUpEdit2);
            layoutControl1.Controls.Add(lookUpEdit1);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 41);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(298, 207);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new Point(12, 173);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(274, 22);
            simpleButton1.StyleController = layoutControl1;
            simpleButton1.TabIndex = 6;
            simpleButton1.Text = "simpleButton1";
            // 
            // lookUpEdit2
            // 
            lookUpEdit2.Location = new Point(47, 36);
            lookUpEdit2.MenuManager = barManager1;
            lookUpEdit2.Name = "lookUpEdit2";
            lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Turadi", "") });
            lookUpEdit2.Properties.DisplayMember = "Turadi";
            lookUpEdit2.Properties.NullText = "";
            lookUpEdit2.Properties.ValueMember = "id";
            lookUpEdit2.Size = new Size(239, 20);
            lookUpEdit2.StyleController = layoutControl1;
            lookUpEdit2.TabIndex = 5;
            lookUpEdit2.EditValueChanged += lookUpEdit2_EditValueChanged;
            lookUpEdit2.TabIndexChanged += lookUpEdit2_TabIndexChanged;
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1, bar2, bar3 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.MainMenu = bar2;
            barManager1.StatusBar = bar3;
            // 
            // bar1
            // 
            bar1.BarName = "Tools";
            bar1.DockCol = 0;
            bar1.DockRow = 0;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.FloatLocation = new Point(229, 158);
            bar1.FloatSize = new Size(46, 22);
            bar1.Offset = 4;
            bar1.Text = "Tools";
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 1;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(298, 41);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 248);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(298, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 41);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 207);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(298, 41);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 207);
            // 
            // lookUpEdit1
            // 
            lookUpEdit1.Location = new Point(47, 12);
            lookUpEdit1.MenuManager = barManager1;
            lookUpEdit1.Name = "lookUpEdit1";
            lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Grubadi", "") });
            lookUpEdit1.Properties.DisplayMember = "Grubadi";
            lookUpEdit1.Properties.Name = "lookUpEdit1";
            lookUpEdit1.Properties.NullText = "";
            lookUpEdit1.Properties.ValueMember = "id";
            lookUpEdit1.Properties.EditValueChanged += lookUpEdit1_Properties_EditValueChanged;
            lookUpEdit1.Size = new Size(239, 20);
            lookUpEdit1.StyleController = layoutControl1;
            lookUpEdit1.TabIndex = 4;
            lookUpEdit1.EditValueChanged += lookUpEdit1_EditValueChanged;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { grub, emptySpaceItem1, tür, layoutControlItem3, Ulke, sehir, ilce });
            Root.Name = "Root";
            Root.Size = new Size(298, 207);
            Root.TextVisible = false;
            // 
            // grub
            // 
            grub.Control = lookUpEdit1;
            grub.Location = new Point(0, 0);
            grub.Name = "grub";
            grub.Size = new Size(278, 24);
            grub.TextSize = new Size(23, 13);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 120);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(278, 41);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // tür
            // 
            tür.Control = lookUpEdit2;
            tür.Location = new Point(0, 24);
            tür.Name = "tür";
            tür.Size = new Size(278, 24);
            tür.TextSize = new Size(23, 13);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = simpleButton1;
            layoutControlItem3.Location = new Point(0, 161);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(278, 26);
            layoutControlItem3.TextSize = new Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // lookUpEdit3
            // 
            lookUpEdit3.Location = new Point(47, 60);
            lookUpEdit3.MenuManager = barManager1;
            lookUpEdit3.Name = "lookUpEdit3";
            lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit3.Size = new Size(239, 20);
            lookUpEdit3.StyleController = layoutControl1;
            lookUpEdit3.TabIndex = 7;
            // 
            // Ulke
            // 
            Ulke.Control = lookUpEdit3;
            Ulke.Location = new Point(0, 48);
            Ulke.Name = "Ulke";
            Ulke.Size = new Size(278, 24);
            Ulke.TextSize = new Size(23, 13);
            // 
            // lookUpEdit4
            // 
            lookUpEdit4.Location = new Point(47, 84);
            lookUpEdit4.MenuManager = barManager1;
            lookUpEdit4.Name = "lookUpEdit4";
            lookUpEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit4.Size = new Size(239, 20);
            lookUpEdit4.StyleController = layoutControl1;
            lookUpEdit4.TabIndex = 8;
            // 
            // sehir
            // 
            sehir.Control = lookUpEdit4;
            sehir.Location = new Point(0, 72);
            sehir.Name = "sehir";
            sehir.Size = new Size(278, 24);
            sehir.TextSize = new Size(23, 13);
            // 
            // lookUpEdit5
            // 
            lookUpEdit5.Location = new Point(47, 108);
            lookUpEdit5.MenuManager = barManager1;
            lookUpEdit5.Name = "lookUpEdit5";
            lookUpEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit5.Size = new Size(239, 20);
            lookUpEdit5.StyleController = layoutControl1;
            lookUpEdit5.TabIndex = 9;
            // 
            // ilce
            // 
            ilce.Control = lookUpEdit5;
            ilce.Location = new Point(0, 96);
            ilce.Name = "ilce";
            ilce.Size = new Size(278, 24);
            ilce.TextSize = new Size(23, 13);
            // 
            // XtraForm1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 268);
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "XtraForm1";
            Text = "XtraForm1";
            Load += XtraForm1_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lookUpEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)grub).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tür).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ulke).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)sehir).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit5.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ilce).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem grub;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem tür;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit5;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit4;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit3;
        private DevExpress.XtraLayout.LayoutControlItem Ulke;
        private DevExpress.XtraLayout.LayoutControlItem sehir;
        private DevExpress.XtraLayout.LayoutControlItem ilce;
    }
}