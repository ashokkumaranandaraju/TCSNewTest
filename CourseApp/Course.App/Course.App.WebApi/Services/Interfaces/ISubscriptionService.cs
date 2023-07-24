using Course.App.DataModel;
using Course.App.DataModel.Dto;
using System.Threading.Tasks;

namespace Course.App.WebApi.Services.Interfaces
{
    public interface ISubscriptionService
    {
        Task<Subscription> CreateSubscription(Subscription data);
        Task<List<SubscriptionDto>> GetAllSubscriptions(FiltersDto filters = null, int skip = 0, int take = 0);
        Task<List<SubscriptionDto>> GetSubscriptionDetails(FiltersDto filters = null, int skip = 0, int take = 0);
    }
}
