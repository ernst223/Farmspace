using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmboekAPI.Models;

namespace FarmboekAPI.Repository
{
    public class DummyRepository : IDummyRepository
    {
        private FarmboekContext dc;
        public DummyRepository(FarmboekContext context)
        {

            dc = context;
        }
        public List<UserProfile> getAllUsers()
        {
            var result = dc.UserProfile.ToList();
            return result;
        }

        public List<User> getAllASPUsers() {
             var users = dc.Users.ToList();
            return users;
        }
    }
}
