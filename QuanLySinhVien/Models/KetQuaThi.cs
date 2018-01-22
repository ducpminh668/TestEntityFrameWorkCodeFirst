using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLySinhVien.Models
{
    public class KetQuaThi
    {
        [Key]
        [Column(Order =1)]
        public string MaSV { get; set; }

        [Key]
        [Column(Order =2)]
        public string MaMH { get; set; }

        public float DiemThi { get; set; }

        [ForeignKey("MaSV")]
        public virtual SinhVien SinhVien { get; set; }
        [ForeignKey("MaMH")]
        public virtual MonHoc MonHoc { get; set; }

    }
}