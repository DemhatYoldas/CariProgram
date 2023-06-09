﻿using Business.Abstract;
using Business.Validation.FluentValidation;
using Core.CrossCuttingConcems.Validation;
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
            //  HATA ALIYORUM BAĞLI OLMAYANLARI BİLE SİLMİYOR 
            //var result = _grubDal.CheckGrubUses(grub.id);
            //if (!result)
            //{
            //    MessageBox.Show("Bu grub atanmış Türler olduğundan bolüm silinemiyor ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
                
            //}
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

        public int GetgrubId(string grubName)
        {
            // tur ekleme işleminde grub name göre id kaydedecez
            return _grubDal.GetList().Where(g => g.Grubadi == grubName).Select(s => s.id).FirstOrDefault();
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
