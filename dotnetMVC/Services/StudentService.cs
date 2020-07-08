using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetMVC.Services
{
    public interface IStudentService
    {
       List<Student> GetStudents();
       Student GetStudentById(int id);
        bool UpdateStudentInfor(Student studentInput);
    }

    public class StudentService : IStudentService
    {
        private DataContext _context;
        public StudentService(DataContext context)
        {
            _context = context;
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.Include(x => x.Class).FirstOrDefault(x => x.StudentId == id);
        }

        public List<Student> GetStudents()
        {
            return _context.Students.Include(x => x.Class).ToList();
        }

         public bool UpdateStudentInfor(Student studentInput)
        {
           var student = _context.Students.FirstOrDefault(x => x.StudentId == studentInput.StudentId);
           student.Studentname = studentInput.Studentname;
           student.BirthDate = studentInput.BirthDate;
           student.ClassId = studentInput.ClassId;
           _context.SaveChanges();
           return true;
        }
    }
}