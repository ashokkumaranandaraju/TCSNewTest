using Course.App.DataModel;
using Course.App.DataModel.Dto;
using Course.App.WebApi.Services;
using Course.App.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Course.App.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        private readonly ISubscriptionService _subscriptionService;
        public SubscriptionController(ISubscriptionService subscriptionService)
        {
            _subscriptionService=subscriptionService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubscription(Subscription data)
        {
            try
            {
                return Ok(await _subscriptionService.CreateSubscription(data));
            
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }


        [HttpPost]
        public async Task<IActionResult> GetAllSubscriptions(FiltersDto filters = null, int skip = 0, int take = 0)
        {
            try
            {
                return Ok(await _subscriptionService.GetAllSubscriptions(filters, skip, take));

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> GetSubscriptionDetails(FiltersDto filters = null, int skip = 0, int take = 0)
        {
            try
            {
                return Ok(await _subscriptionService.GetSubscriptionDetails(filters, skip, take));

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }


    }
}
