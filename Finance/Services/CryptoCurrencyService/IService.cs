using Finance.Models.BizModels.CryptoCurrency;

namespace Finance.Services.CryptoCurrencyService
{
    public interface IService
    {
        Task<View> Get(string code);
        Task<IList<List>> Filter(Filter model);
        Task<View> Post(New model);
        Task<View> Put(Edit model);
        Task<View> Delete(string code);
    }
}
