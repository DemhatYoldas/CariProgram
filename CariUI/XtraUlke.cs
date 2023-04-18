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
    public partial class XtraUlke : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUlkeServis _ulkeServis;
        public XtraUlke(IUlkeServis ulkeServis)
        {
            InitializeComponent();
            _ulkeServis = ulkeServis;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void Clear()
        {
            textEdit1.Text = " ";
            //btnClose.Text = "Kapat";
            //btnSave.Text = "Kaydet";
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ulke ulke = new Ulke
            {
                Ulkeadi = textEdit1.Text
            };
            var result = _ulkeServis.add(ulke);
            Clear();
        }
    }
}