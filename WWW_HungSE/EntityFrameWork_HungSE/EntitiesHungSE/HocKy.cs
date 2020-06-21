using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_HungSE.EntitiesHungSE
{
    public class HocKy
    {
        public int Hockyid { get; set; }
        public string tenHocKy { get; set; }
        public virtual List<LopHocPhan> LopHocPhans { get; set; }
    }
}
