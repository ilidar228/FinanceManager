using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logic.DTO
{
    public class WalletDTO
    {
        [Key, Column("Wallet indentity")]
        public int WalletsId { get; set; }

        [Required(ErrorMessage = "Not contain wallet name"), MinLength(16), MaxLength(28), Display(Name = "Wallet name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Not contain summ"), Display(Name = "Summ")]
        public decimal Sum { get; set; }

        [Required(ErrorMessage = "Not contain currency"), Display(Name = "Currency"), MaxLength(3)]
        public string Currency { get; set; }
        
        public int UserId { get; set; }
        public UserDTO User { get; set; }
    }
}