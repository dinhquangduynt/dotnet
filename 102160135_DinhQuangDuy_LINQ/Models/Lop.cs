﻿using System;
using System.Collections.Generic;

namespace _102160135_DinhQuangDuy_LINQ.Models
{
    public partial class Lop
    {
        public Lop()
        {
            Sv = new HashSet<Sv>();
        }

        public int IdLop { get; set; }
        public string NameLop { get; set; }

        public virtual ICollection<Sv> Sv { get; set; }
    }
}
