using Microsoft.Ajax.Utilities;
using StudentManagement.API.DTO;
using StudentManagement.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagement.API.Service
{
    public class StudentService
    {

        private StudentDBEntities _dbContext;

        public StudentService() {
            _dbContext = new StudentDBEntities();
        }

        public List<DtoStudent> GetStudentList() {
            List<DtoStudent> result = new List<DtoStudent>();

            _dbContext.GetStudentList(0, 0).ForEach(T =>
            {
                result.Add(new DtoStudent()
                {
                    CourseID = T.CourseID,
                    CourseName=T.CourseName,
                    EmailID=T.StudentEmail,
                    PhoneNo=T.Phone,
                    StudentID=T.StudentID.Value,
                    StudentName=T.StudName
                });
            });
            return result;

        }
        public bool AddStudent(DtoStudent _input) {
            if (string.IsNullOrWhiteSpace(_input.StudentName)) return false;
            if (string.IsNullOrWhiteSpace(_input.EmailID)) return false;
            var result= _dbContext.AddStudent(Guid.NewGuid(), _input.StudentName, _input.EmailID, _input.PhoneNo);
            if (result.First().ErrStatus.Equals(2))
                return false;
            return true;
        }

        public bool AssignStudentToCourse(Guid StudentID,Guid CourseID)
        {
            _dbContext.AssignCourseToStudent(StudentID, CourseID);
            return true;
        }
    }
}