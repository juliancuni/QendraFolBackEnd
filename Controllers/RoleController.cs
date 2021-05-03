using System.Collections.Generic;
using System.Threading.Tasks;
using Controllers;
using BackEnd.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{

    public class RoleController : BaseController
    {
        private readonly RoleManager<ApiRole> _roleManager;
        public RoleController(RoleManager<ApiRole> roleManager)
        {
            this._roleManager = roleManager;
        }

        [HttpPost]
        public async Task<ActionResult<IdentityResult>> CreateRole(ApiRole role)
        {
            return await _roleManager.CreateAsync(role);
        }

        // [HttpPost("update")]
        // public async Task<ActionResult<IdentityResult>> UpdateRole(ApiRole role)
        // {
        //     var roleFound = await _roleManager.Roles.SingleOrDefaultAsync(r => r.Id == role.Id);
        //     if(roleFound == null) return NotFound(); 
        //     var result = await _roleManager.UpdateAsync(role);
        //     return result;
        // }

        [HttpGet]
        public async Task<ActionResult<List<ApiRole>>> GetAllRoles()
        {
            return await _roleManager.Roles.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ApiRole>> GetRoleById(int id)
        {
            var role = await _roleManager.Roles.FirstOrDefaultAsync(x => x.Id == id);
            if (role != null) return Ok(role);
            return NotFound();
        }

        [HttpGet("name/{name}")]
        public async Task<ActionResult<ApiRole>> GetRoleByName(string name)
        {
            var role = await _roleManager.Roles.FirstOrDefaultAsync(x => x.Name == name);
            if (role != null) return Ok(role);
            return NotFound();
        }
        [HttpDelete]
        public void DeleteById(ApiRole role) {
            _roleManager.DeleteAsync(role);
        }
    }
}