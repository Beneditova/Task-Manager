﻿using System;
using System.Collections.Generic;

namespace TaskManager.Models
{
    public class Student
    {
        public int Id { get; set; }
        public virtual ApplicationUser User { get; set; }

        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        
    }
}