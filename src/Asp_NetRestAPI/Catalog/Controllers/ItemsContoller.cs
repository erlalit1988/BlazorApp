using System.Linq;
using System;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;
using Catalog.Entities;
using System.Collections.Generic;
using Catalog.Dtos;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsContoller:ControllerBase
    {
        private readonly IItemsRepository _itmesRepo;

        public ItemsContoller(IItemsRepository itmesRepo)
        {
            _itmesRepo = itmesRepo;
        }
        //Get/items
        [HttpGet]
        public IEnumerable<ItemDto> GetItmes()
        {
            var items= _itmesRepo.GetItems()
                         .Select(item => item.AsDto()).ToList();
            return items;
        }
        //Get/items/{id}
         [HttpGet("{id}")]
        public ActionResult<ItemDto> GetItem(Guid id)
        {
            var item= _itmesRepo.GetItem(id);
            if(item is null)
            {
                return NotFound();
            }
            return item.AsDto();
        }
        //Post/items
        [HttpPost]
        public ActionResult<ItemDto> CreateItem(CreateItemDto itemDto)
        {
            Item item=new()
            {
                Id=Guid.NewGuid(),
                Name=itemDto.Name,
                Price=itemDto.Price,
                CreateDate=DateTimeOffset.UtcNow
            };
            _itmesRepo.CreateItem(item);

            return CreatedAtAction(nameof(GetItem),new {id = item.Id},item.AsDto());
        }
    }
}