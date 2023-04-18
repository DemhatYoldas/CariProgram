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
       
        public XtraHome(IGrubService grubService, ITurServis turService)
        {
            InitializeComponent();
            _grubService = grubService;
            _turService = turService;
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
            cariEkle = new XtraCariEkle(_grubService,_turService);
            cariEkle.Show();
        }
    }
}