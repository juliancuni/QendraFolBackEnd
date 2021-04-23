using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DTOs;
using Entities;
using Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public UserRepository(DataContext context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }

        public async Task<MemberDto> GetMemberByIdAsync(int id)
        {
            return await _context.Users.Where(u => u.Id == id).ProjectTo<MemberDto>(_mapper.ConfigurationProvider).SingleOrDefaultAsync();
        }

        public async Task<MemberDto> GetMemberByUsernameAsync(string username)
        {
            return await _context.Users.Where(u => u.Username == username).ProjectTo<MemberDto>(_mapper.ConfigurationProvider).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<MemberDto>> GetMembersAsync()
        {
            return await _context.Users.ProjectTo<MemberDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<ApiUser> GetUserByIdAsync(int id)
        {
            return await _context.Users.Include(u => u.Fotografite).SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ApiUser> GetUserByUserNameAsync(string username)
        {
            return await _context.Users.Include(u => u.Fotografite).SingleOrDefaultAsync(x => x.Username == username);
        }

        public async Task<IEnumerable<ApiUser>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(ApiUser user)
        {
            _context.Entry(user).State = EntityState.Modified;
        }
    }
}