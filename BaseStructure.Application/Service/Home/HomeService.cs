using BaseStructure.Application.Interface;
using BaseStructure.Domain.DatabaseModels;

namespace BaseStructure.Application.Service.Home
{
    public class HomeService
    {
        private readonly IHomeRepository _homeRepository;

        public HomeService(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }
        public async Task<User> GetUsers()
        {
            return await _homeRepository.GetUsers();
        }
    }
}
