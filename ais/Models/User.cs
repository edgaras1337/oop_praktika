﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ais.Models
{
    public partial class User
    {
        public User()
        {
            SubjectGrades = new HashSet<SubjectGrade>();
            TeacherSubjects = new HashSet<TeacherSubject>();
            UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? GroupId { get; set; }

        public virtual Group Group { get; set; }
        public virtual ICollection<SubjectGrade> SubjectGrades { get; set; }
        public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
