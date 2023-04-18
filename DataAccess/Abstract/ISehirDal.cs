using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ISehirDal
    {
        void add(Sehir sehir);
        Sehir Get(int id);
        List<Sehir> GetList();
    }
}
