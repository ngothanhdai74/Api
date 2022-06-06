namespace Finance.Services.CategoriesService
{
    public class Service : IService
    {
        private readonly IConfiguration _configuration;
        private const string BaseFolder = "Categories";
        public Service(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
