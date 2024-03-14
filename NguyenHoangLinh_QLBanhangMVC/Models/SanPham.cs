namespace NguyenHoangLinh_QLBanhangMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.InteropServices;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        [Key]
        public int MaSanPham { get; set; }

        [Required(ErrorMessage = "Tên s?n ph?m là b?t bu?c nh?p")]
        [StringLength(50)]
        [Display(Name = "Tên s?n ph?m")]
        public string TenSanPham { get; set; }
        [Display(Name = "Mô t?")]

        public decimal GiaTien { get; set; }

        [Required]
        [StringLength(500)]
        public string MoTa { get; set; }

        public bool? LaSanPhamMoi { get; set; }

        [StringLength(50)]
        public string HinhAnh { get; set; }

        public int SoLuong { get; set; }

        public int? MaDanhMuc { get; set; }

        public virtual DanhMucSanPham DanhMucSanPham { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}
