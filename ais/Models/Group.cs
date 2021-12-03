using System;
using System.Collections.Generic;

#nullable disable

namespace ais.Models
{
    public partial class Group
    {
        public Group()
        {
            GroupSubjects = new HashSet<GroupSubject>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string GroupName { get; set; }

        public virtual ICollection<GroupSubject> GroupSubjects { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
