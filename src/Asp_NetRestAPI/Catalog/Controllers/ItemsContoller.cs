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
    [Route("Items")]
    public class ItemsContoller:ControllerBase
    {
       // private readonly InMemItemRepository repository;
        private readonly IItemsRepository itmesRepo;

        public ItemsContoller(IItemsRepository itmesRepo)
        {
            //repository = new InMemItemRepository();
            this.itmesRepo = itmesRepo;
        }
        //Get/items
        [HttpGet]
        public IEnumerable<ItemDto> GetItmes()
        {
            var items= itmesRepo.GetItems().Select(x => x.AsDto());
            return items;
        }
        //Get/items/{id}
         [HttpGet("{id}")]
        public ActionResult<ItemDto> GetItme(Guid id)
        {
            var item=itmesRepo.GetItem(id);
            if(item is null)
            {
                return NotFound();
            }
            return item.AsDto();
        }
    }
}