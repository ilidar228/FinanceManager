using System;
using System.ComponentModel.DataAnnotations;
using Utils.Enums;

namespace Storage.Models
{

    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [Required]
        public TransactionType Type { get; set; }
        [Required]
        public decimal SumChange { get; set; }
        public DateTime Date { get; set; }
        [MaxLength(40)]
        public string Comment { get; set; }

        public int WalletId { get; set; }
        public Wallet Wallet { get; set; }
    }
}
