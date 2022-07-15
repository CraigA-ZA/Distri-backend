using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.DTOs.DTOs;
using Repository.Models.Services.Shop;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers.Shop
{
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
        public ActionResult CreateShop(ShopDTO shop)
        {
            _shopCreationService.CreateShop(shop);
            return Ok();
        }
            
        
    }
}
