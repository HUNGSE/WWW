using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_HungSE.EntitiesHungSE
{
    public class KetQuaHocTap
    {
        public int KetQuaHocTapId { get; set; }
        public int LoaiDiem { get; set; }
        public int SinhVienId { get; set; }
        public virtual SinhVien SinhVien { get; set; }

        public int LopHocPhanId { get; set; }
        public virtual LopHocPhan LopHocPhan { get; set; }

      
    }
}
