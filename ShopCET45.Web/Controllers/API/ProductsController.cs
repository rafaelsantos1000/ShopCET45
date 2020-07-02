﻿using Microsoft.AspNetCore.Mvc;
using ShopCET45.Web.Data;

namespace ShopCET45.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {

        private readonly IProductRepository _productRepository;


        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_productRepository.GetAll());
        }
    }
}