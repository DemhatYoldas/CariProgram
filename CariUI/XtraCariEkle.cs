using Business.Abstract;
using DataAccess.Abstract;
using DevExpress.XtraEditors;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
        IBilgilerimServis _bilgilerimServis;

        int _id;

        public XtraCariEkle(IGrubService grubService, ITurServis turService, IUlkeServis ulkeServis, ISehirServis sehirServis, IİlceServis ilceServis, IBilgilerimServis bilgilerimServis)
        {
            InitializeComponent();
            _grubService = grubService;
            _turService = turService;
            _ulkeServis = ulkeServis;
            _sehirServis = sehirServis;
            _ilceServis = ilceServis;
            _bilgilerimServis = bilgilerimServis;
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
        { // kaydet bölümü

            // Güncelleme işlemi aktif çalışıyor grub ekleme kısmıyla aynı ama burada kullanmadım

            if (simpleButton6.Text == "Güncelle")
            {
                var findgrup = _bilgilerimServis.Get(_id);
                findgrup.AdSoyad = textEdityetkiliad.Text.ToLower();
                findgrup.TabelaAdi = textEdityetkiliad.Text;
                findgrup.Postakodu = textEditpostakod.Text;
                findgrup.Adres = textEditadres.Text;
                findgrup.Sabitno = textEditsabitno.Text;
                findgrup.Gsm = textEditgsm.Text;
                findgrup.Fax = textEditfax.Text;
                findgrup.Eposta = textEditeposta.Text;
                findgrup.Url = textEditurl.Text;
                findgrup.Vergidaire = textEditvergidaire.Text;
                findgrup.Vergino = textEditvergino.Text;
                var result = _bilgilerimServis.Update(findgrup);
                if (result)
                {

                    GetList();
                    Clear();

                }

            }
            else
            {
                // Kaydet işlemi
                Bilgilerim bilgilerim = new Bilgilerim
                {

                    TabelaAdi = textEdityetkiliad.Text,
                    Postakodu = textEditpostakod.Text,
                    Adres = textEditadres.Text,
                    Sabitno = textEditsabitno.Text,
                    Gsm = textEditgsm.Text,
                    Fax = textEditfax.Text,
                    Eposta = textEditeposta.Text,
                    Url = textEditurl.Text,
                    Vergidaire = textEditvergidaire.Text,
                    Vergino = textEditvergino.Text,
                    AdSoyad = textEdityetkiliad.Text.ToLower()
                };

                //_grubServices.Add(grub);

                // status yada durum için 

                var result = _bilgilerimServis.add(bilgilerim);
                if (result)
                {

                    GetList();
                    Clear();
                }

            }

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

        void Clear()
        {
            textBoxtabelaad.Text = " ";
            simpleButtonclose.Text = "Kapat";
            simpleButton6.Text = "Kaydet";
        }

        void GetList()
        {
            var result = _bilgilerimServis.GetList();
            gridControl1.DataSource = result;
        }

        private void XtraHomes_Load(object sender, EventArgs e)
        {// sayfa

            var grubs = _grubService.GetList();
            lookUpEditgrub.Properties.DataSource = grubs;

            var ulkes = _ulkeServis.GetList();
            lookUpEditUlke.Properties.DataSource = ulkes;

            var sehirs = _sehirServis.GetList();
            lookUpEditsehir.Properties.DataSource = sehirs;


            var result = _bilgilerimServis.GetList();
            gridControl1.DataSource = result;



        }

        private void simpleButtonclose_Click(object sender, EventArgs e)
        {// kapat
            if (simpleButtonclose.Text == "Vazgeç")
            {
                Clear();
            }
            else
            {
                this.Close();
            }
        }
    }
}