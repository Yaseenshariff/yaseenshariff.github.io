using SpanishFootballLeague.Models;
using System.Collections.Generic;

namespace SpanishFootballLeague.Interfaces
{
    public interface ITeamsRepository
    {
        List<TeamsDto> GetAllTeams();

        TeamHistoryDto GetTeamInfoByTeamId(int teamId);
    }
}
