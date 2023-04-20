using Business.Abstract;

namespace CariUI
{
    public partial class XtraHome : DevExpress.XtraEditors.XtraForm
    {
        private readonly IGrubService _grubService;
        private readonly ITurServis _turService;
        private readonly IUlkeServis _ulkeServis;
        private readonly ISehirServis _sehirServis;
        private readonly IİlceServis _ilceServis;
        private readonly IBilgilerimServis _bilgilerimServis;

        public XtraHome(IGrubService grubService, ITurServis turService, IUlkeServis ulkeServis, ISehirServis sehirServis, IİlceServis ilceServis, IBilgilerimServis bilgilerimServis)
        {
            InitializeComponent();
            _grubService = grubService;
            _turService = turService;
            _ulkeServis = ulkeServis;
            _sehirServis = sehirServis;
            _ilceServis = ilceServis;
            _bilgilerimServis = bilgilerimServis;
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
            cariEkle = new XtraCariEkle(_grubService, _turService, _ulkeServis, _sehirServis, _ilceServis, _bilgilerimServis);
            cariEkle.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btncarilistes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraCariEkle Grubcs = new XtraCariEkle(_grubService, _turService, _ulkeServis, _sehirServis, _ilceServis, _bilgilerimServis);
            Grubcs.MdiParent = this;
            Grubcs.Show();
        }
    }
}