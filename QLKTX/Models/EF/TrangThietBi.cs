namespace QLKTX.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrangThietBi")]
    public partial class TrangThietBi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTTB { get; set; }

        [Required]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayLap { get; set; }

        [StringLength(255)]
        public string GhiChu { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
