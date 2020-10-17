using FarmboekAPI.DTO;
using FarmboekAPI.Models;
using FarmboekAPI.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ScottBrady91.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FarmboekAPI.Controllers
{
    [Route("api/auth")]
    public class TokenController: Controller
    {
        private UserManager<User> _userMgr;
        private IPasswordHasher<User> _hasher;
        private IConfiguration _config;
        private CommunicationRepository communicationRepository;

        public TokenController(UserManager<User> userMgr, IPasswordHasher<User> hasher, IConfiguration config, FarmboekContext T)
        {
            _userMgr = userMgr;
            _hasher = hasher;
            _config = config;
            communicationRepository = new CommunicationRepository(T);
        }

        
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserDto newUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var user = await _userMgr.FindByNameAsync(newUser.userName);
            if (user != null)
            {
                return BadRequest("");
            }
            
            List<Languages> languageList = new List<Languages>();
            foreach(var entity in newUser.Languages)
            {
                var temp = communicationRepository.getLanguageById(entity);
                languageList.Add(temp);
            }
            User theUser = new User()
            {
                FirstName = newUser.FirstName,
                LastName = newUser.LastName,
                role = newUser.role,
                cellNumber = newUser.cellNumber,
                IdNumber = newUser.IdNumber,
                Email = newUser.email,
                UserName = newUser.userName,
                Country = newUser.Country,
            };
            var hash = Sodium.PasswordHash.ScryptHashString(newUser.Password);
            var result = await _userMgr.CreateAsync(theUser, newUser.Password);

            if (result.Succeeded)
            {
                var CreatedUser = await _userMgr.FindByNameAsync(theUser.UserName);
                // Adding language link
                List<UserLanguages> tempUserLang = new List<UserLanguages>();
                foreach(var entity in languageList)
                {
                    tempUserLang.Add(new UserLanguages() { LanguageId = entity.Id, UserId = CreatedUser.Id });
                }
                communicationRepository.addUserLanguages(tempUserLang);

                // adding claims
                await _userMgr.AddClaimAsync(CreatedUser, new System.Security.Claims.Claim(ClaimTypes.Role, newUser.role));
                hash = hash.Substring(0, hash.Length - 1);
                CreatedUser.SodiumHash = hash;
                await _userMgr.UpdateAsync(CreatedUser);
                //Returning the Token
                var returnResult = await CreateToken(new Credentials() { UserName = CreatedUser.UserName, Password = newUser.Password });
                return returnResult;
            }
            else
            {
                return BadRequest(result.Errors);
            }

        }

        [HttpGet("forgotpassword/{username}")]
        public async Task<IActionResult> Forgotpassword(string username)
        {
            try
            {
                var theUser = await _userMgr.FindByNameAsync(username);
                if(theUser != null)
                {
                    string resetToken = await _userMgr.GeneratePasswordResetTokenAsync(theUser);
                    communicationRepository.resetPassword(username, resetToken);
                }
                else
                {
                    communicationRepository.couldNotFindUser(username);
                }
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("resetPassword")]
        public async Task<IActionResult> resetPassword([FromBody] resetPasswordDto T)
        {
            try
            {
                var theUser = await _userMgr.FindByNameAsync(T.username);
                var hash = Sodium.PasswordHash.ScryptHashString(T.password);
                hash = hash.Substring(0, hash.Length - 1);
                theUser.SodiumHash = hash;
                await _userMgr.UpdateAsync(theUser);

                IdentityResult passwordChangeResult = await _userMgr.ResetPasswordAsync(theUser, T.token.Replace('_','/'), T.password);
                if (passwordChangeResult.Succeeded)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest("Could not change password");
                }
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("token")]
        public async Task<IActionResult> CreateToken([FromBody] Credentials model)
        {
            try
            {
                var user = await _userMgr.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    if (_hasher.VerifyHashedPassword(user, user.PasswordHash, model.Password) == PasswordVerificationResult.Success)
                    {
                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("sdfgsdgrre;n34l5n;sdfgsdfg;dngk34l;wert;wert"));
                        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                        var claims = new[]
                        {
                            new Claim("role", user.role)
                        };
                        var token = new JwtSecurityToken(
                           //Ernst
                           //issuer: "http://localhost:52757",
                           //audience: "http://localhost:52757",
                           claims: claims,
                           //Staging
                           issuer: "http://farmboek.dankospark.co.za/api/",
                           audience: "http://farmboek.dankospark.co.za/api/",

                           expires: DateTime.Now.AddHours(10),
                           signingCredentials: creds
                           );

                        return Ok(new UserDtoWithToken()
                        {
                            token = new JwtSecurityTokenHandler().WriteToken(token),
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            role = user.role,
                            id = user.Id
                        });
                    }
                }
            }
            catch (Exception e)
            {
                return Ok(false);
            }
            return Ok(false);
        }

        [HttpPost("notifyenquire/remedy/{email}")]
        public async Task<IActionResult> notifyEnquireForRemedy([FromBody] ProductBaseDto T, string email)
        {
            try
            {
                var user = await _userMgr.FindByNameAsync(email);
                return Ok(communicationRepository.notifyEnquireRemedy(T, email, user.FirstName, user.LastName, user.IdNumber, user.cellNumber));
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("notifyenquire/productandservice/{email}/{brand}/{entry}/{brandid}")]
        public async Task<IActionResult> notifyEnquireForProductAndService (string email, string brand, string entry, int brandid)
        {
            try
            {
                var user = await _userMgr.FindByNameAsync(email);
                return Ok(communicationRepository.notifyEnquireProblemAndService(email, brand, entry, brandid, user.FirstName, user.LastName, user.IdNumber, user.cellNumber));
            }catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
