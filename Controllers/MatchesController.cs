using SpanishFootballLeague.Interfaces;
using SpanishFootballLeague.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpanishFootballLeague.Controllers
{
    //[Authorize]
    public class MatchesController : Controller
    {
        private IMatchesRepository _matchesRepository;
        public MatchesController(IMatchesRepository matchesRepository)
        {
            _matchesRepository = matchesRepository;
        }
        // GET: Matches
        public ActionResult Index()
        {
            List<MatchesDto> matches = _matchesRepository.GetAllMatches();
            return View(matches);
        }
    }
}