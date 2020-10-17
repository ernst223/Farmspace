using FarmboekAPI.DTO;
using FarmboekAPI.Models;
using FarmboekAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.Controllers
{
    [Route("problemandsolution")]
    public class ProblemAndSolutionController : Controller
    {
        private ProblemAndSolutionRepository problemAndSolutionRepository;

        public ProblemAndSolutionController(FarmboekContext T)
        {
            problemAndSolutionRepository = new ProblemAndSolutionRepository(T);
        }

        [HttpGet("supergroup")]
        public IActionResult getSuperGroups()
        {
            return Ok(problemAndSolutionRepository.getSuperGroups());
        }

        [HttpGet("group/{id}")]
        public IActionResult getGroup(int id)
        {
            var result = problemAndSolutionRepository.getGroups(id);
            return Ok(result);
        }

        [HttpGet("subgroup/{id}")]
        public IActionResult getSubgroup(int id)
        {
            return Ok(problemAndSolutionRepository.getSubGroups(id));
        }

        [HttpGet("problems/{supergroup}/{group}/{subgroup}")]
        public IActionResult getProblemsFromRoute(int supergroup, int group, int subgroup)
        {
            return Ok(problemAndSolutionRepository.getProblemsFromRoute(supergroup, group, subgroup));
        }

        [HttpGet("problembase/{id}")]
        public IActionResult getProblemBase(int id)
        {
            return Ok(problemAndSolutionRepository.getRouteProblemFromId(id));
        }

        [HttpGet("problembasedetailsforseo/{id}")]
        public async Task<IActionResult> getProblembaseDetailsForSeo(int id)
        {
            return Ok(problemAndSolutionRepository.getProblembaseDetailsSeo(id));
        }

        [HttpGet("problembase/{supergroup}/{group}/{subgroup}/{problemname}")]
        public IActionResult getProblemBase(string supergroup, string group, string subgroup, string problemname)
        {
            return Ok(problemAndSolutionRepository.getRouteProblemFromStrings(supergroup, group, subgroup, problemname));
        }

        [HttpGet("problembase/images/{problembaseId}")]
        public IActionResult getProblemBaseImages(int problembaseId)
        {
            return Ok(problemAndSolutionRepository.getProblemsFromRouteImages(problembaseId));
        }

        [HttpGet("problemfordisplay")]
        public async Task<IActionResult> getProblemsForDisplay()
        {
            return Ok(problemAndSolutionRepository.GetProblemBaseForDisplay());
        }

        [HttpGet("problemfordisplay/{amount}")]
        public async Task<IActionResult> getProblemsForDisplay(int amount)
        {
            return Ok(problemAndSolutionRepository.GetProblemBaseForDisplay(amount));
        }

        [Authorize]
        [HttpGet("add/supergroup/{desc}")]
        public IActionResult addSuperGroup(string desc)
        {
            return Ok(problemAndSolutionRepository.addSuperGroupForInformation(desc));
        }

        [Authorize]
        [HttpGet("add/group/{desc}/{SuperGroupId}")]
        public IActionResult addGroup(string desc, int SuperGroupId)
        {
            return Ok(problemAndSolutionRepository.addGroupForInformation(desc, SuperGroupId));
        }

        [Authorize]
        [HttpGet("add/subgroup/{desc}/{SuperGroupId}/{GroupId}")]
        public IActionResult addSubGroup(string desc, int SuperGroupId, int GroupId)
        {
            return Ok(problemAndSolutionRepository.addSubGroupForInformation(desc, SuperGroupId, GroupId));
        }

        [Authorize]
        [HttpDelete("delete/supergroup/{id}")]
        public IActionResult deleteSupergroup(int id)
        {
            return Ok(problemAndSolutionRepository.deleteSupterGroup(id));
        }

        [Authorize]
        [HttpDelete("delete/group/{id}")]
        public IActionResult deleteGroup(int id)
        {
            return Ok(problemAndSolutionRepository.deleteGroup(id));
        }

        [Authorize]
        [HttpDelete("delete/subgroup/{id}")]
        public IActionResult deleteSubGroup(int id)
        {
            return Ok(problemAndSolutionRepository.deleteSubGroup(id));
        }

        [Authorize]
        [HttpPost("upload/problem")]
        public async Task<IActionResult> uploadRemedy(IFormFile upload)
        {
            var result = problemAndSolutionRepository.ProcessProblemFile(upload);
            return Ok(result);
        }

        [HttpGet("problemfordisplay/admin")]
        public async Task<IActionResult> getRemediesForDisplay()
        {
            return Ok(problemAndSolutionRepository.getProblemForDisplay());
        }
        [HttpGet("problemfordisplay/admin/{amount}")]
        public async Task<IActionResult> getLatestRemediesForDisplay(int amount)
        {
            return Ok(problemAndSolutionRepository.getLatestProblemForDisplay(amount));
        }

        [Authorize]
        [HttpPost("delete")]
        public async Task<IActionResult> deleteRemedies([FromBody] DeleteByIdDto T)
        {
            return Ok(problemAndSolutionRepository.deleteProblem(T));
        }
    }
}
