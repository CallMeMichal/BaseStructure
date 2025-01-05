using BaseStructure.Domain.DatabaseModels;

namespace BaseStructure.Application.Interface.Home
{
    public interface IHomeRepository
    {
        Task<User> GetUsers();
    }
}
