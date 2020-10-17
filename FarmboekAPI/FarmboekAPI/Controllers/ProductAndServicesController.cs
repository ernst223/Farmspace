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
    [Route("productsandservice")]
    public class ProductAndServicesController: Controller
    {
        private ProductAndServicesRepository productsAndServicesRepository;

        public ProductAndServicesController(FarmboekContext T)
        {
            productsAndServicesRepository = new ProductAndServicesRepository(T);
        }
        [HttpGet("supergroup")]
        public IActionResult getSuperGroups()
        {
            return Ok(productsAndServicesRepository.getSuperGroups());
        }

        [HttpGet("groups/{id}")]
        public IActionResult getGroups(int id)
        {
            return Ok(productsAndServicesRepository.getGroups(id));
        }

        [HttpGet("subgroups/{superGroupId}/{groupId}")]
        public IActionResult getSubGroups(int superGroupId, int groupId)
        {
            return Ok(productsAndServicesRepository.getSubGroups(superGroupId, groupId));
        }

        [HttpGet("entries/{supergroup}/{group}/{subgroup}")]
        public IActionResult getEntries(int supergroup, int group, int subgroup)
        {
            return Ok(productsAndServicesRepository.getEntries(supergroup, group, subgroup));
        }
        [HttpGet("entries/search/{term}")]
        public IActionResult getEntriesByTerm(string term)
        {
            return Ok(productsAndServicesRepository.getEntriesByTerm(term));
        }

        [HttpGet("entries/all/{brandid}")]
        public async Task<IActionResult> getAllEntries(int brandid)
        {
            return Ok(productsAndServicesRepository.getAllEntries(brandid));
        }


        [HttpGet("entryattributes/{entryid}")]
        public IActionResult getEntryAttributes(int entryid)
        {
            return Ok(productsAndServicesRepository.getEntryAttributes(entryid));
        }

        [HttpGet("entriesbyrange/{range}")]
        public IActionResult getEntriesByRange(string range)
        {
            return Ok(productsAndServicesRepository.getEntriesRange(range));
        }

        [Authorize]
        [HttpGet("add/supergroup/{desc}")]
        public IActionResult addSuperGroup(string desc)
        {
            return Ok(productsAndServicesRepository.addSuperGroupFomCommercial(desc));
        }

        [Authorize]
        [HttpGet("add/group/{desc}/{SuperGroupId}")]
        public IActionResult addGroup(string desc, int SuperGroupId)
        {
            return Ok(productsAndServicesRepository.addGroupForCommercial(desc, SuperGroupId));
        }

        [Authorize]
        [HttpGet("add/subgroup/{desc}/{SuperGroupId}/{GroupId}")]
        public IActionResult addSubGroup(string desc, int SuperGroupId, int GroupId)
        {
            return Ok(productsAndServicesRepository.addSubGroupForCommercial(desc, SuperGroupId, GroupId));
        }

        [Authorize]
        [HttpDelete("delete/supergroup/{id}")]
        public IActionResult deleteSupergroup(int id)
        {
            return Ok(productsAndServicesRepository.deleteSupterGroup(id));
        }

        [Authorize]
        [HttpDelete("delete/group/{id}")]
        public IActionResult deleteGroup(int id)
        {
            return Ok(productsAndServicesRepository.deleteGroup(id));
        }

        [Authorize]
        [HttpDelete("delete/subgroup/{id}")]
        public IActionResult deleteSubGroup(int id)
        {
            return Ok(productsAndServicesRepository.deleteSubGroup(id));
        }

        [Authorize]
        [HttpPost("upload/entry")]
        public async Task<IActionResult> uploadEntry(IFormFile upload)
        {
            var result = productsAndServicesRepository.ProcessEntryFile(upload);
            return Ok(result);
        }
        [HttpGet("entrydetailsforseo/{entryid}")]
        public async Task<IActionResult> getEntryDetailsForSeo(int entryid)
        {
            return Ok(productsAndServicesRepository.getEntryDetailsForSEO(entryid));
        }

        [HttpGet("getentryattributesbyname/{productname}")]
        public async Task<IActionResult> GetEntryAttributesByName(string productname)
        {
            return Ok(productsAndServicesRepository.getEntryAttributes(productname));
        }
        [HttpGet("getentryroute/{entryId}")]
        public async Task<IActionResult> GetEntryRoute(int entryId)
        {
            return Ok(productsAndServicesRepository.getEntryRoute(entryId));
        }
        [HttpGet("entriesfordisplay")]
        public async Task<IActionResult> getEntriesForDisplay()
        {
            var result = productsAndServicesRepository.getEntriesForDisplay();
            if(result == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(result);
            }
        }

        [HttpGet("entriesfordisplay/lastupload/{amount}")]
        public async Task<IActionResult> getLatestEntriesForDisplay(int amount)
        {
            var result = productsAndServicesRepository.getEntriesForDisplay(amount);
            if (result == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(result);
            }
        }

        [Authorize]
        [HttpDelete("entry/delete/{entryid}")]
        public async Task<IActionResult> deleteEntry(int entryid)
        {
            return Ok(productsAndServicesRepository.deleteEntry(entryid));
        }

        [Authorize]
        [HttpPost("entries/delete")]
        public async Task<IActionResult> deleteEntryList([FromBody] DeleteByIdDto T)
        {
            return Ok(productsAndServicesRepository.deleteEntries(T));
        }
    }
}
