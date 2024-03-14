namespace NguyenHoangLinh_QLBanhangMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.InteropServices;

    [Table("PhanQuyen")]
    public partial class PhanQuyen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhanQuyen()
        {
            NguoiDungs = new HashSet<NguoiDung>();
        }

        [Key]
        public int MaQuyen { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Tên quy?n")]
        public string TenQuyen { get; set; }

        [StringLength(200)]
        [Display(Name = "Mô t?")]
        public string MoTa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NguoiDung> NguoiDungs { get; set; }
    }
}
