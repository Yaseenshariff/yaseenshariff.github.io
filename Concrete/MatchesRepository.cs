using AutoMapper;
using SpanishFootballLeague.Interfaces;
using SpanishFootballLeague.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpanishFootballLeague.Concrete
{
    public class MatchesRepository : IMatchesRepository
    {
        public List<MatchesDto> GetAllMatches()
        {
            using(var db = new Football_PremierLeagueEntities())
            {
                List<PremierLeague_MatchFixtures> matches = db.PremierLeague_MatchFixtures.ToList();
                return Mapper.Map<List<MatchesDto>>(matches);
            }
        }
    }
}