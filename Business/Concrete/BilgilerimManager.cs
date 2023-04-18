using Business.Abstract;
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
    public class BilgilerimManager : IBilgilerimServis
    {
        private readonly IBilgilerimDal _bilgilerimDal;

        public BilgilerimManager(IBilgilerimDal bilgilerimDal)
        {
            _bilgilerimDal = bilgilerimDal;
        }

        public bool add(Bilgilerim bilgilerim)
        {
            _bilgilerimDal.add(bilgilerim);
            return true;
        }
    }
}
