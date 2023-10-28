namespace QLKTX.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhenThuong")]
    public partial class KhenThuong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaKhenThuong { get; set; }

        [Required]
        [StringLength(128)]
        public string MaSV { get; set; }

        [Required]
        [StringLength(255)]
        public string TenKhenThuong { get; set; }
    }
}
