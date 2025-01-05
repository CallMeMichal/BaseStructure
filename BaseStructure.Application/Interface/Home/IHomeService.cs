using BaseStructure.Domain.DatabaseModels;

namespace BaseStructure.Application.Interface.Home
{
    public interface IHomeService
    {
        Task<User> GetUsers();
    }
}
