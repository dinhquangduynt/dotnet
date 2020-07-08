using System;
using dbFirst.Models;
using System.Linq;


namespace dbFirst
{
    class Program
    {
        
        static void Main(string[] args)
        {
            using (var db = new demoContext()){

                // truy van doi tuong
                //querty
               // var s = (from p in db.Sv select p).ToList();
                // var s = (from p in db.Sv select new { p.NameSv, p.IdLopNavigation.NameLop}).ToList();

                var s = from p in db.Sv where p.NameSv == "Duy" select new { p.NameSv, p.IdLopNavigation.NameLop};

                //method
                
                //var s1 = db.Sv.Select (p => new { p.NameSv, p.IdLopNavigation.NameLop}).ToList();
               var s1 = db.Sv.Where (p => p.NameSv == "Duy").Select ( p=>new {p.NameSv, p.IdLopNavigation.NameLop});
                
                //
                foreach(var i in s1){
                    Console.WriteLine(i.NameSv);
                }
                //S1 HOAC S2  
                // 
                // foreach(var i in s){
                //      Console.WriteLine(i.NameSv + " " + i.NameLop);
                // }

                //==========================================================///
                // add
                //tao moi doi tuong
                Sv sv_add = new Sv{Mssv = 5,NameSv = "duytesst", Gender = true, Birthday = new DateTime(1998,12,12), Dtb = 8.0, IdLop = 2222};
                //them doi tuong trong entitys
                db.Sv.Add(sv_add);
                // dong bo tu entity ve CSDL
                db.SaveChanges();

                //delete
                // int MSSV = 1;
                // var sv_del = db.Sv.Where(p => p.Mssv == MSSV).FirstOrDefault();
                // db.Sv.Remove(sv_del);
                // db.SaveChanges();

            }
        }
    }
}
