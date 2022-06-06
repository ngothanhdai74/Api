namespace Finance.Infrastructure
{
    public static class Extensions
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<Repositories.FileStorage.AssetsHistoryStorage.IStorage, Repositories.FileStorage.AssetsHistoryStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.CategoriesStorage.IStorage, Repositories.FileStorage.CategoriesStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.CategoriesStorage.IStorage, Repositories.FileStorage.CategoriesStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.CategoriesStorage.IStorage, Repositories.FileStorage.CategoriesStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.CategoriesStorage.IStorage, Repositories.FileStorage.CategoriesStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.CategoriesStorage.IStorage, Repositories.FileStorage.CategoriesStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.CategoriesStorage.IStorage, Repositories.FileStorage.CategoriesStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.CategoriesStorage.IStorage, Repositories.FileStorage.CategoriesStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.CategoriesStorage.IStorage, Repositories.FileStorage.CategoriesStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.CategoriesStorage.IStorage, Repositories.FileStorage.CategoriesStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.CategoriesStorage.IStorage, Repositories.FileStorage.CategoriesStorage.Storage>();
        }
    }
}
