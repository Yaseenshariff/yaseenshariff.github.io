using AutoMapper;
using SpanishFootballLeague.Models;

namespace SpanishFootballLeague.Configurations
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserDto>();
            //.ForMember(d => d.Disable, opt => opt.MapFrom(s => s.Disable))
            //.ForMember(d => d.Email, opt => opt.MapFrom(s => s.Email))
            //.ForMember(d => d.FirstName, opt => opt.MapFrom(s => s.FirstName))
            //.ForMember
            CreateMap<PremierLeague_MatchFixtures, MatchesDto>();
            CreateMap<PremierLeague_Teams, TeamsDto>();
            CreateMap<PremierLeague_History, TeamHistoryDto>();
        }
    }
}