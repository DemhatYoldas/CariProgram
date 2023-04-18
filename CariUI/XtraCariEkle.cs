using Business.Abstract;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CariUI
{
    public partial class XtraCariEkle : DevExpress.XtraEditors.XtraForm
    {
        IGrubService _grubService;
        ITurServis _turService;
        IUlkeServis _ulkeServis;

        public XtraCariEkle(IGrubService grubService, ITurServis turService, IUlkeServis ulkeServis)
        {
            InitializeComponent();
            _grubService = grubService;
            _turService = turService;
            _ulkeServis = ulkeServis;
        }

        private void XtraCariEkle_Load(object sender, EventArgs e)
        {
            var grubs = _grubService.GetList();
            foreach (var grub in grubs)
            {
                comboBoxgrub.Properties.Items.Add(grub.Grubadi);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraGrubcs Grubcs = new XtraGrubcs(_grubService);
            Grubcs.Show();

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTurekle turek = new XtraTurekle(_grubService, _turService);
            turek.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraUlke ulke = new XtraUlke(_ulkeServis);
            ulke.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraSehir xtraSehir = new XtraSehir();
            xtraSehir.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtraİlce xtraİlce=new Xtraİlce();
            xtraİlce.Show();
        }
    }
}