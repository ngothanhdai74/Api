using Finance.Models.BizModels.StockHistory;

namespace Finance.Services.StockHistoryService
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
