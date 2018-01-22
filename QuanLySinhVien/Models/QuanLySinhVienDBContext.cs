using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    public class QuanLySinhVienDBContext :DbContext
    {
        public QuanLySinhVienDBContext() : base("QuanLySinhVienConnectionString")
        {

        }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<KetQuaThi> KetQuaThis { get; set; }
    }
}