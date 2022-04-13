using Microsoft.Extensions.DependencyInjection;

namespace IEnv
{
    public static class ServiceCollectionExtension
    {
        public static void AddIEnv(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IEnv, Env>();
        }
    }
}
