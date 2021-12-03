using System;
using System.Collections.Generic;

#nullable disable

namespace ais.Models
{
    public partial class GroupSubject
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int TeacherSubjectId { get; set; }

        public virtual Group Group { get; set; }
        public virtual TeacherSubject TeacherSubject { get; set; }
    }
}
