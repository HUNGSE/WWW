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
    public class KhoaHocService : IKhoaHocService
    {
        private IQSinhVienRepository<KhoaHoc> khoaHocRepository;
        public KhoaHocService()
        {
            khoaHocRepository = new QLSinhVienRepository<KhoaHoc>();
        }
        public KhoaHoc Add(KhoaHoc khoahoc)
        {
            return khoaHocRepository.Add(khoahoc);
        }

        public bool delete(int KhocHocID)
        {
            try
            {
                khoaHocRepository.Delete(KhocHocID);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public IEnumerable<KhoaHoc> GetAll()
        {
            return khoaHocRepository.GetByWhere(s => true);
        }

        public KhoaHoc getById(object id)
        {
            return khoaHocRepository.GetById(id);
        }

        public KhoaHoc Update(KhoaHoc khoahoc)
        {
            var exsting = khoaHocRepository.GetById(khoahoc.KhoaHocID);
            if (exsting != null)
            {
                exsting.TCTThieu = khoahoc.TCTThieu;
                exsting.TCTDa = khoahoc.TCTDa;
                khoaHocRepository.Update(exsting);
            }
            return null;
        }
    }
}
