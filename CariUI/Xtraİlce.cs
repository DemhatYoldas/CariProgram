using Business.Abstract;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Export;
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
    public partial class Xtraİlce : DevExpress.XtraEditors.XtraForm
    {
        private readonly ISehirServis _sehirServis;
        private readonly IİlceServis _ilceServis;

        public Xtraİlce(IİlceServis ilceServis, ISehirServis sehirServis)
        {
            InitializeComponent();
            _ilceServis = ilceServis;
            _sehirServis = sehirServis;
        }

        private void Xtraİlce_Load(object sender, EventArgs e)
        {
            var sehirs = _sehirServis.GetList();
            foreach (var sehir in sehirs)
            {
                comboBoxsehiradi.Properties.Items.Add(sehir.Sehiradi);
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void Clear()
        {

            textEditilceadi.Text = " ";
            //btnClose.Text = "Kapat";
            //btnSave.Text = "Kaydet";
        }



        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            İlce ilce = new İlce()
            {
                İlceAdi = textEditilceadi.Text,
                Sehirsid = SehirId
            };
            var result = _ilceServis.add(ilce);
            Clear();
            if (result)
            {

            }
        }


        int SehirId = 0;

        private void comboBoxsehiradi_SelectedIndexChanged(object sender, EventArgs e)
        {
            SehirId = _sehirServis.GetSehirId(comboBoxsehiradi.Text.ToUpper());
        }
    }
}