using System;
using _102160135_DinhQuangDuy_LINQ.Models;

namespace _102160135_DinhQuangDuy_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            QLSV qLSV = new QLSV();
            
            //create data
             Sv sv_add = new Sv{NameSv = "duyxxxx", Gender = true, Birthday = new DateTime(1998,12,12), Dtb = 8.0, IdLop = 2222};
             Lop lop = new Lop{IdLop = 2222, NameLop = "KTPM222"};

            // //get all sv
             Console.WriteLine("Hien thi danh sach sinh vien ");
            qLSV.DisplaySv();

            //get single sv
             Console.WriteLine("Hien thi 1 sinh vien ");
            qLSV.GetSingleSvById(100000);

            //Add sv
            Console.WriteLine("Them sinh vien ");
            qLSV.AddSv(sv_add);
            
            //update sv
            Console.WriteLine("Chinh sua sinh vien ");
            Sv sv_update = new Sv{NameSv = "Dinh Quang Duy", Gender = true, Birthday = new DateTime(1998,03,26), Dtb = 8.0, IdLop = 1};
            qLSV.UpdateSv(6,sv_update);

            //Delete sv
            Console.WriteLine("Xoa sinh vien ");
            qLSV.DeleteSvById(9);

            //Get all Lop
            Console.WriteLine("Hien thi danh sach lop ");
            qLSV.DisplayLop();

            //Add Lop
            Console.WriteLine("Them lop ");
            qLSV.AddLop(lop);

            //Update Lop
            Console.WriteLine("chinh sua lop ");
            Lop lop_update = new Lop{NameLop = "Kiem thu"};
            qLSV.UpdateLop(1,lop_update);

            //Delete lop
            Console.WriteLine("xoa lop ");
            qLSV.DeleteLopById(2222);



        }
    }
}
