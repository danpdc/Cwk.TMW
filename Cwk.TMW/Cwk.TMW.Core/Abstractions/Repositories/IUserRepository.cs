using Cwk.TMW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Core.Abstractions.Repositories
{
    public interface IUserRepository
    {
        Task<User> UpdateUserAsync(User updatedUser);
    }
}
