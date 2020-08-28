using SpanishFootballLeague.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanishFootballLeague.Interfaces
{
    public interface IUserRepository
    {
        UserDto isValidUser(LoginViewModel loginViewModel);
    }
}
