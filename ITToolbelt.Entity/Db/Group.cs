using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITToolbelt.Entity.Db
{
    public class Group
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Group name cannot be blank.")]
        [MaxLength(100, ErrorMessage = "Group name can be up to 100 characters.")]
        [Index(IsUnique = true)]
        [DisplayName("Group Name")]
        public string Name { get; set; }

        public List<UserGroup> UserGroups { get; set; }
    }
}