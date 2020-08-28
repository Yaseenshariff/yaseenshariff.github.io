using AutoMapper;
using SpanishFootballLeague.Interfaces;
using SpanishFootballLeague.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpanishFootballLeague.Concrete
{
    public class TeamsRepository : ITeamsRepository
    {
        public List<TeamsDto> GetAllTeams()
        {
            using(var db = new Football_PremierLeagueEntities())
            {
                List<PremierLeague_Teams> league_Teams = db.PremierLeague_Teams.OrderBy(u => u.TeamName).ToList();
                //foreach(var league_Team in league_Teams)
                //{
                //    if(league_Team != null)
                //    {
                //        string base64 = Convert.ToBase64String(league_Team.TeamImage);
                //        league_Team.TeamImage = "data:Image/png;base64," + base64;
                //    }
                //}
                return Mapper.Map<List<TeamsDto>>(league_Teams);
            }
        }

        public TeamHistoryDto GetTeamInfoByTeamId(int teamId)
        {
            using(var db = new Football_PremierLeagueEntities())
            {
                PremierLeague_History teams = db.PremierLeague_History.FirstOrDefault(t => t.TeamId == teamId);
                return Mapper.Map<TeamHistoryDto>(teams);
            }
        }
    }
}