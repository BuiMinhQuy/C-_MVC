namespace De2.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AnhChiTietSP")]
    public partial class AnhChiTietSP
    {
        [Key]
        [StringLength(20)]
        public string MaAnh { get; set; }

        [StringLength(20)]
        public string MaSPTheoMau { get; set; }

        [Required]
        public string TenFileAnh { get; set; }

        public virtual SPtheoMau SPtheoMau { get; set; }
    }
}
