namespace QLKTX.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            HoaDonChiTiet = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHoaDon { get; set; }

        [Required]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [Required]
        [StringLength(255)]
        public string TenHoaDon { get; set; }

        [Column(TypeName = "money")]
        public decimal TongTien { get; set; }

        public virtual Phong Phong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiet { get; set; }
    }
}
