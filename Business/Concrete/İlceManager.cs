using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
            _ilceDal.add(ilce);
            return true;
        }
    }
}
