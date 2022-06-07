using Finance.Models.BizModels.Categories;
using Finance.Models.Common;

namespace Finance.Services.CategoriesService
{
    public interface IService
    {
        Task<View> Get(string code);
        Task<PagedResult<List>> Filter(Filter model);
        Task<View> Post(New model);
        Task<View> Put(Edit model);
        Task<View> Delete(string code);
    }
}
