using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISehirServis
    {
        bool add(Sehir sehir);
        Sehir Get(int id);
        int GetSehirId(string Ulkeadi);
        List<Sehir> GetList();

    }
}
