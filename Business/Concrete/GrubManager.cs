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

        public bool Add(Grub grub)
        {
            _grubDal.Add(grub);
            return true;
        }

        public void Delete(Grub grub)
        {
            _grubDal.Delete(grub);
        }

        public Grub Get(int id)
        {
           return _grubDal.Get(id);
        }

        public List<Grub> GetList()
        {
            return _grubDal.GetList();
        }

        public void Update(Grub grub)
        {
            _grubDal.Update(grub);
        }
    }
}
