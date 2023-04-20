using Business.Abstract;
using Business.Validation.FluentValidation;
using Core.CrossCuttingConcems.Validation;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BilgilerimManager : IBilgilerimServis
    {
        private readonly IBilgilerimDal _bilgilerimDal;
        private readonly IGrubDal _grubDal;
        private readonly ITurDal _turDal;
        private readonly IUlkeDal _ulkeDal;
        private readonly ISehirDal _sehirDal;
        private readonly IİlceDal _lceDal;

        public BilgilerimManager(IBilgilerimDal bilgilerimDal, IGrubDal grubDal, ITurDal turDal, IUlkeDal ulkeDal, ISehirDal sehirDal, IİlceDal lceDal)
        {
            _bilgilerimDal = bilgilerimDal;
            _grubDal = grubDal;
            _turDal = turDal;
            _ulkeDal = ulkeDal;
            _sehirDal = sehirDal;
            _lceDal = lceDal;
        }

        public bool add(Bilgilerim bilgilerim)
        {
            bool validation = ValidationTool.Validate(new BilgilerimValidator(), bilgilerim);
            if (validation)
            {
                _bilgilerimDal.add(bilgilerim); 
                MessageBox.Show("Cari Ekleme Başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            }
            return false;
        }

        public void Delete(Bilgilerim bilgilerim)
        {
            _bilgilerimDal.Delete(bilgilerim);
        }

        public Bilgilerim Get(int id)
        {
            return _bilgilerimDal.Get(id);
        }

        public int GetbilgilerimId(string grubName)
        {
            throw new NotImplementedException();
        }

        public List<Bilgilerim> GetList()
        {
            return _bilgilerimDal.GetList();
        }

        public bool Update(Bilgilerim bilgilerim)
        {
            bool validation = ValidationTool.Validate(new BilgilerimValidator(), bilgilerim);
            if (validation)
            {
                _bilgilerimDal.Update(bilgilerim);
                MessageBox.Show("Güncelleme işlemi başarıyla Gerçekleşti", "Başarıyla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            }
            return false;
        }
    }
}
