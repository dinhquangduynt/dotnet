using System;

namespace _21032020{
    public class SV {
         public int MSSV{get; set;}
         public string NameSV{get; set;}
         public bool Gender{get; set;}
         public string Birthday{get; set;}
         public double DTB{get; set;}
         public string NameLop{get; set;}

         public override string ToString(){
            return (this.MSSV + this.NameSV + this.Gender + this.Birthday + this.DTB + this.NameLop);
        }

    }
}