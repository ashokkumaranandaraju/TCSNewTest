using Course.App.DataModel;
using Course.App.DataModel.Dto;
using Course.App.WebApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Course.App.WebApi.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly TrainingSubscriptionDbContext _databaseContext;
        private readonly IUserService _userService;

        public SubscriptionService(TrainingSubscriptionDbContext databaseContext, IUserService userService)
        {
             _databaseContext = databaseContext;
            _userService = userService;
        }
        public async Task<Subscription> CreateSubscription(Subscription data)
        {
            var activeUsers = await _userService.GetUser(data.Userid);  

            if (activeUsers != null && activeUsers.Count >0 && activeUsers[0].Status.ToLower() == "active")
            {
                var result = await _databaseContext.Subscriptions.AddAsync(data);

                await _databaseContext.SaveChangesAsync();

                return result.Entity;
            }

            else 
                return null;
        }

        public async Task<List<SubscriptionDto>> GetAllSubscriptions(FiltersDto filters = null, int skip = 0, int take = 0)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SubscriptionDto>> GetSubscriptionDetails(FiltersDto filters = null, int skip = 0, int take = 0)
        {
            var subDetails = await (from sub in _databaseContext.Subscriptions
                                    join tra in _databaseContext.Trainings
                                    on sub.TrainingCode equals tra.TCode
                                    select new SubscriptionDto
                                    {
                                        SubsCode = sub.SubsCode,
                                        TrainingInfo = !string.IsNullOrEmpty(sub.TrainingCode) ? new TrainingDto
                                        {
                                            TCode = tra.TCode,
                                            Name = tra.Name,
                                            Month = tra.Month

                                        } : null

                                    }).ToListAsync();

            if (filters?.Month?.Any() ?? false)
            {
                subDetails = subDetails.Where(sf => sf?.TrainingInfo?.Month == filters.Month).ToList();
            }

            return subDetails;
        }
    }
}
