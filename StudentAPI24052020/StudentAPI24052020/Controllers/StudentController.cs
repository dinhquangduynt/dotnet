using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentAPI24052020.Models;
using StudentAPI24052020.Services;

namespace StudentAPI24052020.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService _studentService { get; set; }
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            return _studentService.GetAllStudent();
        }

        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            return _studentService.GetStudentById(id);
        }

        [HttpPost]
        public Student Post([FromBody] Student student)
        {
            return _studentService.AddNewStudent(student);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}