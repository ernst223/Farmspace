using FarmboekAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.Repository
{
    interface IDummyRepository
    {
        List<UserProfile> getAllUsers();
    }
}
