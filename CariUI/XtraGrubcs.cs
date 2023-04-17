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
        public XtraGrubcs()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraGrubcs_Load(object sender, EventArgs e)
        {
            CurrentDbContext db = new CurrentDbContext();
            var result = db.Grubs.ToList();
            gridControl1.DataSource = result;
        }
    }
}