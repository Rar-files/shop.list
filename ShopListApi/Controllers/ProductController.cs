using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopListApi.Interfaces;
using ShopListApi.Models;
using ShopListApi.Dtos;

namespace ShopListApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRep;
        public ProductController(IProductRepository productRep)
        {
            _productRep = productRep;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
            var products = await _productRep.GetAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetById(int id)
        {
            var product = await _productRep.GetByIdAsync(id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult> Create(ProductDto productDto)
        {
            var product = new Product
            {
                Name = productDto.Name,
                ImageURL = productDto.ImageURL,
                Grams = productDto.Grams,
                QuantitieTypes = productDto.QuantitieTypes,
                Description = productDto.Description,
                Categories = productDto.Categories
            };

            await _productRep.AddAsync(product);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, ProductDto productDto)
        {
            var product = await _productRep.GetByIdAsync(id);

            if (product == null)
                return NotFound();

            var productToUpdate = new Product{
                Name = productDto.Name,
                ImageURL = productDto.ImageURL,
                Grams = productDto.Grams,
                QuantitieTypes = productDto.QuantitieTypes,
                Description = productDto.Description,
                Categories = productDto.Categories
            };

            await _productRep.UpdateAsync(productToUpdate);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _productRep.DeleteAsync(id);
            return Ok();
        }
    }
}