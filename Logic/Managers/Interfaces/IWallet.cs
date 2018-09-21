using System.Collections.Generic;
using Logic.DTO;

namespace Logic.Managers.Interfaces
{
    public interface IWallet
    {
        WalletDTO GetWallet(int walletId);
        void EditWallet(WalletDTO walletDTO);
        List<WalletDTO> GetAllShowSum(int id);
        List<WalletDTO> ShowAllTransactions(int id);
        void AddWallet(WalletDTO walletDTO);
        List<WalletDTO> ShowAllWallets(int userId);
        void DeleteWallet(int id);
    }
}
