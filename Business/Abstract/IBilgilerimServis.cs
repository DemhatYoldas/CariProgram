using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBilgilerimServis
    {
        
        bool add(Bilgilerim bilgilerim);
        bool Update(Bilgilerim bilgilerim);
        void Delete(Bilgilerim bilgilerim);
        List<Bilgilerim> GetList();
    }
}
