using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_HungSE.EntitiesHungSE
{
    public class MonHoc
    {
        public int MonhocId { get; set; }
        public string TenMonHoc { get; set; }
        public int Sotinchi { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKTDK { get; set; }
        public DateTime NgayKT { get; set; }
        public virtual List<LopHocPhan> LopHocPhans { get; set; }
    }
}
