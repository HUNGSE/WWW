using EntityFrameWork_HungSE.EntitiesHungSE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_Interface_HungSE
{
  public interface IMonHocService: IBaseService<MonHoc> 
    {
        MonHoc Add(MonHoc monhoc);
        MonHoc Update(MonHoc monhoc);
        bool Delete(int MonHocId);
    }
}
