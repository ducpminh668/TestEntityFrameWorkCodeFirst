using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLySinhVien.Models
{
    public class MonHoc
    {
        [Key]
        [StringLength(10)]
        public string MaMH { get; set; }

        [StringLength(50)]
        [Required]
        public string TenMon { get; set; }

        public virtual ICollection<KetQuaThi> KetQuaThis { get; set; }
    }
}