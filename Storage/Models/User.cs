using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required, MinLength(4), MaxLength(16)]
        public string Login { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string EMail { get; set; }
        [Required, MinLength(4), MaxLength(16)]
        public string Password { get; set; }

        public virtual List<Wallet> Wallets { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
