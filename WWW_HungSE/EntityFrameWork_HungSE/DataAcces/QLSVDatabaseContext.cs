﻿using EntityFrameWork_HungSE.EntitiesHungSE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_HungSE.DataAcces
{
    public class QLSVDatabaseContext: DbContext
    {
        public QLSVDatabaseContext() : base("QLSVConnectionString")
        {
            Configuration.LazyLoadingEnabled = true;
        }

    public DbSet<MonHoc> MonHocs { get; set; }
    public DbSet<LopHocPhan> LopHocPhans { get; set; }
    public DbSet<KetQuaHocTap> KetQuaHocTaps { get; set; }
    public DbSet<SinhVien> SinhViens { get; set; }
    public DbSet<GiangVien> GiangViens { get; set; }
    public DbSet<HocKy> HocKies { get; set; }
    public DbSet<KhoaHoc> KhoaHocs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
}
