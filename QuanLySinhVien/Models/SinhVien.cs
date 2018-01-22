using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLySinhVien.Models
{
    public class SinhVien
    {
        [Key]
        [StringLength(10)]
        public string MSSV { get; set; }

        [StringLength(50)]
        [Required]
        public string HoTen { get; set; }

        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string MaLop { get; set; }
        [ForeignKey("MaLop")]
        public virtual Lop Lop{ get; set; }
        public virtual ICollection<KetQuaThi> KetQuaThis { get; set; }
    }
}