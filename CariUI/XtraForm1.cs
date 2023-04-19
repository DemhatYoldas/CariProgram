using Business.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using Entities.Concrete;
using Microsoft.Identity.Client;
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
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        IGrubService _grubService;
        ITurServis _turService;
        IUlkeServis _ulkeServis;
        ISehirServis _sehirServis;
        IİlceServis _ilceServis;

        public XtraForm1(IGrubService grubService, ITurServis turServis, IUlkeServis ulkeServis, ISehirServis sehirServis, IİlceServis ilceServis)
        {
            InitializeComponent();
            _grubService = grubService;
            _turService = turServis;
            _ulkeServis = ulkeServis;
            _sehirServis = sehirServis;
            _ilceServis = ilceServis;
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

            LookUpEdit edt = sender as LookUpEdit;
            var grubId = Convert.ToInt32(edt.EditValue);
            var turs = _turService.GetList();
            var tt = turs.Where(x => x.Grubsid == grubId).ToList();

            lookUpEdit2.Properties.DataSource = tt;
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {

            var grubs = _grubService.GetList();

            lookUpEdit1.Properties.DataSource = grubs;

        }

        private void lookUpEdit2_TabIndexChanged(object sender, EventArgs e)
        {


        }

        private void lookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            //LookUpEdit edt = sender as LookUpEdit;
            //var grupIdValue = Convert.ToInt32(edt.EditValue);
            //var turLst = _turService.GetList().Where(d => d.Grubsid == grupIdValue).ToList();
            //lookUpEdit2.Properties.DataSource = turLst;
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}