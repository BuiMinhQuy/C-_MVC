namespace De2.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguoiDung()
        {
            DonHangs = new HashSet<DonHang>();
        }

        [Key]
        [StringLength(20)]
        public string MaNguoiDung { get; set; }

        [StringLength(30)]
        public string TenDangNhap { get; set; }

        [StringLength(30)]
        public string TenNguoiDung { get; set; }

        [StringLength(12)]
        public string SoDienThoai { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(30)]
        public string MatKhau { get; set; }

        public string DiaChi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}
