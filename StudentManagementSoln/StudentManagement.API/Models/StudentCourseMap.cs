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
    using System.Collections.Generic;
    
    public partial class StudentCourseMap
    {
        public int ID { get; set; }
        public Nullable<System.Guid> StudentID { get; set; }
        public Nullable<System.Guid> CourseID { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
