using SpanishFootballLeague.Models;
using System.Collections.Generic;

namespace SpanishFootballLeague.Interfaces
{
    public interface IMatchesRepository
    {
        List<MatchesDto> GetAllMatches();
    }
}
