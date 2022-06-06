using Finance.Models.BizModels.CryptoCurrencyHistory;

namespace Finance.Repositories.FileStorage.CryptoCurrencyHistoryStorage
{
    public interface IStorage
    {
        Task<View> Get(string code);
        Task<IList<List>> Filter(Filter model);
        Task<View> Post(New model);
        Task<View> Put(Edit model);
        Task<View> Delete(string code);
    }
}
