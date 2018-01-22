using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLySinhVien.Models
{
    public class Lop
    {
        [Key]
        [StringLength(10)]
        public string MaLop { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLop { get; set; }

        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}