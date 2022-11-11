using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManagement.API.DTO
{ 
    
    public class DtoStudent
    {
        public Guid StudentID { get; set; }       
        
        public string StudName { get; set; }
        
        public string EmailID { get; set; }
        public string PhoneNo { get; set; }
        public string CourseName { get; set; }
        public Guid CourseID { get; set; }
    }
}