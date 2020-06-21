using EntityFrameWork_HungSE.EntitiesHungSE;
using Repository_HungSE;
using Services_Interface_HungSE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_HungSE
{
    public class LopHocPhanService : ILopHocPhanService
    {
        private IQSinhVienRepository<LopHocPhan> lopHocPhanrepository;
        public LopHocPhanService()
        {
            lopHocPhanrepository = new QLSinhVienRepository<LopHocPhan>();
        }
        public LopHocPhan Add(LopHocPhan lophocphan)
        {
            return lopHocPhanrepository.Add(lophocphan);
        }

        public bool delete(int LhpId)
        {
            try
            {
                lopHocPhanrepository.Delete(LhpId);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<LopHocPhan> GetAll()
        {
            return lopHocPhanrepository.GetByWhere(s => true);
        }

        public LopHocPhan getById(object id)
        {
            return lopHocPhanrepository.GetById(id);
        }

        public LopHocPhan Update(LopHocPhan lophocphan)
        {
            var existing = lopHocPhanrepository.GetById(lophocphan.LopHocPhanId);
            if (existing != null)
            {
                existing.tenLopHocPhan = lophocphan.tenLopHocPhan;
                existing.MonHocId = lophocphan.MonHocId;
                existing.soLuong = lophocphan.soLuong;
                existing.GiangVienid = lophocphan.GiangVienid;
                existing.Hockyid = lophocphan.Hockyid;
                lopHocPhanrepository.Update(existing);
            }
            return null;
        }
    }
}
