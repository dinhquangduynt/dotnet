using System;
using System.Collections.Generic;
using System.Linq;
using _102160135_DinhQuangDuy_LINQ.Models;

namespace _102160135_DinhQuangDuy_LINQ
{
    class QLSV
    {
        private demoContext db;

        public QLSV(){
            db = new demoContext();
        }
        public List<Sv> GetAllSv()
        {           
            return db.Sv.Select(p => p).ToList();
        }

        public Sv GetSingleSvById(int mssv){
            Sv sv = null;
            try
            {
                sv = db.Sv.Where(p => p.Mssv == mssv).FirstOrDefault();
               
            }
            catch (System.Exception)
            {
                Console.WriteLine("Khong ton tai sinh vien co ma so " + mssv);
            }
              return sv;
        }

        public void AddSv(Sv sv_add){
            db.Sv.Add(sv_add);
            db.SaveChanges();
        }


        public void DeleteSvById(int mssv){
            try
            {
                Sv sv_del = GetSingleSvById(mssv);
                db.Sv.Remove(sv_del);
                db.SaveChanges();
            }
            catch (System.Exception)
            {
                
               Console.WriteLine("Khong ton tai sinh vien co ma so " + mssv);
            }
        }

        public void DeleteSvByIdLop(int idLop){
            try
            {
                List<Sv> sv_del = db.Sv.Where(p => p.IdLop == idLop).ToList();
                db.Sv.RemoveRange(sv_del);
                db.SaveChanges();
            }
            catch (System.Exception)
            {
                
                Console.WriteLine("Khong ton tai sinh vien co IdLop " + idLop);
            }
            
        }
        public void UpdateSv(int mssv, Sv sv){
             Sv sv_update = GetSingleSvById(mssv);
             sv_update.NameSv = sv.NameSv;
             sv_update.Gender = sv.Gender;
             sv_update.Birthday = sv.Birthday;
             sv_update.Dtb = sv.Dtb;
             sv_update.IdLop = sv.IdLop;
             db.SaveChanges();
        }

        public void DisplaySv(){
            foreach(Sv s in GetAllSv()){
                Console.Write("MSSV: " + s.Mssv);
                Console.Write("   Name: " + s.NameSv);
                Console.Write("   Gender: " + s.Gender);
                Console.Write("   Birthday: " + s.Birthday);
                Console.Write("   DTB: " + s.Dtb);
                Console.Write("   NameLop: " + s.IdLop);
                Console.WriteLine();
            }
        }


        // Lop
        public List<Lop> GetAllLop(){
             return db.Lop.Select(p => p).ToList();
        }

        
        public Lop GetSingleLopById(int ms){
            Lop lop = null;
            try
            {
                lop = db.Lop.Where(p => p.IdLop == ms).FirstOrDefault();
            }
            catch (System.Exception)
            {               
                 Console.WriteLine("Khong ton tai lop co id " + ms);
            }
             return lop;
        }

        public void AddLop(Lop lop){
               
                try
                {
                     db.Lop.Add(lop);
                     db.SaveChanges();  
                }
                catch (System.Exception)
                {
                   Console.WriteLine("Them khong thanh cong, IdLop da ton tai");
                }
                        
        }


        public void DeleteLopById(int ms){
            
            try
            {
                Lop lop_del = GetSingleLopById(ms);
                DeleteSvByIdLop(ms);
                db.Lop.Remove(lop_del);
                db.SaveChanges();
            }
            catch (System.Exception)
            {
                
                Console.WriteLine("Khong ton tai lop co ma so " + ms);
            }
           
        }

        public void UpdateLop(int ms, Lop lop){
            Lop lop_update = GetSingleLopById(ms);
            if(lop_update != null){
                lop_update.NameLop = lop.NameLop;
                db.SaveChanges();
            }
            else {
                Console.WriteLine("Khong ton tai lop co ma so " + ms);
            }
        }

        public void DisplayLop(){
            foreach(Lop lop in GetAllLop()){
                Console.WriteLine("IdLop:  " + lop.IdLop + "     NameLop: " + lop.NameLop);
            }
        }

    }
}
