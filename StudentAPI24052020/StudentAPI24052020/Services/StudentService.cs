using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAPI24052020.Models;

namespace StudentAPI24052020.Services
{
    public class StudentService : IStudentService
    {
        private DataContext _context { get; set; }
        public StudentService(DataContext context)
        {
            _context = context;
        }
        public Student AddNewStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public List<Student> GetAllStudent()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int studentId)
        {
            return _context.Students.FirstOrDefault(x => x.StudentId == studentId);
        }
    }
}