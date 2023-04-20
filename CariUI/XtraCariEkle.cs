using Business.Abstract;
using DataAccess.Abstract;
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
        ISehirServis _sehirServis;
        IİlceServis _ilceServis;

        public XtraCariEkle(IGrubService grubService, ITurServis turService, IUlkeServis ulkeServis, ISehirServis sehirServis, IİlceServis ilceServis)
        {
            InitializeComponent();
            _grubService = grubService;
            _turService = turService;
            _ulkeServis = ulkeServis;
            _sehirServis = sehirServis;
            _ilceServis = ilceServis;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XtraGrubcs Grubcs = new XtraGrubcs(_grubService);
            Grubcs.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            XtraTurekle turek = new XtraTurekle(_grubService, _turService);
            turek.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            XtraUlke ulke = new XtraUlke(_ulkeServis);
            ulke.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            XtraSehir xtraSehir = new XtraSehir(_sehirServis, _ulkeServis);
            xtraSehir.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Xtraİlce xtraİlce = new Xtraİlce(_ilceServis, _sehirServis);
            xtraİlce.Show();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        { // kaydet


        }

        private void lookUpEditgrub_EditValueChanged(object sender, EventArgs e)
        {// grub

            LookUpEdit edt = sender as LookUpEdit;
            var grubId = Convert.ToInt32(edt.EditValue);
            var turs = _turService.GetList();
            var tt = turs.Where(x => x.Grubsid == grubId).ToList();


            lookUpEdittur.Properties.DataSource = tt;
        }

        private void lookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {//ilçe

            LookUpEdit edt = sender as LookUpEdit;
            var ulkeId = Convert.ToInt32(edt.EditValue);
            var sehirs = _sehirServis.GetList();
            var tt = sehirs.Where(x => x.Ulkesid == ulkeId).ToList();

            lookUpEditsehir.Properties.DataSource = tt;
        }

        private void lookUpEditsehir_EditValueChanged(object sender, EventArgs e)
        {//sehir

            LookUpEdit edt = sender as LookUpEdit;
            var sehirId = Convert.ToInt32(edt.EditValue);
            var ilces = _ilceServis.GetList();
            var tt = ilces.Where(x => x.Sehirsid == sehirId).ToList();

            lookUpEditilce.Properties.DataSource = tt;
        }

        private void XtraHomes_Load(object sender, EventArgs e)
        {// sayfa

            var grubs = _grubService.GetList();
            lookUpEditgrub.Properties.DataSource = grubs;

            var ulkes = _ulkeServis.GetList();
            lookUpEditUlke.Properties.DataSource = ulkes;

            var sehirs = _sehirServis.GetList();
            lookUpEditsehir.Properties.DataSource = sehirs;

        }
    }
}