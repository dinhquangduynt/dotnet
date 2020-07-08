using System;
using System.Collections.Generic;

namespace dbFirst.Models
{
    public partial class Sv
    {
        public int Mssv { get; set; }
        public string NameSv { get; set; }
        public bool? Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public double? Dtb { get; set; }
        public int IdLop { get; set; }

        public virtual Lop IdLopNavigation { get; set; }
    }
}
