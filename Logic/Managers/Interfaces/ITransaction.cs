using System.Collections.Generic;
using Logic.DTO;
using Utils.Enums;

namespace Logic.Managers.Interfaces
{
    public interface ITransaction
    {
        void EditTransaction(TransactionDTO dTO);
        void DeleteTransaction(int id);
        List<TransactionDTO> GetTransactionByDate(string date);
        void AddTransaction(TransactionDTO dTO);
        List<TransactionDTO> GetTransactionsByType(TransactionType type);
        TransactionDTO GetTransaction(int id);
        List<TransactionDTO> ShowAllTransactions(int walletId);
        void UpdateSumWallet(TransactionDTO dTO);
    }
}
