﻿using EntityFrameWork_HungSE.EntitiesHungSE;
using Repository_HungSE;
using Services_Interface_HungSE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Services_HungSE
{
    public class GiangVienService : IGiangVienService
    {
        private IQSinhVienRepository<GiangVien> giangVienrepository;
        public GiangVienService()
        {
            giangVienrepository = new QLSinhVienRepository<GiangVien>();
        }

        public GiangVien Add(GiangVien gv)
        {
            return giangVienrepository.Add(gv);
        }

        public bool Delete(int GiangVienId)
        {
            try
            {
                giangVienrepository.Delete(GiangVienId);
                return true;
            }
            catch
            {

                return false;
            }

        }

        public IEnumerable<GiangVien> GetAll()
        {
           return giangVienrepository.GetByWhere(s=>true);
        }

        public GiangVien getById(object id)
        {
            return giangVienrepository.GetById(id);
        }

        public GiangVien Update(GiangVien gv)
        {
            var exting = giangVienrepository.GetById(gv.GiangVienid);
            if (exting != null)
            {
                exting.TenGiangVien = gv.TenGiangVien;
                exting.Gioitinh = gv.Gioitinh;
                exting.Ngaysinh = gv.Ngaysinh;
                exting.Diachi = gv.Diachi;
                exting.Email = gv.Email;
                exting.ChuyenNganh = gv.ChuyenNganh;
                giangVienrepository.Update(exting);
            }
            return null;
        }
    }
}
