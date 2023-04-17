using Business.Abstract;
using Business.Validation.FluentValidation;
using Core.CrossCuttingConcems;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation.Results;
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
            bool validation = ValidationTool.Validate(new GrubValidator(), grub);
            if (validation)
            {
                _grubDal.Add(grub);
                MessageBox.Show("Grub Başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            }
            return false;
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

        public bool Update(Grub grub)
        {
            bool validation = ValidationTool.Validate(new GrubValidator(), grub);
            if (validation)
            {
                _grubDal.Update(grub);
                MessageBox.Show("Güncelleme işlemi başarıyla Gerçekleşti", "Başarıyla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            }
            return false;

        }
    }
}
