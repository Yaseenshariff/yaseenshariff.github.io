using AutoMapper;
using SpanishFootballLeague.Interfaces;
using SpanishFootballLeague.Models;
using System;
using System.Linq;

namespace SpanishFootballLeague.Concrete
{
    public class UserRepository : IUserRepository
    {
        public UserDto isValidUser(LoginViewModel loginViewModel)
        {
            using(var db = new Football_PremierLeagueEntities())
            {
                User user = db.Users.FirstOrDefault(u => u.UserName.Equals(loginViewModel.UserName, StringComparison.InvariantCultureIgnoreCase) &&
                                        u.Password.Equals(loginViewModel.Password));
            return Mapper.Map<UserDto>(user);
            }
        }
    }
}