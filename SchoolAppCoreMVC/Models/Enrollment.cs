﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace SchoolAppCoreMVC.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public decimal Grade { get; set; }

        public  Course? Course { get; set; }
        public  Student? Student { get; set; } 

    }
}
