namespace QLKTX.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        public string MaSV { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(30)]
        public string Khoa { get; set; }

        [StringLength(30)]
        public string Lop { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(5)]
        public string GioiTinh { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(13)]
        public string CCCD { get; set; }

        [StringLength(10)]
        public string MaPhong { get; set; }
    }
}
