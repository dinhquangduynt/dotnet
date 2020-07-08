using System;
using System.Collections.Generic;
using System.Linq;

namespace dotnetMVC.Models
{
    public class StudentModel
    {
        private DataContext _context {get;set;}

        public List<Student> GetStudents(){
            List<Student> students = _context.Students.ToList();
            // students.Add(new Student(){StudentId = 102160135, Studentname = " Duy", BirthDate = DateTime.Now});
            // students.Add(new Student(){StudentId = 102160135, Studentname = " Duy", BirthDate = DateTime.Now});
            // students.Add(new Student(){StudentId = 102160135, Studentname = " Duy", BirthDate = DateTime.Now});
            
            return students;
        }

        public Student GetStudentById(int id){
            if(id == 5){
                 return new Student {StudentId = 5, Studentname = " Duy", BirthDate = DateTime.Now};
            }
            else{
                 return new Student {StudentId = 102160135, Studentname = " Duy", BirthDate = DateTime.Now};
            }
           
        }
        
    }
}