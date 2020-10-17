using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmboekAPI.DTO;
using FarmboekAPI.Models;
using Microsoft.EntityFrameworkCore;
using PostmarkDotNet;

namespace FarmboekAPI.Repository
{
    public class CommunicationRepository
    {
        private FarmboekContext dc;
        public CommunicationRepository(FarmboekContext context)
        {
            dc = context;
        }

        public bool resetPassword(string username, string resetToken)
        {
            try
            {
                SendResetPasswordEmail(username, resetToken);
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }
        public async Task SendResetPasswordEmail(string username, string resetToken)
        {
            var message = new TemplatedPostmarkMessage
            {
                To = username,
                From = "info@farmboek.com",
                TemplateId = 15914723,
                TemplateModel = new Dictionary<string, object>
                {
                    { "username", username },
                 //   { "action_url",  "http://farmboek.dankospark.co.za/resetpassword/"+ username + "/" + resetToken}
                    { "action_url", "http://localhost:4200/resetpassword/"+ username + "/" + resetToken.Replace('/', '_')}
                }
            };

            var client = new PostmarkClient("20222232-ba77-4976-b1c5-921816baa7e2");
            var sendResult = await client.SendMessageAsync(message);

            if (sendResult.Status == PostmarkStatus.Success)
            {
                Console.WriteLine(sendResult.Status);
            }
            else
            {
                Console.WriteLine(sendResult.Status);
            }
        }
        public Languages getLanguageById(int id)
        {
            var temp = dc.Languages.Where(o => o.Id == id).FirstOrDefault();
            return temp;
        }
        public void addUserLanguages(List<UserLanguages> T)
        {
            foreach(var entity in T)
            {
                dc.UserLanguages.Add(entity);
            }
            dc.SaveChanges();
        }
        public bool couldNotFindUser(string username)
        {
            try
            {
                SendCouldNotFindUser(username);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public async Task SendCouldNotFindUser(string username)
        {
            var message = new TemplatedPostmarkMessage
            {
                To = username,
                From = "info@farmboek.com",
                TemplateId = 15914912,
                TemplateModel = new Dictionary<string, object>
                {
                    { "username", username }
                }
            };

            var client = new PostmarkClient("20222232-ba77-4976-b1c5-921816baa7e2");
            var sendResult = await client.SendMessageAsync(message);

            if (sendResult.Status == PostmarkStatus.Success)
            {
                Console.WriteLine(sendResult.Status);
            }
            else
            {
                Console.WriteLine(sendResult.Status);
            }
        }
        public bool notifyEnquireRemedy(ProductBaseDto T, string email, string name, string lastname, string idnumber, string cell)
        {
            try
            {
                SendNotifyEnquireRemedy(T, email);
                SendNotifyAdmin("Remedy", T.Name, name, lastname, idnumber, cell, email, dc.Brand.Where(o => o.BrandId == T.BrandId).First().Name, "http://farmboek.dankospark.co.za/details/brand/" + Convert.ToString(T.BrandId));
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }
        public async Task SendNotifyEnquireRemedy(ProductBaseDto T, string email)
        {
            var message = new TemplatedPostmarkMessage
            {
                To = email,
                From = "info@farmboek.com",
                TemplateId = 15937570,
                TemplateModel = new Dictionary<string, object>
                {
                    { "username", email },
                    { "remedyname", T.Name },
                    { "brand" , dc.Brand.Where(o => o.BrandId == T.BrandId).First().Name },
                    { "registration", T.Registration },
                    { "formulation", T.Formulation },
                    { "concentration", T.Concentration },
                    { "active", dc.ProductActiveIngredient.Include(o => o.ActiveIngredient).Where(o => o.ProductBaseId == T.ProductBaseId).First().ActiveIngredient.Name },
                    { "enquiredURL", "http://farmboek.dankospark.co.za/details/brand/" + T.BrandId }
                }
            };

            var client = new PostmarkClient("20222232-ba77-4976-b1c5-921816baa7e2");
            var sendResult = await client.SendMessageAsync(message);

            if (sendResult.Status == PostmarkStatus.Success)
            {
                Console.WriteLine(sendResult.Status);
            }
            else
            {
                Console.WriteLine(sendResult.Status);
            }
        }
        public bool notifyEnquireProblemAndService(string email, string brand, string entry, int id, string name, string lastname, string idnumber, string cell)
        {
            try
            {
                SendNotifyEnquireProblemAndService(email, brand, entry, id);
                SendNotifyAdmin("Product", entry, name, lastname, idnumber, cell, email, brand, "http://farmboek.dankospark.co.za/details/brand/" + Convert.ToString(id));
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }
        public async Task SendNotifyEnquireProblemAndService(string email, string brand, string entry, int id)
        {
            var message = new TemplatedPostmarkMessage
            {
                To = email,
                From = "info@farmboek.com",
                TemplateId = 15925178,
                TemplateModel = new Dictionary<string, object>
                {
                    { "name", email },
                    { "entryName", entry },
                    { "brandName" , brand },
                    { "enquiredURL", "http://farmboek.dankospark.co.za/details/brand/" + id }
                }
            };

            var client = new PostmarkClient("20222232-ba77-4976-b1c5-921816baa7e2");
            var sendResult = await client.SendMessageAsync(message);

            if (sendResult.Status == PostmarkStatus.Success)
            {
                Console.WriteLine(sendResult.Status);
            }
            else
            {
                Console.WriteLine(sendResult.Status);
            }
        }
        public async Task SendNotifyAdmin(string type, string productorremedy, string name, string lastname, string idnumber, string cell, string email, string brand, string action_url)
        {
            var message = new TemplatedPostmarkMessage
            {
                To = "info@farmboek.com",
                From = "info@farmboek.com",
                TemplateId = 16196502,
                TemplateModel = new Dictionary<string, object>
                {
                    { "name", name },
                    { "lastname", lastname },
                    { "type", type },
                    { "productorremedy", productorremedy },
                    { "idnumber", idnumber },
                    { "brand", brand },
                    { "cell", cell },
                    { "email", email },
                    { "action_url", action_url }
                }
            };

            var client = new PostmarkClient("20222232-ba77-4976-b1c5-921816baa7e2");
            var sendResult = await client.SendMessageAsync(message);

            if (sendResult.Status == PostmarkStatus.Success)
            {
                Console.WriteLine(sendResult.Status);
            }
            else
            {
                Console.WriteLine(sendResult.Status);
            }
        }
    }
}
