using Course.App.DataModel;
using Course.App.DataModel.Dto;

namespace Course.App.WebApi.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UsersDto>> GetUser(string userId);
        Task<List<UsersDto>> GetAllUser();

        Task<UsersDto> CreateUser(Training data);
    }
}
