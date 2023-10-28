namespace QLKTX.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhuNha")]
    public partial class KhuNha
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaKhuNha { get; set; }

        [Required]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [Required]
        [StringLength(50)]
        public string TenKhuNha { get; set; }

        [Required]
        [StringLength(10)]
        public string SoTang { get; set; }

        [Required]
        [StringLength(10)]
        public string SoPhong { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
