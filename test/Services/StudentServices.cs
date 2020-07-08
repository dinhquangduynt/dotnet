using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using test.Models;

namespace test.Services
{
    public interface IStudentServices
    {
        List<Student> GetStudents();
        Boolean CreateStudent(Student student);
    }

    public class StudentServices : IStudentServices
    {

        private DataContext _dataContext;
        public StudentServices(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Student> GetStudents()
        {
            return _dataContext.Students.Include(x => x.Class).ToList();
        }

        public Boolean CreateStudent(Student student){
            return false;
        }

    }
}