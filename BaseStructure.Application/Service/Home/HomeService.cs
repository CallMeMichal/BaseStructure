using BaseStructure.Application.Interface.Home;
using BaseStructure.Domain.DatabaseModels;

namespace BaseStructure.Application.Service.Home
{
    public class HomeService : IHomeService
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
