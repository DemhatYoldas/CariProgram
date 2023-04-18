using Business.Abstract;
using Business.Validation.FluentValidation;
using Core.CrossCuttingConcems.Validation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SehirManager : ISehirServis
    {
        private readonly ISehirDal _sehirDal;

        public SehirManager(ISehirDal sehirDal)
        {
            _sehirDal = sehirDal;
        }

        public bool add(Sehir sehir)
        {
            bool validation = ValidationTool.Validate(new SehirValidator(),sehir);
            if (validation)
            {
                _sehirDal.add(sehir);
                MessageBox.Show("sehir Başarıyla Ülkeye eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            }
            return false;
        }

        public Sehir Get(int id)
        {
            return _sehirDal.Get(id);
        }

        public List<Sehir> GetList()
        {
            return _sehirDal.GetList();
        }

        public int GetSehirId(string Sehiradi)
        {
            return _sehirDal.GetList().Where(g =>g.Sehiradi==Sehiradi).Select(s => s.id).FirstOrDefault();
        }
    }
}
