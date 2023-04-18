using Business.Abstract;
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
    public partial class XtraHome : DevExpress.XtraEditors.XtraForm
    {
        private readonly IGrubService _grubService;
        private readonly ITurServis _turService;
        private readonly IUlkeServis _ulkeServis;
       
        public XtraHome(IGrubService grubService, ITurServis turService, IUlkeServis ulkeServis)
        {
            InitializeComponent();
            _grubService = grubService;
            _turService = turService;
            _ulkeServis = ulkeServis;
        }

        private void btnclose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnGrubekle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraGrubcs Grubcs = new XtraGrubcs(_grubService);
            //Grubcs.MdiParent = this;
            Grubcs.Show();
        }

       

        private void XtraHome_Load(object sender, EventArgs e)
        {

        }

        private void btnCariEkleme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraCariEkle cariEkle;
            cariEkle = new XtraCariEkle(_grubService,_turService,_ulkeServis);
            cariEkle.Show();
        }
    }
}