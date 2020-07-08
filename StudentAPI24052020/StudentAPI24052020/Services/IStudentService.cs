using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAPI24052020.Models;

namespace StudentAPI24052020.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudent();
        Student GetStudentById(int studentId);
        Student AddNewStudent(Student student);
    }
}