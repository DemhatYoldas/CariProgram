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
    public class UlkeManager : IUlkeServis
    {
        private readonly IUlkeDal _ulkeDal;


        public UlkeManager(IUlkeDal ulkeDal)
        {
            _ulkeDal = ulkeDal;
        }

        public bool add(Ulke ulke)
        {
            _ulkeDal.add(ulke);
            return true;
        }
    }
}
