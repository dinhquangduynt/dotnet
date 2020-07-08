using System;
using _4_4_2020.Models;
using System.Linq;

namespace _4_4_2020
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new QLSVContext()){
                //querty
                var s = (from p in db.Sv select p).ToList();

                //method

                foreach(Sv i in s){
                    Console.WriteLine(i.NameSv);
                }
            }
            

           
        }
    }
}
