using System.Collections.Generic;
using WebService.Models;

namespace WebService.Infrastructure
{
    public static class UserRepository
    {
        public static List<AppUser> Users;

        static UserRepository()
        {
            Users = new List<AppUser>();
        }
    }
}
