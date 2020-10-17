using FarmboekAPI.DTO;
using FarmboekAPI.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FarmboekAPI.Repository
{
    public class SocialMediaRepository
    {
        private FarmboekContext dc;
        private Random rng = new Random();
        public SocialMediaRepository(FarmboekContext context)
        {
            dc = context;
        }

        public string getSharePostResponseString(int id)
        {
            try
            {
                var MediaPost = dc.Media.Where(a => a.MediaId == id).First();
                var result = new StringBuilder();
                result.Append("<!doctype html><html lang='en'><head><title>");
                result.Append(MediaPost.Title);
                result.Append("</title><meta charset='utf - 8'>");
                result.Append("<meta property='og:title' content='");
                result.Append(MediaPost.Title);
                result.Append("'><meta property='og:description' content='Farmspace media posts'>");
                result.Append("<meta property='og:image' content='");
                if (MediaPost.ImageUrl != null)
                {
                    result.Append("https://farmspace.co.za/api/" + MediaPost.ImageUrl);
                }
                else
                {
                    result.Append("https://farmspace.co.za/assets/images/avatars/farmspaceLogo.png");
                }
                //result.Append("'><meta property='og:url' content='");
                //result.Append("https://farmspace.co.za/home/media/" + Convert.ToString(id));

                result.Append("'><meta property='og:image:width' content='800'><meta property='og:image:height' content='800'></head><body><script>window.setTimeout(function(){window.location.href = '");
                result.Append("https://farmspace.co.za/home/media/" + Convert.ToString(id));
                result.Append("';}, 800);</script></body></html>");
                return result.ToString();
            }catch(Exception e)
            {
                return "Page could not be found. " + e.Message;
            }
        }
        public string postEntryPDF(pdfDTO T, IHostingEnvironment _env)
        {
            try
            {
                var webRoot = _env.WebRootPath;
                var PathWithFolderName = System.IO.Path.Combine(webRoot, "EntryPDF");
                if (!Directory.Exists(PathWithFolderName))
                {
                    // create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(PathWithFolderName);
                }

                string[] Base64Split = T.thePDF.Split(',');
                string Base64String = Base64Split[1];

                byte[] bytes = Convert.FromBase64String(Base64String);

                //System.Drawing.Image image;
                //using (MemoryStream ms = new MemoryStream(bytes))
                //{
                //    image = System.Drawing.Image.FromStream(ms);
                //}

                //var temp = new Bitmap(image);
                var myTempPath = PathWithFolderName + @"\" + T.thePDFName;

                //temp.Save(myTempPath);
                File.WriteAllBytes(myTempPath, bytes);
                return "Success";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
        public string postProductBasePDF(pdfDTO T, IHostingEnvironment _env)
        {
            try
            {
                var webRoot = _env.WebRootPath;
                var PathWithFolderName = System.IO.Path.Combine(webRoot, "ProductBasePDF");
                if (!Directory.Exists(PathWithFolderName))
                {
                    // create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(PathWithFolderName);
                }

                string[] Base64Split = T.thePDF.Split(',');
                string Base64String = Base64Split[1];

                byte[] bytes = Convert.FromBase64String(Base64String);

                //System.Drawing.Image image;
                //using (MemoryStream ms = new MemoryStream(bytes))
                //{
                //    image = System.Drawing.Image.FromStream(ms);
                //}

                //var temp = new Bitmap(image);
                var myTempPath = PathWithFolderName + @"\" + T.thePDFName;
                //temp.Save(myTempPath);
                File.WriteAllBytes(myTempPath, bytes);
                return "Success";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public bool deleteEntryPDF(int id, IHostingEnvironment _env)
        {
            var webRoot = _env.WebRootPath;
            var PathWithFolderName = System.IO.Path.Combine(webRoot, "EntryPDF");
            string filename = Convert.ToString(id) + ".pdf";
            var FullPath = PathWithFolderName + "/" + filename;
            if (System.IO.File.Exists(FullPath))
            {
                System.IO.File.Delete(FullPath);
                return true;
            }
            return true;
        }
        public bool deleteProductBasePDF(int id, IHostingEnvironment _env)
        {
            var webRoot = _env.WebRootPath;
            var PathWithFolderName = System.IO.Path.Combine(webRoot, "ProductBasePDF");
            string filename = Convert.ToString(id) + ".pdf";
            var FullPath = PathWithFolderName + "/" + filename;
            if (System.IO.File.Exists(FullPath))
            {
                System.IO.File.Delete(FullPath);
                return true;
            }
            return true;
        }
        public bool RemoveImage(int id)
        {
            try
            {
                var temp = dc.Media.Where(O => O.MediaId == id).First();
                temp.ImageUrl = "";
                dc.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EditPost(EditPostDto T, int mediaId, IHostingEnvironment _env)
        {
            try
            {
                if(T.NewImage == "" || T.NewImage == null)
                {
                    var temp = dc.Media.Where(o => o.MediaId == mediaId).First();
                    temp.Title = T.Title;
                    temp.Description = T.Description;
                    dc.SaveChanges();
                    return true;
                }
                else
                {
                    var webRoot = _env.WebRootPath;
                    var PathWithFolderName = System.IO.Path.Combine(webRoot, "SocialMediaListingFiles");
                    string[] Base64Split = T.NewImage.Split(',');
                    string Base64String = Base64Split[1];

                    byte[] bytes = Convert.FromBase64String(Base64String);

                    System.Drawing.Image image;
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        image = System.Drawing.Image.FromStream(ms);
                    }

                    var temp = new Bitmap(image);
                    var myTempPath = PathWithFolderName + @"\" + T.FileName;
                    temp.Save(myTempPath);

                    var tempMedia = dc.Media.Where(o => o.MediaId == mediaId).First();
                    tempMedia.Title = T.Title;
                    tempMedia.Description = T.Description;
                    tempMedia.ImageUrl = "SocialMediaListingFiles/" + T.FileName;
                    dc.SaveChanges();
                    return true;
                }
            }catch(Exception e)
            {
                return false;
            }
        }
        public Languages getLanguageById(int id)
        {
            return dc.Languages.Where(a => a.Id == id).FirstOrDefault();
        }
        public void PopulateLanguages()
        {
            List<string> languagesToAdd = new List<string>();
            languagesToAdd.Add("English");
            languagesToAdd.Add("Afrikaans");
            languagesToAdd.Add("Zulu");
            languagesToAdd.Add("Xhosa");
            languagesToAdd.Add("Southern Sotho");
            languagesToAdd.Add("Tswana");
            languagesToAdd.Add("Venda");
            languagesToAdd.Add("Northern Sotho");
            languagesToAdd.Add("Tsonga");
            languagesToAdd.Add("Swati");
            languagesToAdd.Add("Ndebele");

            foreach(var entity in languagesToAdd)
            {
                var temp = dc.Languages.Where(a => a.Language == entity).FirstOrDefault();
                if(temp == null)
                {
                    dc.Languages.Add(new Languages() { Language = entity });
                }
            }
            dc.SaveChanges();
        }
        public string postSocialMedia(SocialMediaDto T, IHostingEnvironment _env)
        {
            try
            {
                //If no image is set with the post
                if (T.TheImageName == "" || T.TheImageName == null)
                {
                    var mediaToAdd = new Media()
                    {
                        Title = T.Title,
                        Description = T.Description,
                        BrandId = T.Brandid,
                        MediaDate = T.MediaDate,
                        WebLink = T.WebLink,
                        YoutubeLink = T.YoutubeLink
                    };
                    dc.Media.Add(mediaToAdd);
                    dc.SaveChanges();
                    var lastMedia = dc.Media.OrderByDescending(a => a.MediaId).FirstOrDefault();
                    foreach (var entity in T.Languages)
                    {
                        dc.MediaLanguages.Add(new MediaLanguages() { LanguageId = entity, MediaId = lastMedia.MediaId });
                    }
                    dc.SaveChanges();
                    var tempMedia = dc.Media.ToList().LastOrDefault();
                    LinkMediaCatagories(T.mediaCatagories, tempMedia.MediaId);
                    LinkMediaProducts(T.mediaProducts, tempMedia.MediaId);
                    LinkMediaRemedies(T.mediaRemedies, tempMedia.MediaId);
                }
                else
                {
                    //Add the base64 image to a folder
                    var webRoot = _env.WebRootPath;
                    var PathWithFolderName = System.IO.Path.Combine(webRoot, "SocialMediaListingFiles");

                    if (!Directory.Exists(PathWithFolderName))
                    {
                    // create the directory.
                            DirectoryInfo di = Directory.CreateDirectory(PathWithFolderName);
                    }
                    
                        string[] Base64Split = T.TheImage.Split(',');
                        string Base64String = Base64Split[1];

                        byte[] bytes = Convert.FromBase64String(Base64String);

                        System.Drawing.Image image;
                        using (MemoryStream ms = new MemoryStream(bytes))
                        {
                            image = System.Drawing.Image.FromStream(ms);
                        }

                        var temp = new Bitmap(image);
                        var myTempPath = PathWithFolderName + @"\" + T.TheImageName;
                        temp.Save(myTempPath);

                        // Adding the Media Entry

                    var mediaToAdd = new Media()
                    {
                        Title = T.Title,
                        Description = T.Description,
                        BrandId = T.Brandid,
                        MediaDate = T.MediaDate,
                        WebLink = T.WebLink,
                        YoutubeLink = T.YoutubeLink,
                        ImageUrl = "SocialMediaListingFiles/" + T.TheImageName,
                        HideImage = T.hideImage
                    };

                    dc.Media.Add(mediaToAdd);
                    dc.SaveChanges();
                    var lastMedia = dc.Media.OrderByDescending(a => a.MediaId).FirstOrDefault();
                    foreach (var entity in T.Languages)
                    {
                        dc.MediaLanguages.Add(new MediaLanguages() { LanguageId = entity, MediaId = lastMedia.MediaId });
                    }
                    dc.SaveChanges();

                    var tempMedia = dc.Media.ToList().LastOrDefault();
                    LinkMediaCatagories(T.mediaCatagories, tempMedia.MediaId);
                    LinkMediaProducts(T.mediaProducts, tempMedia.MediaId);
                    LinkMediaRemedies(T.mediaRemedies, tempMedia.MediaId);
                }
                return "Success";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public List<Languages> GetLanguages()
        {
            return dc.Languages.ToList();
        }
        public void LinkMediaCatagories(List<MediaCatagoriesDto> T, int mediaId)
        {
            try
            {
                foreach(var entity in T)
                {
                    dc.MediaCatagories.Add(new MediaCatagories()
                    {
                        MediaId = mediaId,
                        CatagoryId = entity.CatagoryId
                    });
                }
                dc.SaveChanges();

            }catch(Exception e)
            {
                Console.WriteLine("ERROR==>  " + e.Message);
            }
        }

        
        public void LinkMediaProducts(List<MediaProductLinkDto> T, int mediaId)
        {
            try
            {
                foreach(var entity in T)
                {
                    dc.MediaProductLinks.Add(new MediaProductLink()
                    {
                        MediaId = mediaId,
                        EntryId = entity.EntryId
                    });
                }
                dc.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR==>  " + e.Message);
            }
        }

        public void LinkMediaRemedies(List<MediaRemediesLinkDto> T, int mediaId)
        {
            try
            {
                foreach (var entity in T)
                {
                    dc.MediaRemediesLinks.Add(new MediaRemediesLink()
                    {
                        MediaId = mediaId,
                        ProductBaseId = entity.ProductBaseId
                    });
                }
                dc.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR==>  " + e.Message);
            }
        }

        public bool LikePost(string userId, int postId)
        {
            try
            {
                dc.Likes.Add(new Likes()
                {
                    DateLiked = DateTime.Now,
                    MediaId = postId,
                    UserId = userId
                });
                dc.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UnLikePost(string userId, int postId)
        {
            try
            {
                var temp = dc.Likes.Where(o => o.UserId == userId && o.MediaId == postId).First();
                dc.Likes.Remove(temp);
                dc.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddComment(string userId, int postId, string comment)
        {
            try
            {
                dc.Comments.Add(new Comments()
                {
                    MediaId = postId,
                    UserId = userId,
                    Comment = comment,
                    CommentDate = DateTime.Now
                });
                dc.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<MediaDto> getMediaByRemedyId(int productbaseId, string userId)
        {
            var temp = dc.MediaRemediesLinks.Where(o => o.ProductBaseId == productbaseId).ToList();
            List<MediaDto> result = new List<MediaDto>();
            foreach(var entity in temp)
            {
                result.Add(getMediaById(entity.MediaId, userId));
            }
            return result;
        }
        public List<MediaDto> getMediaByProductId(int entryId, string userId)
        {
            var temp = dc.MediaProductLinks.Where(O => O.EntryId == entryId).ToList();
            List<MediaDto> Result = new List<MediaDto>();
            foreach(var entity in temp)
            {
                Result.Add(getMediaById(entity.MediaId, userId));
            }
            return Result;
        }
        public List<MediaDto> getMediaByCatagory(int catagoryId, string userId)
        {
            var temp = dc.MediaCatagories.Where(o => o.CatagoryId == catagoryId).ToList();
            List<MediaDto> result = new List<MediaDto>();
            foreach(var entity in temp)
            {
                result.Add(getMediaById(entity.MediaId, userId));
            }
            return result;
        }
        public MediaDto getMediaById(int id, string userId)
        {
            var temp = dc.Likes.Where(o => o.MediaId == id && o.UserId == userId).FirstOrDefault();
            var myMedia = dc.Media.Where(o => o.MediaId == id).FirstOrDefault();
            if (myMedia.HideImage == true)
            {
                myMedia.ImageUrl = null;
            }
            MediaDto result = new MediaDto();
            //Just get 2 Comments
            List<MediaCommentDto> resultComments = new List<MediaCommentDto>();
            var comments = dc.Comments.Where(o => o.MediaId == id).OrderByDescending(p => p.Id).ToList();
            int tempCommentCount = comments.Count();
            int tempShareCount = dc.Shares.Where(o => o.MediaId == id).ToList().Count();
            if (comments != null)
            {
                User tempUser;
                foreach(var entity in comments.Take(2))
                {
                    tempUser = dc.Users.Where(o => o.Id == entity.UserId).First();
                    resultComments.Add(new MediaCommentDto()
                    {
                        userId = entity.UserId,
                        CommentDate = entity.CommentDate,
                        CommentId = entity.Id,
                        theComment = entity.Comment,
                        userName = tempUser.FirstName + " " + tempUser.LastName
                    });
                }
            }
            if (temp == null)
            {
                
                result.Description = myMedia.Description;
                result.ImageUrl = myMedia.ImageUrl;
                result.IsActive = myMedia.IsActive;
                result.MediaDate = myMedia.MediaDate;
                result.MediaId = myMedia.MediaId;
                result.Title = myMedia.Title;
                result.Url = myMedia.Url;
                result.WebLink = myMedia.WebLink;
                result.YoutubeLink = myMedia.YoutubeLink;
                result.LikeStatus = false;
                result.LikeCount = Convert.ToString(dc.Likes.Where(o => o.MediaId == id).Count());
                result.MediaComments = resultComments;
                result.CommentCount = Convert.ToString(tempCommentCount);
                result.ShareCount = Convert.ToString(tempShareCount);
            }
            else
            {
                
                result.Description = myMedia.Description;
                result.ImageUrl = myMedia.ImageUrl;
                result.IsActive = myMedia.IsActive;
                result.MediaDate = myMedia.MediaDate;
                result.MediaId = myMedia.MediaId;
                result.Title = myMedia.Title;
                result.Url = myMedia.Url;
                result.WebLink = myMedia.WebLink;
                result.YoutubeLink = myMedia.YoutubeLink;
                result.LikeStatus = true;
                result.LikeCount = Convert.ToString(dc.Likes.Where(o => o.MediaId == id).Count());
                result.MediaComments = resultComments;
                result.CommentCount = Convert.ToString(tempCommentCount);
                result.ShareCount = Convert.ToString(tempShareCount);
            }
            return result;
        }
        public MediaDto getMediaByIdAllComments(int id, string userId)
        {
            var temp = dc.Likes.Where(o => o.MediaId == id && o.UserId == userId).FirstOrDefault();
            var myMedia = dc.Media.Where(o => o.MediaId == id).FirstOrDefault();
            if(myMedia.HideImage == true)
            {
                myMedia.ImageUrl = null;
            }
            MediaDto result = new MediaDto();
            // get all Comments
            List<MediaCommentDto> resultComments = new List<MediaCommentDto>();
            var comments = dc.Comments.Where(o => o.MediaId == id).OrderByDescending(p => p.Id).ToList();
            int tempCommentCount = comments.Count();
            int tempShareCount = dc.Shares.Where(o => o.MediaId == id).ToList().Count();
            if (comments != null)
            {
                User tempUser;
                foreach (var entity in comments)
                {
                    tempUser = dc.Users.Where(o => o.Id == entity.UserId).First();
                    resultComments.Add(new MediaCommentDto()
                    {
                        userId = entity.UserId,
                        CommentDate = entity.CommentDate,
                        CommentId = entity.Id,
                        theComment = entity.Comment,
                        userName = tempUser.FirstName + " " + tempUser.LastName
                    });
                }
            }
            if (temp == null)
            {
                
                result.Description = myMedia.Description;
                result.ImageUrl = myMedia.ImageUrl;
                result.IsActive = myMedia.IsActive;
                result.MediaDate = myMedia.MediaDate;
                result.MediaId = myMedia.MediaId;
                result.Title = myMedia.Title;
                result.Url = myMedia.Url;
                result.WebLink = myMedia.WebLink;
                result.YoutubeLink = myMedia.YoutubeLink;
                result.LikeStatus = false;
                result.LikeCount = Convert.ToString(dc.Likes.Where(o => o.MediaId == id).Count());
                result.MediaComments = resultComments;
                result.CommentCount = Convert.ToString(tempCommentCount);
                result.ShareCount = Convert.ToString(tempShareCount);
            }
            else
            {
                
                result.Description = myMedia.Description;
                result.ImageUrl = myMedia.ImageUrl;
                result.IsActive = myMedia.IsActive;
                result.MediaDate = myMedia.MediaDate;
                result.MediaId = myMedia.MediaId;
                result.Title = myMedia.Title;
                result.Url = myMedia.Url;
                result.WebLink = myMedia.WebLink;
                result.YoutubeLink = myMedia.YoutubeLink;
                result.LikeStatus = true;
                result.LikeCount = Convert.ToString(dc.Likes.Where(o => o.MediaId == id).Count());
                result.MediaComments = resultComments;
                result.CommentCount = Convert.ToString(tempCommentCount);
                result.ShareCount = Convert.ToString(tempShareCount);
            }
            return result;
        }
        public List<Media> getAllMedia()
        {
            return dc.Media.ToList();
        }
        public List<MediaDto> searchTerm(string term, string userId)
        {
            var temp = dc.Media.Where(a => a.Title.Contains(term)).ToList();
            List<MediaDto> result = new List<MediaDto>();
            List<MediaCommentDto> resultComments;
            List<Comments> comments = new List<Comments>();
            int tempCommentCount;
            int tempShareCount;
            int TempLikeCount;
            foreach (var entity in temp)
            {
                if (entity.HideImage == true)
                {
                    entity.ImageUrl = null;
                }
                resultComments = new List<MediaCommentDto>();

                comments = dc.Comments.Where(o => o.MediaId == entity.MediaId).OrderByDescending(p => p.Id).ToList();
                tempCommentCount = comments.Count();
                tempShareCount = dc.Shares.Where(o => o.MediaId == entity.MediaId).ToList().Count();
                User tempUser;
                if (comments != null)
                {
                    foreach (var subentity in comments.Take(2))
                    {
                        tempUser = dc.Users.Where(o => o.Id == subentity.UserId).FirstOrDefault();
                        if (tempUser != null)
                        {
                            resultComments.Add(new MediaCommentDto()
                            {
                                userId = subentity.UserId,
                                CommentDate = subentity.CommentDate,
                                CommentId = subentity.Id,
                                theComment = subentity.Comment,
                                userName = tempUser.FirstName + " " + tempUser.LastName
                            });
                        }
                    }
                }
                bool boolResult;
                if (userId == "null")
                {
                    boolResult = false;
                }
                else if (dc.Likes.Where(o => o.MediaId == entity.MediaId && o.UserId == userId).FirstOrDefault() != null)
                {
                    boolResult = true;
                }
                else
                {
                    boolResult = false;
                }
                TempLikeCount = dc.Likes.Where(o => o.MediaId == entity.MediaId).Count();
                if (boolResult)
                {
                    result.Add(new MediaDto()
                    {

                        Description = entity.Description,
                        ImageUrl = entity.ImageUrl,
                        IsActive = entity.IsActive,
                        MediaDate = entity.MediaDate,
                        MediaId = entity.MediaId,
                        Title = entity.Title,
                        Url = entity.Url,
                        WebLink = entity.WebLink,
                        YoutubeLink = entity.YoutubeLink,
                        LikeStatus = true,
                        LikeCount = Convert.ToString(TempLikeCount),
                        MediaComments = resultComments,
                        ShareCount = Convert.ToString(tempShareCount),
                        CommentCount = Convert.ToString(tempCommentCount)
                    });

                }
                else
                {
                    result.Add(new MediaDto()
                    {

                        Description = entity.Description,
                        ImageUrl = entity.ImageUrl,
                        IsActive = entity.IsActive,
                        MediaDate = entity.MediaDate,
                        MediaId = entity.MediaId,
                        Title = entity.Title,
                        Url = entity.Url,
                        WebLink = entity.WebLink,
                        YoutubeLink = entity.YoutubeLink,
                        LikeStatus = false,
                        LikeCount = Convert.ToString(TempLikeCount),
                        MediaComments = resultComments,
                        ShareCount = Convert.ToString(tempShareCount),
                        CommentCount = Convert.ToString(tempCommentCount)
                    });

                }
            }
            return result;
        }
        public List<MediaDto> searchMediaProducts(string term, string userId)
        {
            var tempEntry = dc.Entry.Where(a => a.Name.Contains(term)).ToList();
            var tempMediaProduct = new List<MediaProductLink>();
            var temp = new List<Media>();
            foreach(var entity in tempEntry)
            {
                tempMediaProduct = dc.MediaProductLinks.Where(a => a.EntryId == entity.EntryId).ToList();
                foreach(var subEntity in tempMediaProduct)
                {
                    temp.Add(dc.Media.Where(a => a.MediaId == subEntity.MediaId).First());
                }
            }
            List<MediaDto> result = new List<MediaDto>();
            List<MediaCommentDto> resultComments;
            List<Comments> comments = new List<Comments>();
            int tempCommentCount;
            int tempShareCount;
            int TempLikeCount;
            foreach (var entity in temp)
            {
                if (entity.HideImage == true)
                {
                    entity.ImageUrl = null;
                }
                resultComments = new List<MediaCommentDto>();

                comments = dc.Comments.Where(o => o.MediaId == entity.MediaId).OrderByDescending(p => p.Id).ToList();
                tempCommentCount = comments.Count();
                tempShareCount = dc.Shares.Where(o => o.MediaId == entity.MediaId).ToList().Count();
                User tempUser;
                if (comments != null)
                {
                    foreach (var subentity in comments.Take(2))
                    {
                        tempUser = dc.Users.Where(o => o.Id == subentity.UserId).FirstOrDefault();
                        if (tempUser != null)
                        {
                            resultComments.Add(new MediaCommentDto()
                            {
                                userId = subentity.UserId,
                                CommentDate = subentity.CommentDate,
                                CommentId = subentity.Id,
                                theComment = subentity.Comment,
                                userName = tempUser.FirstName + " " + tempUser.LastName
                            });
                        }
                    }
                }
                bool boolResult;
                if (userId == "null")
                {
                    boolResult = false;
                }
                else if (dc.Likes.Where(o => o.MediaId == entity.MediaId && o.UserId == userId).FirstOrDefault() != null)
                {
                    boolResult = true;
                }
                else
                {
                    boolResult = false;
                }
                TempLikeCount = dc.Likes.Where(o => o.MediaId == entity.MediaId).Count();
                if (boolResult)
                {
                    result.Add(new MediaDto()
                    {

                        Description = entity.Description,
                        ImageUrl = entity.ImageUrl,
                        IsActive = entity.IsActive,
                        MediaDate = entity.MediaDate,
                        MediaId = entity.MediaId,
                        Title = entity.Title,
                        Url = entity.Url,
                        WebLink = entity.WebLink,
                        YoutubeLink = entity.YoutubeLink,
                        LikeStatus = true,
                        LikeCount = Convert.ToString(TempLikeCount),
                        MediaComments = resultComments,
                        ShareCount = Convert.ToString(tempShareCount),
                        CommentCount = Convert.ToString(tempCommentCount)
                    });
                }
                else
                {
                    result.Add(new MediaDto()
                    {

                        Description = entity.Description,
                        ImageUrl = entity.ImageUrl,
                        IsActive = entity.IsActive,
                        MediaDate = entity.MediaDate,
                        MediaId = entity.MediaId,
                        Title = entity.Title,
                        Url = entity.Url,
                        WebLink = entity.WebLink,
                        YoutubeLink = entity.YoutubeLink,
                        LikeStatus = false,
                        LikeCount = Convert.ToString(TempLikeCount),
                        MediaComments = resultComments,
                        ShareCount = Convert.ToString(tempShareCount),
                        CommentCount = Convert.ToString(tempCommentCount)
                    });

                }
            }
            return result;
        }
        public List<MediaDto> MediaWithVideos(string userId)
        {
            var temp = dc.Media.Where(a => a.YoutubeLink != null & a.YoutubeLink != "").ToList().Take(30);
            List<MediaDto> result = new List<MediaDto>();
            List<MediaCommentDto> resultComments;
            List<Comments> comments = new List<Comments>();
            int tempCommentCount;
            int tempShareCount;
            int TempLikeCount;
            foreach (var entity in temp)
            {
                if (entity.HideImage == true)
                {
                    entity.ImageUrl = null;
                }
                resultComments = new List<MediaCommentDto>();

                comments = dc.Comments.Where(o => o.MediaId == entity.MediaId).OrderByDescending(p => p.Id).ToList();
                tempCommentCount = comments.Count();
                tempShareCount = dc.Shares.Where(o => o.MediaId == entity.MediaId).ToList().Count();
                User tempUser;
                if (comments != null)
                {
                    foreach (var subentity in comments.Take(2))
                    {
                        tempUser = dc.Users.Where(o => o.Id == subentity.UserId).FirstOrDefault();
                        if (tempUser != null)
                        {
                            resultComments.Add(new MediaCommentDto()
                            {
                                userId = subentity.UserId,
                                CommentDate = subentity.CommentDate,
                                CommentId = subentity.Id,
                                theComment = subentity.Comment,
                                userName = tempUser.FirstName + " " + tempUser.LastName
                            });
                        }
                    }
                }
                bool boolResult;
                if (userId == "null")
                {
                    boolResult = false;
                }
                else if (dc.Likes.Where(o => o.MediaId == entity.MediaId && o.UserId == userId).FirstOrDefault() != null)
                {
                    boolResult = true;
                }
                else
                {
                    boolResult = false;
                }
                TempLikeCount = dc.Likes.Where(o => o.MediaId == entity.MediaId).Count();
                if (boolResult)
                {
                    result.Add(new MediaDto()
                    {

                        Description = entity.Description,
                        ImageUrl = entity.ImageUrl,
                        IsActive = entity.IsActive,
                        MediaDate = entity.MediaDate,
                        MediaId = entity.MediaId,
                        Title = entity.Title,
                        Url = entity.Url,
                        WebLink = entity.WebLink,
                        YoutubeLink = entity.YoutubeLink,
                        LikeStatus = true,
                        LikeCount = Convert.ToString(TempLikeCount),
                        MediaComments = resultComments,
                        ShareCount = Convert.ToString(tempShareCount),
                        CommentCount = Convert.ToString(tempCommentCount)
                    });
                }
                else
                {
                    result.Add(new MediaDto()
                    {

                        Description = entity.Description,
                        ImageUrl = entity.ImageUrl,
                        IsActive = entity.IsActive,
                        MediaDate = entity.MediaDate,
                        MediaId = entity.MediaId,
                        Title = entity.Title,
                        Url = entity.Url,
                        WebLink = entity.WebLink,
                        YoutubeLink = entity.YoutubeLink,
                        LikeStatus = false,
                        LikeCount = Convert.ToString(TempLikeCount),
                        MediaComments = resultComments,
                        ShareCount = Convert.ToString(tempShareCount),
                        CommentCount = Convert.ToString(tempCommentCount)
                    });

                }
            }
            return result;
        }
        public List<MediaDto> MediaArticles(string userId)
        {
            var temp = dc.Media.Where(a => a.WebLink != null & a.WebLink != "").ToList().Take(30);
            List<MediaDto> result = new List<MediaDto>();
            List<MediaCommentDto> resultComments;
            List<Comments> comments = new List<Comments>();
            int tempCommentCount;
            int tempShareCount;
            int TempLikeCount;
            foreach (var entity in temp)
            {
                if (entity.HideImage == true)
                {
                    entity.ImageUrl = null;
                }
                resultComments = new List<MediaCommentDto>();

                comments = dc.Comments.Where(o => o.MediaId == entity.MediaId).OrderByDescending(p => p.Id).ToList();
                tempCommentCount = comments.Count();
                tempShareCount = dc.Shares.Where(o => o.MediaId == entity.MediaId).ToList().Count();
                User tempUser;
                if (comments != null)
                {
                    foreach (var subentity in comments.Take(2))
                    {
                        tempUser = dc.Users.Where(o => o.Id == subentity.UserId).FirstOrDefault();
                        if (tempUser != null)
                        {
                            resultComments.Add(new MediaCommentDto()
                            {
                                userId = subentity.UserId,
                                CommentDate = subentity.CommentDate,
                                CommentId = subentity.Id,
                                theComment = subentity.Comment,
                                userName = tempUser.FirstName + " " + tempUser.LastName
                            });
                        }
                    }
                }
                bool boolResult;
                if (userId == "null")
                {
                    boolResult = false;
                }
                else if (dc.Likes.Where(o => o.MediaId == entity.MediaId && o.UserId == userId).FirstOrDefault() != null)
                {
                    boolResult = true;
                }
                else
                {
                    boolResult = false;
                }
                TempLikeCount = dc.Likes.Where(o => o.MediaId == entity.MediaId).Count();
                if (boolResult)
                {
                    result.Add(new MediaDto()
                    {

                        Description = entity.Description,
                        ImageUrl = entity.ImageUrl,
                        IsActive = entity.IsActive,
                        MediaDate = entity.MediaDate,
                        MediaId = entity.MediaId,
                        Title = entity.Title,
                        Url = entity.Url,
                        WebLink = entity.WebLink,
                        YoutubeLink = entity.YoutubeLink,
                        LikeStatus = true,
                        LikeCount = Convert.ToString(TempLikeCount),
                        MediaComments = resultComments,
                        ShareCount = Convert.ToString(tempShareCount),
                        CommentCount = Convert.ToString(tempCommentCount)
                    });
                }
                else
                {
                    result.Add(new MediaDto()
                    {

                        Description = entity.Description,
                        ImageUrl = entity.ImageUrl,
                        IsActive = entity.IsActive,
                        MediaDate = entity.MediaDate,
                        MediaId = entity.MediaId,
                        Title = entity.Title,
                        Url = entity.Url,
                        WebLink = entity.WebLink,
                        YoutubeLink = entity.YoutubeLink,
                        LikeStatus = false,
                        LikeCount = Convert.ToString(TempLikeCount),
                        MediaComments = resultComments,
                        ShareCount = Convert.ToString(tempShareCount),
                        CommentCount = Convert.ToString(tempCommentCount)
                    });

                }
            }
            return result;
        }
        public List<Groups> getAllCatagories()
        {
            return dc.Groups.ToList();
        }
        public List<MediaDto> GetNextMediaBatch(int lastId, string userId, int languageId, PreviousBatch T)
        {
            List<MediaDto> result = new List<MediaDto>();
            List<MediaCommentDto> resultComments;
            List<Comments> comments = new List<Comments>();
            int tempCommentCount;
            int tempShareCount;
            int TempLikeCount;
            if(lastId == 0)
            {
                List<Media> tempMedia = new List<Media>();
                if(userId != "null")
                {
                    var UserLanguages = dc.UserLanguages.Where(o => o.UserId == userId).Select(o => o.LanguageId).ToList();
                    if(UserLanguages.Count == 0)
                    {
                        tempMedia = dc.Media.OrderByDescending(o => o.MediaId).Take(20).ToList();
                    }
                    else
                    {
                        var relatedLanguageMedia = dc.MediaLanguages.Where(o => UserLanguages.Contains(o.LanguageId)).Select(o => o.MediaId).ToList();
                        var tempMediaLanguage = dc.MediaLanguages.Where(o => relatedLanguageMedia.Contains(o.MediaId)).OrderByDescending(o => o.MediaId).Take(20).ToList();
                        foreach (var entity in tempMediaLanguage)
                        {
                            tempMedia.Add(dc.Media.Where(o => o.MediaId == entity.MediaId).FirstOrDefault());
                        }
                    }
                        
                 }
                else
                 {
                     tempMedia = dc.Media.OrderByDescending(o => o.MediaId).Take(20).ToList();
                 }
                
                foreach(var entity in tempMedia)
                {
                    if(entity.HideImage == true)
                    {
                        entity.ImageUrl = null;
                    }
                    resultComments = new List<MediaCommentDto>();

                    comments = dc.Comments.Where(o => o.MediaId == entity.MediaId).OrderByDescending(p => p.Id).ToList();
                    tempCommentCount = comments.Count();
                    tempShareCount = dc.Shares.Where(o => o.MediaId == entity.MediaId).ToList().Count();
                    User tempUser;
                    if (comments != null)
                    {
                        foreach (var subentity in comments.Take(2))
                        {
                            tempUser = dc.Users.Where(o => o.Id == subentity.UserId).FirstOrDefault();
                            if(tempUser != null)
                            {
                                resultComments.Add(new MediaCommentDto()
                                {
                                    userId = subentity.UserId,
                                    CommentDate = subentity.CommentDate,
                                    CommentId = subentity.Id,
                                    theComment = subentity.Comment,
                                    userName = tempUser.FirstName + " " + tempUser.LastName
                                });
                            }
                        }
                    }
                    bool boolResult;
                    if(userId == "null")
                    {
                        boolResult = false;
                    }
                    else if(dc.Likes.Where(o => o.MediaId == entity.MediaId && o.UserId == userId).FirstOrDefault() != null)
                    {
                        boolResult = true;
                    }
                    else
                    {
                        boolResult = false;
                    }
                    TempLikeCount = dc.Likes.Where(o => o.MediaId == entity.MediaId).Count();
                    if(boolResult)
                    {
                        result.Add(new MediaDto()
                        {
                            
                            Description = entity.Description,
                            ImageUrl = entity.ImageUrl,
                            IsActive = entity.IsActive,
                            MediaDate = entity.MediaDate,
                            MediaId = entity.MediaId,
                            Title = entity.Title,
                            Url = entity.Url,
                            WebLink = entity.WebLink,
                            YoutubeLink = entity.YoutubeLink,
                            LikeStatus = true,
                            LikeCount = Convert.ToString(TempLikeCount),
                            MediaComments = resultComments,
                            ShareCount = Convert.ToString(tempShareCount),
                            CommentCount = Convert.ToString(tempCommentCount)
                        });
                        
                    }
                    else
                    {
                        result.Add(new MediaDto()
                        {
                            
                            Description = entity.Description,
                            ImageUrl = entity.ImageUrl,
                            IsActive = entity.IsActive,
                            MediaDate = entity.MediaDate,
                            MediaId = entity.MediaId,
                            Title = entity.Title,
                            Url = entity.Url,
                            WebLink = entity.WebLink,
                            YoutubeLink = entity.YoutubeLink,
                            LikeStatus = false,
                            LikeCount = Convert.ToString(TempLikeCount),
                            MediaComments = resultComments,
                            ShareCount = Convert.ToString(tempShareCount),
                            CommentCount = Convert.ToString(tempCommentCount)
                        }); 
                       
                    }
                    
                }
            }
            else
            {
                // First if user is logged in filter according to language
                List<int> MediaToUse = new List<int>();
                if(userId == "null")
                {
                    MediaToUse = dc.Media.Where(x => !T.MediaId.Contains(x.MediaId)).Select(x => x.MediaId).ToList();
                }
                else
                {
                    var UserLanguages = dc.UserLanguages.Where(o => o.UserId == userId).Select(o => o.LanguageId).ToList();
                    if(UserLanguages.Count == 0)
                    {
                        MediaToUse = dc.Media.Where(x => !T.MediaId.Contains(x.MediaId)).Select(x => x.MediaId).ToList();
                    }
                    else
                    {
                        var relatedLanguageMedia = dc.MediaLanguages.Where(o => UserLanguages.Contains(o.LanguageId)).Select(o => o.MediaId).ToList();
                        MediaToUse = dc.Media.Where(o => relatedLanguageMedia.Contains(o.MediaId)).Where(x => !T.MediaId.Contains(x.MediaId)).Select(x => x.MediaId).ToList();
                    }
                }

                // Now to shuffle the Related Media
                var shuffled = MediaToUse.OrderBy(x => Guid.NewGuid()).Take(20).ToList();

                // Getting all the shuffled Related Media
                var temp = dc.Media.Where(p => shuffled.Contains(p.MediaId)).Take(20).ToList();
                //var temp = dc.Media.Where(p => p.MediaId < lastId).OrderByDescending(o => o.MediaId).Take(20).ToList();
                foreach (var entity in temp)
                {
                    if (entity.HideImage == true)
                    {
                        entity.ImageUrl = null;
                    }
                    resultComments = new List<MediaCommentDto>();
                    comments = dc.Comments.Where(o => o.MediaId == entity.MediaId).OrderByDescending(p => p.Id).ToList();
                    tempCommentCount = comments.Count();
                    tempShareCount = dc.Shares.Where(o => o.MediaId == entity.MediaId).ToList().Count();
                    if (comments != null)
                    {
                        User tempUser;
                        foreach (var subentity in comments.Take(2))
                        {
                            tempUser = dc.Users.Where(o => o.Id == subentity.UserId).First();
                            resultComments.Add(new MediaCommentDto()
                            {
                                userId = subentity.UserId,
                                CommentDate = subentity.CommentDate,
                                CommentId = subentity.Id,
                                theComment = subentity.Comment,
                                userName = tempUser.FirstName + " " + tempUser.LastName
                            });
                        }
                    }
                    TempLikeCount = dc.Likes.Where(o => o.MediaId == entity.MediaId).Count();
                    if (dc.Likes.Where(o => o.MediaId == entity.MediaId && o.UserId == userId).FirstOrDefault() != null)
                    {
                        result.Add(new MediaDto()
                        {
                            
                            Description = entity.Description,
                            ImageUrl = entity.ImageUrl,
                            IsActive = entity.IsActive,
                            MediaDate = entity.MediaDate,
                            MediaId = entity.MediaId,
                            Title = entity.Title,
                            Url = entity.Url,
                            WebLink = entity.WebLink,
                            YoutubeLink = entity.YoutubeLink,
                            LikeStatus = true,
                            LikeCount = Convert.ToString(TempLikeCount),
                            MediaComments = resultComments,
                            ShareCount = Convert.ToString(tempShareCount),
                            CommentCount = Convert.ToString(tempCommentCount)
                        });
                        
                    }
                    else
                    {
                        result.Add(new MediaDto()
                        {
                            
                            Description = entity.Description,
                            ImageUrl = entity.ImageUrl,
                            IsActive = entity.IsActive,
                            MediaDate = entity.MediaDate,
                            MediaId = entity.MediaId,
                            Title = entity.Title,
                            Url = entity.Url,
                            WebLink = entity.WebLink,
                            YoutubeLink = entity.YoutubeLink,
                            LikeStatus = false,
                            LikeCount = Convert.ToString(TempLikeCount),
                            MediaComments = resultComments,
                            ShareCount = Convert.ToString(tempShareCount),
                            CommentCount = Convert.ToString(tempCommentCount)
                        });
                        
                    }
                    
                }
            }
            return result;
        }

        
        public bool deleteMedia(int id)
        {
            try
            {
                dc.Media.Remove(dc.Media.Where(o => o.MediaId == id).First());

                var tempMediaRemediesLinks = dc.MediaRemediesLinks.Where(o => o.MediaId == id).FirstOrDefault();
                var tempMediaCat = dc.MediaCatagories.Where(o => o.MediaId == id).FirstOrDefault();
                var tempMediaProductLink = dc.MediaProductLinks.Where(o => o.MediaId == id).FirstOrDefault();

                if(tempMediaProductLink != null)
                {
                    dc.MediaProductLinks.Remove(tempMediaProductLink);
                }
                if(tempMediaCat != null)
                {
                    dc.MediaCatagories.Remove(tempMediaCat);
                }
                if (tempMediaRemediesLinks != null)
                {
                    dc.MediaRemediesLinks.Remove(tempMediaRemediesLinks);
                }

                dc.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool editMedia(SocialMediaDto T)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
