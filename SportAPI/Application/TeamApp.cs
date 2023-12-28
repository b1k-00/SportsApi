using SportAPI.Application;
using SportAPI.Application.Interface;
using SportAPI.Application.Persistence;
using SportAPI.Domain;

namespace SportAPI.Application;

public class TeamApp : AppBase<Team>, ITeamApp, IApp<Team>
{
        public IGenericRepository<Team> _teamRepo { get; set; }

        public TeamApp(IGenericRepository<Team> teamRepo) : base(teamRepo)
        {
            _teamRepo = teamRepo;
        }   
}
