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
    [Route("remedies")]
    public class RemediesController: Controller
    {
        private RemediesRepository remediesRepository;

        public RemediesController(FarmboekContext T)
        {
            remediesRepository = new RemediesRepository(T);
        }

        [HttpGet("all/{brandid}")]
        public async Task<IActionResult> getAllRemedies(int brandid)
        {
            return Ok(remediesRepository.getAllRemedies(brandid));
        }

        [HttpGet("{problembaseid}")]
        public IActionResult getRemedies(int problembaseid)
        {
            return Ok(remediesRepository.getRemedies(problembaseid));
        }
        [HttpGet("byid/{id}")]
        public IActionResult getRemediesById(int id)
        {
            return Ok(remediesRepository.getRemedyById(id));
        }

        [HttpGet("brand/{id}")]
        public IActionResult getBrand(int id)
        {
            return Ok(remediesRepository.getBrand(id));
        }

        [HttpGet("problems/{productbaseid}")]
        public IActionResult getRemedyProblems(int productbaseid)
        {
            return Ok(remediesRepository.getRemedyProblems(productbaseid));
        }

        [HttpGet("activeingredient/{productid}")]
        public IActionResult getActiveIngredient(int productid)
        {
            return Ok(remediesRepository.GetActiveIngredient(productid));
        }

        [Authorize]
        [HttpPost("upload/remedy")]
        public async Task<IActionResult> uploadRemedy(IFormFile upload)
        {
            var result = remediesRepository.ProcessRemedyFile(upload);
            return Ok(result);
        }

        [HttpGet("remediesfordisplay")]
        public async Task<IActionResult> getRemediesForDisplay()
        {
            return Ok(remediesRepository.getRemediesForDisplay());
        }
        [HttpGet("remediesfordisplay/{amount}")]
        public async Task<IActionResult> getLatestRemediesForDisplay(int amount)
        {
            return Ok(remediesRepository.getLatestRemediesForDisplay(amount));
        }

        [Authorize]
        [HttpPost("delete")]
        public async Task<IActionResult> deleteRemedies([FromBody] DeleteByIdDto T)
        {
            return Ok(remediesRepository.deleteRemedies(T));
        }
    }
}
