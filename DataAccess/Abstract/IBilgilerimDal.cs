using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBilgilerimDal
    {
        void add(Bilgilerim bilgilerim);
        void Update(Bilgilerim bilgilerim);
        void Delete(Bilgilerim bilgilerim);
        Bilgilerim Get(int id);
        List<Bilgilerim> GetList();
    }
}
