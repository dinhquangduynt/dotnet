using System;
using System.Data.SqlClient;

namespace abc
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            string cnnStr = @"Data Source=DESKTOP-012MFIK\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;User ID=sa;Password=quangduy98";
            SqlConnection cnn = new SqlConnection(cnnStr);

            cnn.Open();
            Console.WriteLine(cnn.State);
            cnn.Close();
            Console.WriteLine(cnn.State);
        }
    }
}
