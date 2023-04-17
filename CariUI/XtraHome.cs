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
    public partial class XtraHome : DevExpress.XtraEditors.XtraForm
    {
        private readonly IGrubService _grubService;
        public XtraHome(IGrubService grubService)
        {
            InitializeComponent();
            _grubService = grubService;
        }

        private void btnclose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnGrubekle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraGrubcs Grubcs = new XtraGrubcs(_grubService);
            Grubcs.MdiParent = this;
            Grubcs.Show();
        }

        private void XtraHome_Load(object sender, EventArgs e)
        {

        }
    }
}