using Finance.Models.BizModels.Stock;

namespace Finance.Repositories.FileStorage.StockStorage
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
