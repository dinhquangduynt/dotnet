using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

            //string s = "123";
            // int y = Int32.Parse(s);
            //Console.WriteLine(y + 1);
           // int y;
            //Int32.TryParse(s, out y);
            //Console.WriteLine(y + 1);
            //int z = Convert.ToInt32(s);
            //Console.WriteLine(z +1);

           // int x = 1, y =2;
           // Console.WriteLine("{0} + {1} = {2}", x,y,x+y);

            // string[] arr = new string[4];

            // foreach(string i in arr){
            //     Console.WriteLine(i);
            // }

            // string[][] arr2 = new string[3][];
            // arr2[0] = new string [] {"A", "C"};
            // arr2[1] = new string[] {"B", "D"};
            // arr2[2] = new string[] {"F", "E", "V", "T"};

            // foreach (string[] str in arr2){
            //     foreach(string i in str){
            //         Console.WriteLine(i);
            //     }
            // }

            QLSV qLSV = new QLSV();

            qLSV.createDB();
            qLSV.show();
            // Console.WriteLine("================");
            //   qLSV.sort();
            //   qLSV.show();


             SV s1 = new SV {MSSV = "112", Name ="asd123213", Age = 192};

             Console.WriteLine(qLSV.indexOf(s1));

             qLSV.update(s1, 3);
             qLSV.show();
            Console.WriteLine("================");
            // qLSV.removeAt(3);
             //qLSV.show();

            SV s2 = new SV {MSSV = "1", Name ="hung", Age = 14};
            Console.WriteLine("================");
            Console.WriteLine(qLSV.indexOf(s2));
            Console.WriteLine("================");
             qLSV.remove(s1);
             qLSV.show();

        }
    }
}
