//------------------------------------------------------------------------------
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
    
    public partial class GetStudentList_Result
    {
        public Nullable<System.Guid> StudentID { get; set; }
        public string StudName { get; set; }
        public string StudentEmail { get; set; }
        public string Phone { get; set; }
        public string CourseName { get; set; }
        public System.Guid CourseID { get; set; }
    }
}
