using FarmboekAPI.Models;
using FarmboekAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.Controllers
{
    [Route("supplier")]
    public class SupplierController: Controller
    {
        private SupplierRepository supplierRepository;

        public SupplierController(FarmboekContext T)
        {
            supplierRepository = new SupplierRepository(T);
        }

        [HttpGet("{id}")]
        public IActionResult getSupplierWithId(int id)
        {
            return Ok(supplierRepository.getSupplierById(id));
        }

        [HttpGet("brands/{id}")]
        public IActionResult getSupplierBrands(int id)
        {
            return Ok(supplierRepository.getSupplierBrands(id));
        }

        [HttpGet("bybrand/{brandid}")]
        public IActionResult getSuppliersBybrand(int brandid)
        {
            return Ok(supplierRepository.getSuppliersByBrandId(brandid));
        }

        [HttpGet("province")]
        public IActionResult getProvinces()
        {
            return Ok(supplierRepository.getProvinces());
        }
    }
}
