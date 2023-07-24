using Course.App.DataModel;
using Course.App.WebApi.Services;
using Course.App.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Course.App.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingService _trainingService;
        public TrainingController(ITrainingService trainingService)
        {
            _trainingService = trainingService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTraining(Training data)
        {
            try
            {
                
                return Ok(await _trainingService.CreateTraining(data));
            }
            catch (Exception ex)
            {                
                return StatusCode(500, new { error = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTraining(Training data)
        {
            try
            {
                return Ok(await _trainingService.UpdateTraining(data));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}
