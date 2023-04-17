using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
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
    public partial class XtraGrubcs : DevExpress.XtraEditors.XtraForm
    {
        private readonly IGrubService _grubServices;
        public XtraGrubcs(IGrubService grubService)
        {
            InitializeComponent();
            _grubServices = grubService;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraGrubcs_Load(object sender, EventArgs e)
        {

            var result = _grubServices.GetList();
            gridControl1.DataSource = result;
        }
    }
}