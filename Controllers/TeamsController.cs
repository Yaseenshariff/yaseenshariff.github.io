using SpanishFootballLeague.Interfaces;
using SpanishFootballLeague.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpanishFootballLeague.Controllers
{
    [Authorize]
    public class TeamsController : Controller
    {
        private ITeamsRepository _teamsRepository;
        public TeamsController(ITeamsRepository teamsRepository)
        {
            _teamsRepository = teamsRepository;
        }
        // GET: Teams
        public ActionResult Index()
        {
            List<TeamsDto> teams = _teamsRepository.GetAllTeams();
            return View(teams);
        }

        public ActionResult GetTeamInfoByTeamId(int teamId)
        {
            TeamHistoryDto teamHistoryInfo = _teamsRepository.GetTeamInfoByTeamId(teamId);
            if(teamHistoryInfo != null)
            {
                return View(teamHistoryInfo);
            }
            return View();
        }
    }
}