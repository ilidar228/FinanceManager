using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Wallet
    {
        [Key]
        public int WalletsId { get; set; }

        [Required, MinLength(16), MaxLength(28)]
        public string Name { get; set; }

        [Required, MaxLength(28)]
        public decimal Sum { get; set; }

        [Required, MaxLength(3)]
        public string Currency { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public virtual List<Transaction> Transactions { get; set; }
    }
}
