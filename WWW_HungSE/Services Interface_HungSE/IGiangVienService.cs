using EntityFrameWork_HungSE.EntitiesHungSE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_Interface_HungSE
{
    public interface IGiangVienService: IBaseService<GiangVien>
    {
        GiangVien Add(GiangVien gv);
        GiangVien Update(GiangVien gv);
        bool Delete(int GiangVienId);
    }
}
