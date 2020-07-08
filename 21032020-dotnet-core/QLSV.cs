using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _21032020{ 
    public class QLSV {

        static void Main(string[] args){
            QLSV qlsv = new QLSV();
            SV sv = new SV {NameSV = "duy", Gender = true, Birthday = "02/02/1998", DTB = 8, NameLop = "kda"};
          
             List<SV> lsv = qlsv.getAllSV();
             qlsv.show(lsv);
            Console.WriteLine("============== Get ALL ============");
            qlsv.show(lsv);

            Console.WriteLine("============ insert sv =============");
            qlsv.insertSV(sv);
            qlsv.show(lsv);

            SV sv1 = new SV {NameSV = "Dinh Quang Duy", Gender = true, Birthday = "01/02/1990", DTB = 8, NameLop = "kda"};
            
            Console.WriteLine("============ Update sv =============");
            qlsv.updateSV(sv1,3);
            qlsv.show(lsv);

           
            Console.WriteLine("============ Delete SV =============");
            qlsv.deleteSV(1);
            qlsv.show(lsv);
        }
        
        SqlDataAdapter adapter;
        SqlCommand cmd;
        List<SV> listSV = new List<SV>();
        public SqlConnection connectDB(){
            string cnnStr = @"Data Source=DESKTOP-012MFIK\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
            return new SqlConnection(cnnStr);
        }

        public void show(List<SV> lsv){
             foreach(SV s in lsv){
                Console.Write("MSSV " + s.MSSV);
                Console.Write("   Name " + s.NameSV);
                Console.Write("   Gender " + s.Gender);
                Console.Write("   Birthday " + s.Birthday);
                Console.Write("   DTB " + s.DTB);
                Console.Write("   NameLop " + s.NameLop);
                Console.WriteLine();

            }
        }
         public List<SV> getAllSV(){
            
            string query = "select * from SV";
            SqlConnection sqlConn = connectDB();
            adapter = new SqlDataAdapter(query,sqlConn);

            sqlConn.Open();
            
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

             foreach(DataRow row in dataTable.Rows){
               SV sv = new SV {
                   MSSV = (int)row["MSSV"],
                   NameSV = row["NameSV"].ToString(),
                   Gender = (bool)row["Gender"], 
                   Birthday = row["Birthday"].ToString(), 
                   DTB = Convert.ToDouble(row["DTB"].ToString()), 
                   NameLop = row["NameLop"].ToString()
                   };

                   listSV.Add(sv);
            }

            sqlConn.Close();

            return listSV;
        }

        public bool insertSV(SV sv){
            int gender;
            if(sv.Gender){
                gender = 1; 
            }else gender = 0;

             string query = "insert into SV(NameSV, Gender, Birthday, DTB, NameLop) values ('" + sv.NameSV + "', " + gender 
             +", '" + sv.Birthday + "', " + sv.DTB + ", '" + sv.NameLop +"')";
            SqlConnection sqlConn = connectDB();          
            
            try
            {
                cmd = new SqlCommand(query,sqlConn);
                sqlConn.Open();
                cmd.ExecuteNonQuery();
                listSV.Add(sv);
                sqlConn.Close();
            }
            catch (Exception e)
            {
                
                return false;
            }

            return true;        
        }

        public bool updateSV(SV sv, int MSSV){

             int gender;
            if(sv.Gender) {
                gender = 1; 
            }else gender = 0;
             
            string query = "update SV set NameSV = '" + sv.NameSV + "', Gender = " +  gender + ", Birthday = '" +sv.Birthday +
            "', DTB = " + sv.DTB + ", NameLop = '" + sv.NameLop +"' where MSSV = " + MSSV; 
            SqlConnection sqlConn = connectDB();          
            
            try
            {
                cmd = new SqlCommand(query,sqlConn);
                sqlConn.Open();
                cmd.ExecuteNonQuery();
                updateListSV(sv,MSSV);
                sqlConn.Close();
            }
            catch (Exception e)
            {
                
                return false;
            }

            return true;       
        }

        public bool updateListSV(SV sv, int MSSV){
            if(MSSV < 0 || MSSV >= listSV.Count){
                return false;
            }
            foreach(SV s in listSV){
                if(s.MSSV == MSSV){
                    s.NameSV = sv.NameSV;
                    s.Gender = sv.Gender;
                    s.Birthday = sv.Birthday;
                    s.DTB = sv.DTB;
                    s.NameLop = sv.NameLop;
                    return true;
                }
            }
            return false;
        }

        public bool deleteSV(int MSSV){
            string query = "delete from SV where MSSV = " + MSSV; 
            SqlConnection sqlConn = connectDB();          
            
            try
            {
                cmd = new SqlCommand(query,sqlConn);
                sqlConn.Open();
                cmd.ExecuteNonQuery();
                listSV.RemoveAll(sv => sv.MSSV == MSSV);
                sqlConn.Close();
            }
            catch (Exception e)
            {
                
                return false;
            }

            return true;       
        }

        public bool deleteAllSV(){
            string query = "delete from SV";
            SqlConnection sqlConn = connectDB();          
            
            try
            {
                cmd = new SqlCommand(query,sqlConn);
                sqlConn.Open();
                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception e)
            {
                
                return false;
            }

            return true;       

        }
    }
}