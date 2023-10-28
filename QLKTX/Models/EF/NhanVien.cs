namespace QLKTX.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            HopDong = new HashSet<HopDong>();
        }

        [Key]
        public int MaNV { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTenNV { get; set; }

        [Required]
        [StringLength(255)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(10)]
        public string SDT { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(13)]
        public string CCCD { get; set; }

        [Required]
        [StringLength(50)]
        public string GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(20)]
        public string ChucVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDong> HopDong { get; set; }
    }
}
