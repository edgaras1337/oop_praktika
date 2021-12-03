using System;
using System.Collections.Generic;

#nullable disable

namespace ais.Models
{
    public partial class SubjectGrade
    {
        public int Id { get; set; }
        public int? Grade { get; set; }
        public int UserId { get; set; }
        public int TeacherSubjectId { get; set; }

        public virtual TeacherSubject TeacherSubject { get; set; }
        public virtual User User { get; set; }
    }
}
