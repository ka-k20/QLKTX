namespace QLKTX.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuChuyenPhong")]
    public partial class PhieuChuyenPhong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPhieu { get; set; }

        public int MaSV { get; set; }

        [Required]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayLap { get; set; }

        [StringLength(255)]
        public string GhiChu { get; set; }
    }
}
