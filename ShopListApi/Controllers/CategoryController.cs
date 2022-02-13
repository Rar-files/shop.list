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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRep;
        public CategoryController(ICategoryRepository categoryRep)
        {
            _categoryRep = categoryRep;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> Get()
        {
            var cat = await _categoryRep.GetAsync();
            return Ok(cat);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Category>>> GetById(int id)
        {
            var cat = await _categoryRep.GetByIdAsync(id);

            if (cat == null)
                return NotFound();

            return Ok(cat);
        }

        [HttpPost]
        public async Task<ActionResult> Create(CategoryDto categoryDto)
        {
            var cat = new Category
            {
                Name = categoryDto.Name,
                Description = categoryDto.Description
            };

            await _categoryRep.AddAsync(cat);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, CategoryDto categoryDto)
        {
            var cat = await _categoryRep.GetByIdAsync(id);

            if (cat == null)
                return NotFound();

            var catToUpdate = new Category
            {
                Name = categoryDto.Name,
                Description = categoryDto.Description
            };

            await _categoryRep.UpdateAsync(catToUpdate);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _categoryRep.DeleteAsync(id);
            return Ok();
        }
    }
}