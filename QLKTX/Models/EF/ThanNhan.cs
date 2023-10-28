namespace QLKTX.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanNhan")]
    public partial class ThanNhan
    {
        [Key]
        [StringLength(50)]
        public string TenTN { get; set; }

        public int MaSV { get; set; }

        [Required]
        [StringLength(255)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(10)]
        public string SDT { get; set; }

        [Required]
        [StringLength(20)]
        public string MoiQuanHe { get; set; }
    }
}
