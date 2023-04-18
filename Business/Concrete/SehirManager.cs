using Business.Abstract;
using Business.Validation.FluentValidation;
using Core.CrossCuttingConcems.Validation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
    }
}
