using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using DevExpress.XtraEditors;
using Entities.Concrete;
using Microsoft.VisualBasic;
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
        int _id;

        public XtraGrubcs(IGrubService grubService)
        {
            InitializeComponent();
            _grubServices = grubService;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "Vazgeç")
            {
                Clear();
            }
            else
            {
                this.Close();
            }

        }

        private void XtraGrubcs_Load(object sender, EventArgs e)
        {

            GetList();
        }

        void GetList()
        {
            var result = _grubServices.GetList();
            gC1.DataSource = result;
        }

        void Clear()
        {
            txtGrubName.Text = " ";
            btnClose.Text = "Kapat";
            btnSave.Text = "Kaydet";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Güncelleme işlemi
            if (btnSave.Text == "Güncelle")
            {
                var findgrup = _grubServices.Get(_id);
                findgrup.Grubadi = txtGrubName.Text;
                var result = _grubServices.Update(findgrup);
                if (result)
                {

                    GetList();
                    Clear();

                }

            }
            else
            {
                // Kaydet işlemi
                Grub grub = new Grub
                {
                    Grubadi = txtGrubName.Text
                };

                //_grubServices.Add(grub);

                // status yada durum için 
                var result = _grubServices.Add(grub);
                if (result)
                {

                    GetList();
                    Clear();
                }

            }

        }

        private void repositoryBtnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show($"{(gridView1.GetFocusedRow() as Grub).Grubadi} Grubunu Silmek İstiyor musunu ?", "Sil ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var grub = (gridView1.GetFocusedRow() as Grub);
                _grubServices.Delete(grub);
                GetList();
                Clear();
            }

        }

        private void gC1_Click(object sender, EventArgs e)
        {

        }

        private void repositoryBtnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _id = (gridView1.GetFocusedRow() as Grub).id;
            string grubadi = (gridView1.GetFocusedRow() as Grub).Grubadi;
            txtGrubName.Text = grubadi;
            btnSave.Text = "Güncelle";
            btnClose.Text = "Vazgeç";

        }
    }
}