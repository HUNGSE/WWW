using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity.Migrations.Builders;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_HungSE.EntitiesHungSE
{
    public class LopHocPhan
    {
        public int LopHocPhanId { get; set; }
        public string tenLopHocPhan { get; set; }
        public int MonHocId { get; set; }
        public int soLuong { get; set; }
        public virtual MonHoc MonHoc { get; set; }
        public int Hockyid { get; set; }
        public virtual HocKy HocKy { get; set; }
        public int GiangVienid { get; set; }
        public virtual GiangVien GiangVien { get; set; }
        public virtual List<KetQuaHocTap> KetQuaHocTaps { get; set; }
    }
}
