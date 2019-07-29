using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsStaticController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemsStaticController(IItemService itemService)
        {
            _itemService = itemService;
        }

        // GET: api/Items
        [HttpGet]
        [ProducesResponseType(typeof(List<ItemDTO>), 200)]
        public async Task<IActionResult> Get()
        {
            var items = await _itemService.Get();
            var itemViewModels = Mapper.Map<List<ItemDTO>>(items);  // version with static AutoMapper
            return Ok(itemViewModels);
        }
    }
}
