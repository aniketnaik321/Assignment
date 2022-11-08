using FluentValidation;
using StudentManagement.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagement.API.Validators
{
    public class StudentModelValidator:AbstractValidator<DtoStudent>
    {
        public StudentModelValidator() {
            RuleFor(T => T.CourseID)
                    .NotEmpty()
                    .WithMessage("Course ID Is required");

            RuleFor(T => T.CourseName)
                    .MinimumLength(5)
                    .WithMessage("Course Name should be minimum length of 5");
            RuleFor(T => T.StudentName)
                .NotEmpty().WithMessage("Student Name is required");
            
        }

    }
}