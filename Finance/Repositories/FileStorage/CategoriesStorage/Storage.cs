namespace Finance.Repositories.FileStorage.CategoriesStorage
{
    public class Storage : IStorage
    {
        private readonly IConfiguration _configuration;
        private const string BaseFolder = "Categories";
        public Storage(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
