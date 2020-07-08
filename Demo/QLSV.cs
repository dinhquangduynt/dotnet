using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo
{
    public class QLSV
    {
        public SV[] listSV {get;set;}
        public int lenght{get;set;}

        public QLSV(){
            this.listSV = null;
            this.lenght = 0;
        }
        public void createDB(){
            SV s1 = new SV {MSSV = "1", Name ="khanh", Age = 19};
            SV s2 = new SV {MSSV = "1", Name ="hung", Age = 14};
            SV s3 = new SV {MSSV = "1", Name ="manh", Age = 20};
            SV s4 = new SV {MSSV = "1", Name ="duy", Age = 17};

            add(s1);
            add(s2);
            add(s3);
            add(s4);
        
        }

        public void add(SV sv){
            this.lenght++;
            if(this.listSV == null){
                listSV = new SV[lenght];
                listSV[0] = sv;
            }else{
                SV[] temp = this.listSV;
                listSV = new SV[lenght];
                for(int i = 0; i < temp.Length; i++){
                    this.listSV[i] = temp[i];
                }

                listSV[this.lenght - 1] = sv;
            }         
        }

        public void remove(SV sv){

            int index = indexOf(sv);
            removeAt(index);

        }

        public void removeAt(int index){
            SV[] temp = null;
             temp = new SV[listSV.Length - 1];

            if(index != this.listSV.Length - 1){
               for(int i = 0; i < listSV.Length; i++){
                    temp[i] = listSV[i];
                    if(i == index){
                        for(int j = i; j < listSV.Length - 1; j++){
                            temp[j] = listSV[j + 1];
                        }
                        break;
                    }
            }

            }else{
               for(int i = 0; i < temp.Length; i++){
                    temp[i] = listSV[i];
                }
            }
            
            listSV = new SV[temp.Length];
            listSV = temp;           
        }

        public int indexOf(SV sv){
            int count = 0;
            foreach(SV s in listSV){
                if(sv.MSSV == s.MSSV && sv.Name == s.Name && sv.Age == s.Age){
                    return count;
                }
                count++;
            }

            return 0;
        }

        public void update(SV sv, int index){

            int count = 0;
            foreach(SV s in listSV){
                if(index == count){
                    s.MSSV = sv.MSSV;
                    s.Name = sv.Name;
                    s.Age = sv.Age;
                    break;
                }
                count++;
            }
        }

        public void show(){
            foreach(SV s in listSV){
                Console.WriteLine(s.ToString());
            }
        }

        //sort Age
        public void sort(){
           for(int i = 0; i < listSV.Length; i++){

               for(int j = i+1; j < listSV.Length; j++){
                   if(listSV[i].Age > listSV[j].Age){
                   
                    swap(ref listSV[i], ref listSV[j]);
               }
               }
               
           }
        }

        public void swap(ref SV sv1, ref SV sv2){
            SV temp = sv1;
            sv1 = sv2;
            sv2 = temp;
        }
    }


    
}