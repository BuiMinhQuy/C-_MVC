namespace De2.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHang")]
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            ChiTietDHs = new HashSet<ChiTietDH>();
        }

        [Key]
        [StringLength(20)]
        public string MaDonHang { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDatHang { get; set; }

        [StringLength(20)]
        public string MaNguoiDung { get; set; }

        [StringLength(100)]
        public string DiaChiGiaoHang { get; set; }

        [StringLength(50)]
        public string PTThanhToan { get; set; }

        [StringLength(50)]
        public string TinhTrang { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNguoiNhanHang { get; set; }

        [Required]
        [StringLength(20)]
        public string SoDienThoaiNhanHang { get; set; }

        public long? TongTien { get; set; }

        public byte? GiamGia { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDH> ChiTietDHs { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }
    }
}
