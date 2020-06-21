using EntityFrameWork_HungSE.EntitiesHungSE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_Interface_HungSE
{
   public interface IHocKyService:IBaseService<HocKy> 
    {
        HocKy Add(HocKy hocky);
        HocKy Update(HocKy hocky);
        bool Delete(int hockyId);
    }
}
