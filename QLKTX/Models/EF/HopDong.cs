namespace QLKTX.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopDong")]
    public partial class HopDong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHD { get; set; }

        [Required]
        [StringLength(128)]
        public string MaSV { get; set; }

        public int MaNV { get; set; }

        public DateTime ThoiGIanBD { get; set; }

        public DateTime ThoiGianKT { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
