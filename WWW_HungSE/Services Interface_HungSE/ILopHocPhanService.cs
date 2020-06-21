﻿using EntityFrameWork_HungSE.EntitiesHungSE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_Interface_HungSE
{
    public interface ILopHocPhanService: IBaseService<LopHocPhan> 
    {
        LopHocPhan Add(LopHocPhan lophocphan);
        LopHocPhan Update(LopHocPhan lophocphan);
        bool delete(int LhpId);
    }
}
