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
    public class GrubManager : IGrubService
    {
        private readonly IGrubDal _grubDal;

        public GrubManager(IGrubDal grubDal)
        {
            _grubDal = grubDal;
        }

        public List<Grub> GetList()
        {
            return _grubDal.GetList();
        }
    }
}
