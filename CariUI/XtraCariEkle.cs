using Business.Abstract;
using DevExpress.XtraEditors;
using Entities.Concrete;
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

        private void XtraCariEkle_Load(object sender, EventArgs e)
        {
            //var grubs = _grubService.GetList();
            //foreach (var grub in grubs)
            //{
            //    lookUpEditGrub.Properties.Items.Add(grub.Grubadi);
            //}
            //lookUpEditGrub.Properties.DataSource = grubs;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        private void simpleButtonGrubekle_Click(object sender, EventArgs e)
        {
            XtraGrubcs Grubcs = new XtraGrubcs(_grubService);
            Grubcs.Show();
        }

        private void simpleButtonTurekle_Click(object sender, EventArgs e)
        {
            XtraTurekle turek = new XtraTurekle(_grubService, _turService);
            turek.Show();
        }

        private void simpleButtonUlkeekle_Click(object sender, EventArgs e)
        {
            XtraUlke ulke = new XtraUlke(_ulkeServis);
            ulke.Show();
        }

        private void simpleButtonSehirekle_Click(object sender, EventArgs e)
        {
            XtraSehir xtraSehir = new XtraSehir(_sehirServis, _ulkeServis);
            xtraSehir.Show();
        }

        private void simpleButtonİlceekle_Click(object sender, EventArgs e)
        {
            Xtraİlce xtraİlce = new Xtraİlce(_ilceServis, _sehirServis);
            xtraİlce.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        { //kayedt buton

        }
        int grubId = 0;
        private void comboBoxgrub_SelectedIndexChanged(object sender, EventArgs e)
        {
            grubId = _grubService.GetgrubId(lookUpEditGrub.Text.ToUpper());
            // 
            //var huhu = sender as ComboBoxEdit;
            //var ndex = huhu.SelectedIndex;
            //var demhat = huhu.Properties.Items[ndex];

            var turs = _turService.GetList();
            var tt = turs.Where(x => x.Grubsid == grubId);
            foreach (var tur in turs)
            {
                lookUpEditTur.Properties.DataSource = tur.Turadi;
                //lookUpEditTur.Properties.Add(tur.Turadi);
            }
        }

        int turId = 0;
        private void comboBoxtur_SelectedIndexChanged(object sender, EventArgs e)
        {
            //turId = _turService.GetturId(lookUpEditTur.Text);
        }

        private void lookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lookUpEditGrub_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit edt = sender as LookUpEdit;

            var grupIdValue = Convert.ToInt32(edt.EditValue);
            var turLst = _turService.GetList().Where(d => d.Grubsid == grupIdValue).ToList();
            lookUpEditTur.Properties.DataSource = turLst;

        }
    }
}