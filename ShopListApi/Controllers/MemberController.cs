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
    public class MemberController : ControllerBase
    {
        private readonly IMemberRepository _memberRep;
        public MemberController(IMemberRepository memberRep)
        {
            _memberRep = memberRep;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Member>>> Get()
        {
            var members = await _memberRep.GetAsync();
            return Ok(members);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Member>>> GetById(int id)
        {
            var member = await _memberRep.GetByIdAsync(id);

            if (member == null)
                return NotFound();

            return Ok(member);
        }

        [HttpPost]
        public async Task<ActionResult> Create(MemberDto memberDto)
        {
            var member = new Member
            {
                FirstName = memberDto.FirstName,
                LastName = memberDto.LastName
            };

            await _memberRep.AddAsync(member);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, MemberDto memberDto)
        {
            var member = await _memberRep.GetByIdAsync(id);

            if (member == null)
                return NotFound();

            var memberToUpdate = new Member{
                FirstName = memberDto.FirstName,
                LastName = memberDto.LastName
            };

            await _memberRep.UpdateAsync(memberToUpdate);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _memberRep.DeleteAsync(id);
            return Ok();
        }
    }
}