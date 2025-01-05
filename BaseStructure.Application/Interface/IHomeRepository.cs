using BaseStructure.Domain.DatabaseModels;

namespace BaseStructure.Application.Interface
{
    public interface IHomeRepository
    {
        Task<User> GetUsers();
    }
}
