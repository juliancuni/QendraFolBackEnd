using System.Collections.Generic;
using System.Threading.Tasks;
using BackEnd.Entities;
using BackEnd.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    public class OldCeshtjaController : BaseController
    {
        private readonly IOldCeshtjaRepository _repository;
        public OldCeshtjaController(IOldCeshtjaRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<IEnumerable<OldCeshtja>>> GetAll()
        {
            return Ok(await _repository.GetOldCeshtjetAsync());
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<OldCeshtja>> GetById(int id)
        {
            var oldCeshtje = await _repository.GetOldCeshtjaByIdAsync(id);
            if (oldCeshtje != null) return Ok(oldCeshtje);
            return NotFound();
        }

        [HttpPost("bulk")]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<BulkCreateReport>> CreateBulk(List<OldCeshtja> oldCeshtjet)
        {
            return await _repository.BulkCreateOldCeshtjeAsync(oldCeshtjet);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<OldCeshtja>> Create(OldCeshtja oldCeshtja)
        {
            return await _repository.CreateOldCeshtjaAsync(oldCeshtja);
        }

        [HttpPut]
        [Authorize(Roles = "admin")]
        public void Update(OldCeshtja oldCeshtja)
        {
            _repository.UpdateOldCeshtja(oldCeshtja);
        }
        [HttpDelete]
        [Authorize(Roles = "admin")]
        public void Delete(OldCeshtja oldCeshtja)
        {
            _repository.DeleteOldCeshtja(oldCeshtja);
        }
    }
}