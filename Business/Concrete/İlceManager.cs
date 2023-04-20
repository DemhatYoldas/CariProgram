using Business.Abstract;
using Business.Validation.FluentValidation;
using Core.CrossCuttingConcems.Validation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class İlceManager : IİlceServis
    {
        private readonly IİlceDal _ilceDal;

        public İlceManager(IİlceDal ilceDal)
        {
            _ilceDal = ilceDal; 
        }

        public bool add(İlce ilce)
        {
            bool validation = ValidationTool.Validate(new İlceValidator(), ilce);
            if (validation)
            {
                _ilceDal.add(ilce);
                MessageBox.Show("ilçe Başarıyla şehire eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            }
            return false;
        }

        public List<İlce> GetList()
        {
            return _ilceDal.GetList();
        }
    }
}
