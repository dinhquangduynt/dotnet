using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _21032020
{
    class Program
    {
        // static void Main(string[] args)
        // {

            //Connection > SqlConnection > doi tuong ket noi
            // command -> SqlCommand -> thuc hien tuong tac CSDL
            // SqlDataReader -> thanh phan trung gian luu tru du lieu
            //SQLDataAdapter -> cau noi trung gian DataSet


            //string cnnStr = @"Data Source=DESKTOP-012MFIK\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;User ID=sa;Password=quangduy98";
            //SqlConnection cnn = new SqlConnection(cnnStr);

            //string query1 = "select count (*) from SV";
            //"select * from SV";
            // string query = "insert into ";
            // SqlCommand cmd = new SqlCommand(query, cnn);
            // SqlDataReader reader;
            // string rs ="";

            // cnn.Open();
            //Console.WriteLine(cnn.State);
            //int n = (int) cmd.ExecuteScalar();
           // Console.WriteLine(n);
        //     Console.WriteLine(rs);
        //     cnn.Close();
            //Console.WriteLine(cnn.State);

            // string query = "insert into SV(NameSV, Gender, Birthday, DTB, ID_Lop) values ('Ho Gia Khanh', 0, 1998/11/11, 8, 1234) ";
            // InitDB(query);

            // string query_show ="select * from SV";
            // GetList(query_show);
            // string cnnStr = @"Data Source=DESKTOP-012MFIK\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
            // SqlConnection cnn = new SqlConnection(cnnStr);
            // DataSet ds = new DataSet();
            // DataTable dt = new DataTable();
            // string query1 = "select * from SV";
            // SqlDataAdapter da = new SqlDataAdapter(query1,cnn);
            // cnn.Open();
            // da.Fill(ds);
            // cnn.Close();

            // string rs ="";
            // foreach(DataRow i in ds.Tables[0].Rows){
            //     rs += i["MSSV"] + ", " + i["NameSV"] + "   ";
            // }

            // Console.WriteLine(rs);

        //     QLSV qlsv = new QLSV();
        //     SV sv = new SV {NameSV = "duy", Gender = true, Birthday = "1998/02/02", DTB = 8, NameLop = "kda"};

        //      SV sv1 = new SV {NameSV = "dueeeey", Gender = true, Birthday = "1998/02/01", DTB = 8, NameLop = "kda"};
        //     List<SV> lsv = qlsv.getAllSV();

        //     foreach(SV s in lsv){
        //         Console.WriteLine(s.NameSV);
        //     }

        //     qlsv.insertSV(sv);

        //     Console.WriteLine("%%%%%%%%%%%%");
        //     foreach(SV s in lsv){
        //         Console.WriteLine(s.NameSV);
        //     }

        //     qlsv.updateSV(sv1,1);

        //     Console.WriteLine("%%%%%%%%%%%%");
        //     foreach(SV s in lsv){
        //         Console.WriteLine(s.NameSV);
        //     }

        //     qlsv.deleteSV(1);

        //     Console.WriteLine("%%%%%%%%%%%%");
        //     foreach(SV s in lsv){
        //         Console.WriteLine(s.NameSV);
        //     }



           

        // }

        static public void InitDB(string query){
            string cnnStr = @"Data Source=DESKTOP-012MFIK\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;";
            SqlConnection cnn = new SqlConnection(cnnStr);

            //string query1 = "select count (*) from SV";
            //"select * from SV";
            //string query = "insert into ";
            SqlCommand cmd = new SqlCommand(query, cnn);
        
            cnn.Open();
            cmd.ExecuteNonQuery();
          
            cnn.Close();
        }

        static public void GetList(string query){
            string cnnStr = @"Data Source=DESKTOP-012MFIK\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;";
            SqlConnection cnn = new SqlConnection(cnnStr);

            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader reader;
            string rs ="";

            cnn.Open();

           reader = cmd.ExecuteReader();
           while(reader.Read()){
               rs += reader["NameSV"];
           }
            
            Console.WriteLine(rs);
            cnn.Close();
        }
    }
}
