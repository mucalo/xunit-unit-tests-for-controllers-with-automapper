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
    public class ItemsInstanceController : ControllerBase
    {
        private readonly IItemService _itemService;
        private readonly IMapper _mapper;

        public ItemsInstanceController(IItemService itemService, IMapper mapper)
        {
            _itemService = itemService;
            _mapper = mapper;
        }

        // GET: api/Items
        [HttpGet]
        [ProducesResponseType(typeof(List<ItemDTO>), 200)]
        public async Task<IActionResult> Get()
        {
            var items = await _itemService.Get();
            var itemViewModels = _mapper.Map<List<ItemDTO>>(items);   // version with singleton AutoMapper
            return Ok(itemViewModels);
        }
    }
}
