using AutoMapper;

namespace Finance.AppServices.BondAppService
{
    public class AppService : IAppService
    {
        private readonly IMapper _mapper;
        public AppService(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
