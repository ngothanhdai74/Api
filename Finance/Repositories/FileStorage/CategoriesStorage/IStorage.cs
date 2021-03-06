using Finance.Models.BizModels.Categories;
using Finance.Models.Common;

namespace Finance.Repositories.FileStorage.CategoriesStorage
{
    public interface IStorage
    {
        Task<View> Get(string code);
        Task<PagedResult<List>> Filter(Filter model);
        Task<View> Post(New model);
        Task<View> Put(Edit model);
        Task<View> Delete(string code);
    }
}
