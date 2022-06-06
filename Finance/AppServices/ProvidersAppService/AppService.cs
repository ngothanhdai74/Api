using AutoMapper;

namespace Finance.AppServices.ProvidersAppService
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
    }
}
