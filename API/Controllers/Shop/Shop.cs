using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Services.Shop;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers.Shop
{
    using Domain.Models;
    
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IShopCreationService _shopCreationService;
        public ShopController(IShopCreationService shopCreationService)
        {
            _shopCreationService = shopCreationService;
        }

        [HttpPost("CreateShop")]
        public ActionResult CreateShop(Shop shop)
        {
            _shopCreationService.CreateShop(shop);
            return Ok();
        }
            
        
    }
}
