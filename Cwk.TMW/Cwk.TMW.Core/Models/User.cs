using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Cwk.TMW.Common.Types;
using Cwk.TMW.Core.Abstractions;

namespace Cwk.TMW.Core.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            Profiles = new List<IUserProfile>();
        }
        public string Address { get; set; }
        public Name Name { get; set; }
        public ICollection<IUserProfile> Profiles { get; set; }
    }
}
