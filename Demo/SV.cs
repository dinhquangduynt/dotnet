using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo
{
    public class SV
    {
        public string MSSV {set; get;}
        public string Name {set; get;}
        public int Age {set; get;}

        public override string ToString(){
            return (this.MSSV + this.Name + this.Age);
        }

        // public override bool Equals(object? obj){
        //     if (obj is null)
        //     {
        //         throw new ArgumentNullException(nameof(obj));
        //     }

        //     if (this.Age > ((SV)obj).Age){
        //         return true;
        //     }else {
        //         return false;
        //     }
        // }
      
    }


}