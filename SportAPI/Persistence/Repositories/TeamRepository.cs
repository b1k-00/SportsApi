using SportAPI.Application.Persistence;
using SportAPI.Domain;

namespace SportAPI.Persistence.Repositories
{
    public class TeamRepository : GenericRepository<Team>
    {
        private readonly SportsDbContext _dbContext;

        public TeamRepository(SportsDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}

