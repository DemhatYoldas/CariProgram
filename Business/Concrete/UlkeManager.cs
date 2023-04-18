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
    public class UlkeManager : IUlkeServis
    {
        private readonly IUlkeDal _ulkeDal;


        public UlkeManager(IUlkeDal ulkeDal)
        {
            _ulkeDal = ulkeDal;
        }

        public bool add(Ulke ulke)
        {
            bool validation = ValidationTool.Validate(new UlkeValidator(), ulke);
            if (validation)
            {
                _ulkeDal.add(ulke);
                MessageBox.Show("ulke Başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            }
            return false;
        }

        public Ulke Get(int id)
        {
            return _ulkeDal.Get(id);
        }

        public List<Ulke> GetList()
        {
            return _ulkeDal.GetList();
        }

        public int GetulkeId(string Ulkeadi)
        {
            return _ulkeDal.GetList().Where(g => g.Ulkeadi == Ulkeadi).Select(s => s.id).FirstOrDefault();
        }
    }
}
