namespace NguyenHoangLinh_QLBanhangMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [Key]
        public int MaNguoiDung { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Tên ng??i dùng")]
        public string HoTen { get; set; }

        [StringLength(100)]
        [Display(Name = "Mô t?")]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        public string SoDienThoai { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }

        [StringLength(50)]
        public string AnhDaiDien { get; set; }

        public int? MaQuyen { get; set; }

        public virtual PhanQuyen PhanQuyen { get; set; }
    }
}
