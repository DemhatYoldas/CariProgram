using Business.Abstract;
using Business.Validation.FluentValidation;
using Core.CrossCuttingConcems.Validation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TurManager : ITurServis
    {
        private readonly ITurDal _turDal;

        public TurManager(ITurDal turDal)
        {
            _turDal = turDal;
        }

        public bool add(Tur tur)
        {
            bool validation = ValidationTool.Validate(new TurValidator(), tur);
            if (validation)
            {
                _turDal.add(tur);
                MessageBox.Show("Tur başarıyla eklendi","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return true;
            }
            return false;
          
        }
    }
}
