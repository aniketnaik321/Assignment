﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentManagement.API.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class StudentDBEntities : DbContext
    {
        public StudentDBEntities()
            : base("name=StudentDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentCourseMap> StudentCourseMaps { get; set; }
    
        public virtual ObjectResult<AddStudent_Result> AddStudent(Nullable<System.Guid> studentID, string studentName, string emailID, string phoneNo)
        {
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(System.Guid));
    
            var studentNameParameter = studentName != null ?
                new ObjectParameter("StudentName", studentName) :
                new ObjectParameter("StudentName", typeof(string));
    
            var emailIDParameter = emailID != null ?
                new ObjectParameter("EmailID", emailID) :
                new ObjectParameter("EmailID", typeof(string));
    
            var phoneNoParameter = phoneNo != null ?
                new ObjectParameter("PhoneNo", phoneNo) :
                new ObjectParameter("PhoneNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AddStudent_Result>("AddStudent", studentIDParameter, studentNameParameter, emailIDParameter, phoneNoParameter);
        }
    
        public virtual int AssignCourseToStudent(Nullable<System.Guid> studentID, Nullable<System.Guid> courseID)
        {
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(System.Guid));
    
            var courseIDParameter = courseID.HasValue ?
                new ObjectParameter("CourseID", courseID) :
                new ObjectParameter("CourseID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AssignCourseToStudent", studentIDParameter, courseIDParameter);
        }
    
        public virtual ObjectResult<GetStudentList_Result> GetStudentList(Nullable<int> pageNo, Nullable<int> pageLength)
        {
            var pageNoParameter = pageNo.HasValue ?
                new ObjectParameter("PageNo", pageNo) :
                new ObjectParameter("PageNo", typeof(int));
    
            var pageLengthParameter = pageLength.HasValue ?
                new ObjectParameter("PageLength", pageLength) :
                new ObjectParameter("PageLength", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStudentList_Result>("GetStudentList", pageNoParameter, pageLengthParameter);
        }
    }
}
