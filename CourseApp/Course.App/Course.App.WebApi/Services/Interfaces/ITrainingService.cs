using Course.App.DataModel;

namespace Course.App.WebApi.Services.Interfaces
{
    public interface ITrainingService
    {
        Task<Training> CreateTraining(Training data);
        Task<Training> UpdateTraining(Training data);
    }
}
