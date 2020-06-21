using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_HungSE.EntitiesHungSE
{
    public class KhoaHoc
    {
        public int KhoaHocID { get; set; }
        public int TCTThieu { get; set; }
        public int TCTDa { get; set; }
        public virtual List<SinhVien> SinhViens { get; set; }
    }
}
