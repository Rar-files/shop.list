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
    public class QuantitieTypeController : ControllerBase
    {
        private readonly IQuantitieTypeRepository _quantitieTypeRep;
        public QuantitieTypeController(IQuantitieTypeRepository quantitieTypeRep)
        {
            _quantitieTypeRep = quantitieTypeRep;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuantitieType>>> Get()
        {
            var quantitieTypes = await _quantitieTypeRep.GetAsync();
            return Ok(quantitieTypes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<QuantitieType>>> GetById(int id)
        {
            var quantitieType = await _quantitieTypeRep.GetByIdAsync(id);

            if (quantitieType == null)
                return NotFound();

            return Ok(quantitieType);
        }

        [HttpPost]
        public async Task<ActionResult> Create(QuantitieTypeDto quantitieTypeDto)
        {
            var quantitieType = new QuantitieType
            {
                Name = quantitieTypeDto.Name,
                ShortCut = quantitieTypeDto.ShortCut,
                HowManyGrams = quantitieTypeDto.HowManyGrams
            };

            await _quantitieTypeRep.AddAsync(quantitieType);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, QuantitieTypeDto quantitieTypeDto)
        {
            var quantitieType = await _quantitieTypeRep.GetByIdAsync(id);

            if (quantitieType == null)
                return NotFound();

            var quantitieTypeToUpdate = new QuantitieType{
                Name = quantitieTypeDto.Name,
                ShortCut = quantitieTypeDto.ShortCut,
                HowManyGrams = quantitieTypeDto.HowManyGrams
            };

            await _quantitieTypeRep.UpdateAsync(quantitieTypeToUpdate);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _quantitieTypeRep.DeleteAsync(id);
            return Ok();
        }
    }
}