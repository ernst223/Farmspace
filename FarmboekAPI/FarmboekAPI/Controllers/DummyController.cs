using FarmboekAPI.Models;
using FarmboekAPI.Repository;
using FarmboekAPI.TransUnionRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.Controllers
{
    [Route("dummy")]
    public class DummyController: Controller
    {
        private DummyRepository dummyRepository;
        private UserManager<User> _userMgr;

        public DummyController(UserManager<User> userMgr,FarmboekContext T)
        {
            _userMgr = userMgr;
            dummyRepository = new DummyRepository(T);
        }

        [HttpGet("testdatabase")]
        public IActionResult TestDatabase()
        {
            return Ok(dummyRepository.getAllUsers());
        }

        [HttpGet]
        public IActionResult DummyMethod()
        {
            return Ok("Whoop Whoop the dummy are live Yoh!");
        }

        [Authorize]
        [HttpGet("auth")]
        public IActionResult TestSecurity()
        {
            return Ok();
        }

        [HttpGet("transunion/helloworld")]
        public IActionResult TestTransUnion()
        {
            return Ok(new TransUnionService().DummyTransUnionRequestHelloWorld());
        }

        [HttpGet("transunion/trans37")]
        public IActionResult TestTransUnion37()

        {
            return Ok(new TransUnionService().Transaction37Commercial());
        }


        [HttpGet("syncusers")]
        public async Task<IActionResult> SyncUsers()
        {
            string tempPassword = "";
            //var users = dummyRepository.getAllUsers();
            var users = dummyRepository.getAllASPUsers();
            User theUser;
            foreach (var aspUser in users)
            {
                // If using the .getAllUsers() use this method
                // var CreatedUser = await _userMgr.FindByNameAsync(aspUser.UserName);

                //if using the .getAllASPUsers use this method
                var CreatedUser = aspUser;
                if (CreatedUser != null)
                {
                    if (CreatedUser.SodiumHash != null)
                    {
                        if (CreatedUser.SodiumHash.Length < 60)
                        {
                            tempPassword = CreatedUser.SodiumHash;
                            theUser = new User()
                            {
                                FirstName = CreatedUser.FirstName,
                                LastName = CreatedUser.LastName,
                                role = "normal",
                                cellNumber = CreatedUser.cellNumber,
                                IdNumber = CreatedUser.IdNumber,
                                Email = CreatedUser.Email,
                                UserName = CreatedUser.UserName,
                                Country = CreatedUser.Country
                            };
                            var hash = Sodium.PasswordHash.ScryptHashString(tempPassword);
                            hash = hash.Substring(0, hash.Length - 1);
                            theUser.SodiumHash = hash;
                            // First Deleting the User
                            var deleteResult = await _userMgr.DeleteAsync(CreatedUser);
                            // Then Creating the User
                            var result = await _userMgr.CreateAsync(theUser, tempPassword);
                        }
                    }
                }
            }
            return Ok();
        }
    }
}
