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
    public partial class XtraTurekle : DevExpress.XtraEditors.XtraForm
    {
        IGrubService _grubService;
        ITurServis _turService;

        public XtraTurekle(IGrubService grubService, ITurServis turService)
        {
            InitializeComponent();
            _grubService = grubService;
            _turService = turService;
        }

        int grubId = 0;

        private void XtraTurek_Load(object sender, EventArgs e)
        {
            var grubs = _grubService.GetList();
            foreach (var grub in grubs)
            {
                comboBoxGrub.Properties.Items.Add(grub.Grubadi);
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void comboBoxGrub_SelectedIndexChanged(object sender, EventArgs e)
        {
            grubId = _grubService.GetgrubId(comboBoxGrub.Text);
            //MessageBox.Show(grubId.ToString()); id kontrol ettik 
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tur tur = new Tur()
            {
                Grubsid = grubId,
                Kod = textEditkod.Text,
                Unvan = textEditunvan.Text,
                Turadi = textEditTur.Text
            };

            var result = _turService.add(tur);
            if (result)
            {


            }
        }
    }
}
