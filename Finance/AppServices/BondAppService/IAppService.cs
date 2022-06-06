using Finance.Models.BizModels.Bond;

namespace Finance.AppServices.BondAppService
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
