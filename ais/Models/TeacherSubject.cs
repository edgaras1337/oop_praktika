using System;
using System.Collections.Generic;

#nullable disable

namespace ais.Models
{
    public partial class TeacherSubject
    {
        public TeacherSubject()
        {
            GroupSubjects = new HashSet<GroupSubject>();
            SubjectGrades = new HashSet<SubjectGrade>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<GroupSubject> GroupSubjects { get; set; }
        public virtual ICollection<SubjectGrade> SubjectGrades { get; set; }
    }
}
