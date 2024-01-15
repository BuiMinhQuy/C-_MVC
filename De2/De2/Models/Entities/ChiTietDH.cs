namespace De2.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDH")]
    public partial class ChiTietDH
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaDonHang { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MaChiTietSP { get; set; }

        public int? SoLuongMua { get; set; }

        public long? DonGiaBan { get; set; }

        public virtual ChiTietSPBan ChiTietSPBan { get; set; }

        public virtual DonHang DonHang { get; set; }
    }
}
