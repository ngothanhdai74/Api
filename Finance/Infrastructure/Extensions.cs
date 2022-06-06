namespace Finance.Infrastructure
{
    public static class Extensions
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            // Sql
            // Cache
            // Storage
            services.AddTransient<Repositories.FileStorage.AssetsHistoryStorage.IStorage, Repositories.FileStorage.AssetsHistoryStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.AssetStorage.IStorage, Repositories.FileStorage.AssetStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.BondStorage.IStorage, Repositories.FileStorage.BondStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.CategoriesStorage.IStorage, Repositories.FileStorage.CategoriesStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.CryptoCurrencyHistoryStorage.IStorage, Repositories.FileStorage.CryptoCurrencyHistoryStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.CryptoCurrencyStorage.IStorage, Repositories.FileStorage.CryptoCurrencyStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.ETFStorage.IStorage, Repositories.FileStorage.ETFStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.ProvidersStorage.IStorage, Repositories.FileStorage.ProvidersStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.StockHistoryStorage.IStorage, Repositories.FileStorage.StockHistoryStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.StockStorage.IStorage, Repositories.FileStorage.StockStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.TransactionStorage.IStorage, Repositories.FileStorage.TransactionStorage.Storage>();
            // Service

            // AppService

        }
    }
}
