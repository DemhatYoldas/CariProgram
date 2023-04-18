using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGrubService
    {
        bool Add(Grub grub);
        bool Update(Grub grub);
        void Delete(Grub grub);
        Grub Get(int id);
        int GetgrubId(string grubName);
        List<Grub> GetList();
    }
}
