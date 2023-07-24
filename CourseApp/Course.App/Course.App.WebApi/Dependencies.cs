using Course.App.WebApi.Services;
using Course.App.WebApi.Services.Interfaces;

namespace Course.App.WebApi
{
    public class Dependencies
    {
        public static void AddDependencies(IServiceCollection services)
        {
            services.AddScoped<ISubscriptionService, SubscriptionService>();
            services.AddScoped<ITrainingService, TrainingService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
