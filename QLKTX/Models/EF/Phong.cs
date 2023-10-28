namespace QLKTX.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phong")]
    public partial class Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phong()
        {
            HoaDon = new HashSet<HoaDon>();
            KhuNha = new HashSet<KhuNha>();
            HoaDonChiTiet = new HashSet<HoaDonChiTiet>();
            TrangThietBi = new HashSet<TrangThietBi>();
        }

        [Key]
        [StringLength(10)]
        public string MaPhong { get; set; }

        public int MaSV { get; set; }

        [Required]
        [StringLength(50)]
        public string TenPhong { get; set; }

        [Column(TypeName = "money")]
        public decimal GiaPhong { get; set; }

        [Required]
        [StringLength(10)]
        public string SoNguoiO { get; set; }

        [Required]
        [StringLength(30)]
        public string LoaiPhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhuNha> KhuNha { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrangThietBi> TrangThietBi { get; set; }
    }
}
