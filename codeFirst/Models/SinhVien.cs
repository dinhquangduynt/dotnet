using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace codeFirst.Models
{
    [Table("SinhVien")]
    public class SinhVien
    {
        [Key][Required]
        public string Mssv { get; set; }
        public string NameSv { get; set; }
        public int? Age { get; set; }
        public int IdLop { get; set; }

        [ForeignKey("IdLop")]
        public virtual Lop lop {get;set;}
    }
}