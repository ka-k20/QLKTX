namespace QLKTX.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KyLuat")]
    public partial class KyLuat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MakyLuat { get; set; }

        [Required]
        [StringLength(128)]
        public string MaSV { get; set; }

        [Required]
        [StringLength(255)]
        public string TenKyLuat { get; set; }
    }
}
