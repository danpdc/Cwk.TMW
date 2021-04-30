using Cwk.TMW.Core.Abstractions.Repositories;
using Cwk.TMW.Core.Models;
using Cwk.TMW.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TmwDbContext _ctx;
        public UserRepository(TmwDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<User> UpdateUserAsync(User updatedUser)
        {
            try
            {
                _ctx.Users.Update(updatedUser);
                await _ctx.SaveChangesAsync();
                return updatedUser;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
