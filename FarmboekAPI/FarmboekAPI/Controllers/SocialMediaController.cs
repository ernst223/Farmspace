using FarmboekAPI.DTO;
using FarmboekAPI.Models;
using FarmboekAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FarmboekAPI.Controllers
{
    [Route("socialmedia")]
    public class SocialMediaController : Controller
    {
        private SocialMediaRepository socialMediaRepository;
        private IHostingEnvironment _env;
        public SocialMediaController(FarmboekContext T, IHostingEnvironment env)
        {
            socialMediaRepository = new SocialMediaRepository(T);
            _env = env;
        }
        [HttpGet("GetLangauges")]
        public async Task<IActionResult> getAllLanguages()
        {
            return Ok(socialMediaRepository.GetLanguages());
        }
        [HttpGet("addLanguages")]
        public IActionResult addLanguages()
        {
            socialMediaRepository.PopulateLanguages();
            return Ok("Success");
        }
        [HttpPost("postmedia")]
        public IActionResult postMedia([FromBody] SocialMediaDto T)
        {
            var result = socialMediaRepository.postSocialMedia(T, _env);
            if (result == "Success")
            {
                return Ok(new { result });
            }
            else
            {
                return BadRequest(result);
            }
        }

        [Authorize]
        [HttpGet("removeImage/{id}")]
        public IActionResult RemoveImage(int id)
        {
            return Ok(socialMediaRepository.RemoveImage(id));
        }

        [Authorize]
        [HttpPost("editpost/{id}")]
        public IActionResult editPost([FromBody] EditPostDto T,int id)
        {
            return Ok(socialMediaRepository.EditPost(T, id, _env));
        }

        [Authorize]
        [HttpPost("postEntryPDF")]
        public IActionResult postEntryPDF([FromBody] pdfDTO T)
        {
            var result = socialMediaRepository.postEntryPDF(T, _env);
            if (result == "Success")
            {
                return Ok(new { result });
            }
            else
            {
                return BadRequest(result);
            }
        }

        [Authorize]
        [HttpPost("postProductBasePDFfile")]
        public IActionResult postProductBasePDF([FromBody] pdfDTO T)
        {
            var result = socialMediaRepository.postProductBasePDF(T, _env);
            if (result == "Success")
            {
                return Ok(new { result });
            }
            else
            {
                return BadRequest(result);
            }
        }

        [Authorize]
        [HttpGet("deleteEntryPdf/{id}")]
        public IActionResult deleteEntryPDF(int id)
        {
            return Ok(socialMediaRepository.deleteEntryPDF(id, _env));
        }


        [Authorize]
        [HttpGet("deleteProductBasePdf/{id}")]
        public IActionResult deleteProductBasePDF(int id)
        {
            return Ok(socialMediaRepository.deleteProductBasePDF(id, _env));
        }

        [HttpPost("nextbatch/{lastId}/{userId}/{languageId}")]
        public IActionResult getNextBatch([FromBody] PreviousBatch T,int lastId, string userId, int languageId)
        {
            return new OkObjectResult(socialMediaRepository.GetNextMediaBatch(lastId, userId, languageId, T));
        }
        [HttpGet("search/{term}/{userid}")]
        public async Task<IActionResult> searchMedia(string term, string userid)
        {
            return new OkObjectResult(socialMediaRepository.searchTerm(term, userid));
        }
        [HttpGet("searchProductMedia/{term}/{userid}")]
        public async Task<IActionResult> searchProductMedia(string term, string userid)
        {
            return new OkObjectResult(socialMediaRepository.searchMediaProducts(term, userid));
        }
        [HttpGet("videomedia/{userid}")]
        public async Task<IActionResult> getVideoMedia(string userid)
        {
            return new OkObjectResult(socialMediaRepository.MediaWithVideos(userid));
        }
        [HttpGet("articlemedia/{userid}")]
        public async Task<IActionResult> getArticleMedia(string userid)
        {
            return new OkObjectResult(socialMediaRepository.MediaArticles(userid));
        }
        [Authorize]
        [HttpGet("deletepost/{id}")]
        public IActionResult deletePost(int id)
        {
            return new OkObjectResult(socialMediaRepository.deleteMedia(id));
        }

        [Authorize]
        [HttpGet("addcomment/{postid}/{userid}/{comment}")]
        public IActionResult addComment(int postid, string userid, string comment)
        {
            return new OkObjectResult(socialMediaRepository.AddComment(userid, postid, comment));
        }
       
        [HttpGet("getall")]
        public async Task<IActionResult> getAllPosts()
        {
            return new OkObjectResult(socialMediaRepository.getAllMedia());
        }

        [HttpGet("getallcatagories")]
        public IActionResult getAllCatagories()
        {
            return new OkObjectResult(socialMediaRepository.getAllCatagories());
        }

        [Authorize]
        [HttpGet("like/{userid}/{postid}")]
        public IActionResult LikePost(string userid, int postid)
        {
            var result = socialMediaRepository.LikePost(userid, postid);
            if (result)
            {
                return new OkObjectResult(result);
            }
            else
            {
                return new BadRequestObjectResult(result);
            }
        }

        [Authorize]
        [HttpGet("unlike/{userid}/{postid}")]
        public IActionResult UnLikePost(string userid, int postid)
        {
            var result = socialMediaRepository.UnLikePost(userid, postid);
            if (result)
            {
                return new OkObjectResult(result);
            }
            else
            {
                return new BadRequestObjectResult(result);
            }
        }

        [HttpGet("byid/{id}/{userid}")]
        public IActionResult getMediaById(int id, string userid)
        {
            return new OkObjectResult(socialMediaRepository.getMediaById(id, userid));
        }

        [HttpGet("byRemedy/{productbaseid}/{userid}")]
        public async Task<IActionResult> getMediaByRemedy(int productbaseid, string userid)
        {
            return Ok(socialMediaRepository.getMediaByRemedyId(productbaseid, userid));
        }

        [HttpGet("byProduct/{entryid}/{userid}")]
        public async Task<IActionResult> getMediaByEntry(int entryid, string userid)
        {
            return Ok(socialMediaRepository.getMediaByProductId(entryid, userid));
        }

        [HttpGet("byCatagory/{catagoryid}/{userid}")]
        public async Task<IActionResult> getMediaByCatagory(int catagoryid, string userid)
        {
            return Ok(socialMediaRepository.getMediaByCatagory(catagoryid, userid));
        }

        [HttpGet("byidwithcomments/{id}/{userid}")]
        public IActionResult getMediaByIdWithComments(int id, string userid)
        {
            return new OkObjectResult(socialMediaRepository.getMediaByIdAllComments(id, userid));
        }

        [HttpGet("share/{id}")]
        [Produces("text/html")]
        public ActionResult<string> GetSharedPost(int id)
        {
            string _result = socialMediaRepository.getSharePostResponseString(id);
            return _result;
        }
    }
}
