using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logic.DTO
{
    public class UserDTO
    {
        [Key, Column("User indentity")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Not contain name"), MinLength(4), MaxLength(16), Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Not contain Surname"), MinLength(4), MaxLength(16), Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required, Display(Name = "EMail"), EmailAddress(ErrorMessage = "Incorrect address")]
        public string EMail { get; set; }
        public int RoleId { get; set; }
        public RoleDTO Role { get; set; }

        [Required, MinLength(4), MaxLength(16)]
        public string Password { get; set; }

        [Required, MinLength(4), MaxLength(16)]
        public string Login { get; set; }
    }
}
