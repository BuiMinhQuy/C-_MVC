namespace De2.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            SPtheoMaus = new HashSet<SPtheoMau>();
        }

        [Key]
        [StringLength(20)]
        public string MaSanPham { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[A-Za-z].*$", ErrorMessage = "Mô tả phải bắt đầu bằng chữ cái.")]
        public string TenSanPham { get; set; }

        [StringLength(20)]
        public string MaPhanLoai { get; set; }
        [RegularExpression(@"^[0-9]+$",ErrorMessage ="Nhập số")]
        public long? GiaNhap { get; set; }
        [RegularExpression(@"^[0-9]+$",ErrorMessage ="nhap so")]
        public long? DonGiaBanNhoNhat { get; set; }
        [RegularExpression(@"^[0-9]+$",ErrorMessage ="Nhap so")]
        public long? DonGiaBanLonNhat { get; set; }

        public bool? TrangThai { get; set; }
        [RegularExpression(@"^[A-Za-z].*$",ErrorMessage ="Nhập chữ")]
        public string MoTaNgan { get; set; }
        [RegularExpression(@"^.+\.jpg$",ErrorMessage ="Đuôi jpg")]
        public string AnhDaiDien { get; set; }

        public bool? NoiBat { get; set; }

        [StringLength(20)]
        public string MaPhanLoaiPhu { get; set; }

        public virtual PhanLoai PhanLoai { get; set; }

        public virtual PhanLoaiPhu PhanLoaiPhu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPtheoMau> SPtheoMaus { get; set; }
    }
}
