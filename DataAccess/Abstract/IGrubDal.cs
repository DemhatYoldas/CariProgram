using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGrubDal
    {
        void Add(Grub grub);
        void Update(Grub grub);
        void Delete(Grub grub);
        Grub Get(int id);
        List<Grub> GetList();
    }
}
