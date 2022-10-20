using StudentManagement.API.DTO;
using StudentManagement.API.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentManagement.API.Controllers
{
    [Authorize]
    public class StudentController : ApiController
    {

        private StudentService _studentService;


        [HttpGet]
        public List<DtoStudent> List() { 
            _studentService = new StudentService();
            return _studentService.GetStudentList();
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] DtoStudent _input)
        {
            _studentService = new StudentService();
            var result=_studentService.AddStudent(_input);
            if (result)
            return Ok();
            else
                return BadRequest();
        }

        [HttpPost]
        public IHttpActionResult AssignToCourse([FromBody] DtoStudent _input)
        {
            _studentService = new StudentService();
            return Ok(_studentService.AssignStudentToCourse(_input.StudentID,_input.CourseID));
        }

    }
}
