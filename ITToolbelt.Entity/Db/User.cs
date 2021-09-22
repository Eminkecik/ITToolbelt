using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITToolbelt.Entity.Db
{
    public class User
    {
        public int Id { get; set; }
        public int? SystemUserId { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }


        public SystemUser SystemUser { get; set; }
        public List<UserGroup> UserGroups { get; set; }

        [NotMapped]
        public string Fullname => $"{Name} {Surname}";
    }
}