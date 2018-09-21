using System;
using Utils.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logic.DTO
{
    public class TransactionDTO
    {
        [Key, Column("Transaction number"), Display(Name = "Transaction number")]
        public int TransactionId { get; set; }
        [Required(ErrorMessage = "Not contain operation"), Column("Transaction type"), Display(Name = "Transaction type")]
        public TransactionType Type { get; set; }
        [Required(ErrorMessage = "Not contain summ"), Column("Summ change"), Display(Name = "Summ change")]
        public decimal SumChange { get; set; }
        [Column("Transaction date"), Display(Name = "Transaction date")]
        public DateTime Date { get; set; }
        [Column("Comment type"), Display(Name = "Comment"), MaxLength(40)]
        public string Comment { get; set; }
        public int WalletId { get; set; }
    }
}