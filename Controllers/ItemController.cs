using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Store.Data;
using System.Collections.Generic;
using Store.Dtos;

namespace Items.Controllers
{

    [Route("/api/items")]
    [ApiController]
    public class ItemsController: ControllerBase 
    {
        private readonly IStoreRepo _repository;
        private readonly IMapper _mapper;

        public ItemsController(IStoreRepo repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/items
        [HttpGet]
        public ActionResult <IEnumerable<ItemReadDto>> GetAllItems() 
        {
            var items = _repository.GetAllItems();

            return Ok(_mapper.Map<IEnumerable<ItemReadDto>>(items));
        }
    }
}