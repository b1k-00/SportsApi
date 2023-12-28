using API.Controllers;
using SportAPI.Application.Interface;
using SportAPI.Domain;

namespace SportAPI.Controllers
{
    public class TeamController : BaseApiAppController<Team>
    {
        public ITeamApp _teamApp = null;

        public TeamController(ITeamApp teamApp) : base((IApp<Team>)teamApp)
        {
            _teamApp = teamApp;
        }
    }
}
