using FarmboekAPI.Models;
using FarmboekAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.Controllers
{
    [Route("brand")]
    public class BrandController: Controller
    {
        private BrandRepository brandRepository;

        public BrandController(FarmboekContext T)
        {
            brandRepository = new BrandRepository(T);
        }

        [HttpGet("{id}")]
        public IActionResult getBrand(int id)
        {
            return Ok(brandRepository.getBrand(id));
        }

        [HttpGet("contact/{contactid}")]
        public IActionResult getBrandContact(int contactid)
        {
            return Ok(brandRepository.getBrandContact(contactid));
        }

        [HttpGet("brands/all")]
        public async Task<IActionResult> getAllBrands()
        {
            return Ok(brandRepository.getAllBrands());
        }
    }
}
