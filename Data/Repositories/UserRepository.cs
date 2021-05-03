using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using BackEnd.DTOs;
using BackEnd.Interfaces;
using BackEnd.Entities;
using Microsoft.EntityFrameworkCore;
using BackEnd.Helpers;

namespace BackEnd.Data.Repositories
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

        public async Task<MemberDto> GetMemberByUserNameAsync(string UserName)
        {
            return await _context.Users.Where(u => u.UserName == UserName).ProjectTo<MemberDto>(_mapper.ConfigurationProvider).SingleOrDefaultAsync();
        }

        public Task<MemberDto> GetMemberByUsernameAsync(string username)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams)
        {
            var query = _context.Users.ProjectTo<MemberDto>(_mapper.ConfigurationProvider).AsNoTracking();
            return await PagedList<MemberDto>.CreateAsync(query, userParams.PageNumber, userParams.PageSize);
        }


        public async Task<ApiUser> GetUserByIdAsync(int id)
        {
            return await _context.Users.Include(u => u.Fotografite).SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ApiUser> GetUserByUserNameAsync(string UserName)
        {
            return await _context.Users.Include(u => u.Fotografite).SingleOrDefaultAsync(x => x.UserName == UserName);
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