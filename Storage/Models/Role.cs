using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
