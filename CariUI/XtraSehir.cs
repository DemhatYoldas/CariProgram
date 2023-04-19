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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CariUI
{
    public partial class XtraSehir : DevExpress.XtraEditors.XtraForm
    {
        private readonly ISehirServis _sehirServis;
        private readonly IUlkeServis _ulkeServis;

        public XtraSehir(ISehirServis sehirServis, IUlkeServis ulkeServis)
        {
            InitializeComponent();
            _sehirServis = sehirServis;
            _ulkeServis = ulkeServis;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void Clear()
        {

            textEditSehirEkle.Text = " ";
            //btnClose.Text = "Kapat";
            //btnSave.Text = "Kaydet";
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Sehir sehir = new Sehir()
            {
                Ulkesid = ulkeId,
                Sehiradi = textEditSehirEkle.Text

            };
            var resutlt = _sehirServis.add(sehir);
            Clear();
            if (resutlt)
            {

            }

        }



        private void comboBoxUlke_SelectedIndexChanged(object sender, EventArgs e)
        {
            ulkeId = _ulkeServis.GetulkeId(comboBoxUlke.Text.ToUpper());

        }

        int ulkeId = 0;

        private void XtraSehir_Load(object sender, EventArgs e)
        {
            var ulkes = _ulkeServis.GetList();
            foreach (var ulke in ulkes)
            {
                comboBoxUlke.Properties.Items.Add(ulke.Ulkeadi);
            }
        }
    }
}