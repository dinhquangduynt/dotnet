using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace codeFirst.Models
{

     [Table("Lop")]
    public class Lop
    {
        public Lop(){
            SinhViens = new HashSet<SinhVien>();
        }
        [Key]
        public int IdLop { get; set; }
        public string NameLop { get; set; }

        public virtual ICollection<SinhVien> SinhViens { get; set; }

    }
}