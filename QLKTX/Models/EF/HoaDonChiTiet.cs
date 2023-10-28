namespace QLKTX.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonChiTiet")]
    public partial class HoaDonChiTiet
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHoaDon { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string SoDienCu { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string SoDienMoi { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string SoNuocCu { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string SoNuocMoi { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
