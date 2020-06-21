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
    public class MonHocService : IMonHocService
    {
        private IQSinhVienRepository<MonHoc> monHocrepository;
        public MonHocService()
        {
            monHocrepository = new QLSinhVienRepository<MonHoc>();
        }
        public MonHoc Add(MonHoc monhoc)
        {
            return monHocrepository.Add(monhoc);
        }

        public bool Delete(int MonHocId)
        {
            try
            {
                monHocrepository.Delete(MonHocId);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<MonHoc> GetAll()
        {
            return monHocrepository.GetByWhere(s => true);
        }

        public MonHoc getById(object id)
        {
            return monHocrepository.GetById(id);
        }

        public MonHoc Update(MonHoc monhoc)
        {
            var exting = monHocrepository.GetById(monhoc.MonhocId);
            if (exting != null)
            {
                exting.TenMonHoc = monhoc.TenMonHoc;
                exting.Sotinchi = monhoc.Sotinchi;
                exting.NgayBD = monhoc.NgayBD;
                exting.NgayKT = monhoc.NgayKT;
                exting.NgayKTDK = monhoc.NgayKTDK;
                monHocrepository.Update(exting);
            }
            return null;
        }
    }
}
