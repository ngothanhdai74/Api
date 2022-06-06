using AutoMapper;
using Finance.Models.BizModels.StockHistory;

namespace Finance.AppServices.StockHistoryAppService
{
    public class AppService : IAppService
    {
        private readonly IMapper _mapper;
        private readonly Services.AssetService.IService _assetService;

        public AppService(
            IMapper mapper,
            Services.AssetService.IService assetService
            )
        {
            _mapper = mapper;
            _assetService = assetService;
        }
        public async Task<View> Get(string code)
        {
            return default;
        }
        public async Task<IList<List>> Filter(Filter model)
        {
            return default;
        }
        public async Task<View> Post(New model)
        {
            return default;
        }
        public async Task<View> Put(Edit model)
        {
            return default;
        }
        public async Task<View> Delete(string code)
        {
            return default;
        }
    }
}
