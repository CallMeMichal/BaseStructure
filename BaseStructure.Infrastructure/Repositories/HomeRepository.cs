using BaseStructure.Application.Interface.Home;
using BaseStructure.Domain.DatabaseModels;
using BaseStructure.Infrastructure.DatabaseModels.Context;
using Microsoft.EntityFrameworkCore;

namespace BaseStructure.Infrastructure.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        private readonly AppDbContext _appDbContext;

        public HomeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<User> GetUsers()
        {
            try
            {
                int userId = 1;
                var user = await _appDbContext.Users.Where(u => u.Id == userId).FirstOrDefaultAsync();
                return user;
            }
            catch (Exception ex)
            {
                // Loguj wyjątek dla debugowania
                Console.WriteLine(ex.Message);
                throw;
            }

        }
    }
}
