using System;
using System.Collections.Generic;

#nullable disable

namespace ais.Models
{
    public partial class Subject
    {
        public Subject()
        {
            TeacherSubjects = new HashSet<TeacherSubject>();
        }

        public int Id { get; set; }
        public string SubjectName { get; set; }

        public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }
}
