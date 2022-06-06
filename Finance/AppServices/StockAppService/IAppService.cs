using Finance.Models.BizModels.Stock;

namespace Finance.AppServices.StockAppService
{
    public interface IAppService
    {
        Task<View> Get(string code);
        Task<IList<List>> Filter(Filter model);
        Task<View> Post(New model);
        Task<View> Put(Edit model);
        Task<View> Delete(string code);
    }
}
