using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Data;
using DTOs;
using Entities;
using Extensions;
using Helpers;
using Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            this._mapper = mapper;
            this._userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers([FromQuery] UserParams userParams)
        {
            var users = await _userRepository.GetMembersAsync(userParams);
            // var usersToReturn = _mapper.Map<IEnumerable<MemberDto>>(users);
            Response.AddPaginationHeader(users.CurrentPage, users.PageSize, users.TotalCount, users.TotalPages);
            return Ok(users);
        }

        [HttpGet("id/{id}")]
        public async Task<ActionResult<MemberDto>> GetUserById(int id)
        {
            var user = await _userRepository.GetMemberByIdAsync(id);
            // var userToReturn = _mapper.Map<MemberDto>(user);
            if (user != null) return user;
            return NotFound();
        }

        [HttpGet("username/{username}")]
        public async Task<ActionResult<MemberDto>> GetUserByUsername(string username)
        {
            var user = await _userRepository.GetMemberByUsernameAsync(username);
            // var userToReturn = _mapper.Map<MemberDto>(user);
            if (user != null) return user;
            return NotFound();
        }
    }
}