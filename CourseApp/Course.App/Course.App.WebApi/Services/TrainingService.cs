using Course.App.DataModel;
using Course.App.WebApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Course.App.WebApi.Services
{
    public class TrainingService : ITrainingService
    {
        private readonly TrainingSubscriptionDbContext _databaseContext;

        public TrainingService(TrainingSubscriptionDbContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task<Training> CreateTraining(Training data)
        {
            
            var activeCource = await _databaseContext.Courses.SingleAsync(c => c.Name.ToUpper() == data.Course.ToUpper() && c.Status =="Active");
            if (activeCource == null)
                return null;

            var result = await _databaseContext.Trainings.AddAsync(data);

            await _databaseContext.SaveChangesAsync();

            return result.Entity;
            
        }

        public async Task<Training> UpdateTraining(Training data)
        {
            var editTrainingEntity = await _databaseContext.Trainings.SingleAsync(uf => uf.Id == data.Id);
            if (editTrainingEntity != null)
            {
                editTrainingEntity.TCode=data.TCode;
                editTrainingEntity.Name=data.Name;
                editTrainingEntity.Status=data.Status;
                editTrainingEntity.Course=data.Course;
                editTrainingEntity.Month=data.Month;
            }
            var result =  _databaseContext.Trainings.Update(editTrainingEntity);
            await _databaseContext.SaveChangesAsync();

            return result.Entity;
        }
    }
}
