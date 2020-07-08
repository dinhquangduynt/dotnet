using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetMVC.Models;

namespace dotnetMVC.Services
{
    public interface IClassService{
        List<Class> GetClasses();
        Class GetClassById(int id);
       
    }

    public class ClassService : IClassService
    {
        private DataContext _context;
        public ClassService(DataContext context)
        {
            _context = context;
        }
        public Class GetClassById(int id)
        {
            return _context.Classes.FirstOrDefault(x => x.ClassId == id);
        }

        public List<Class> GetClasses()
        {
            return _context.Classes.ToList();
        }

       
    }
}