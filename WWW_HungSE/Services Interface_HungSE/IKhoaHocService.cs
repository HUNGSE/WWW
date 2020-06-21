using EntityFrameWork_HungSE.EntitiesHungSE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_Interface_HungSE
{
   public interface IKhoaHocService:IBaseService<KhoaHoc> 
    {
        KhoaHoc Add(KhoaHoc khoahoc);
        KhoaHoc Update(KhoaHoc khoahoc);
        bool delete(int KhocHocID);
    }
}
