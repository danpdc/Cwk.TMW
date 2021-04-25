using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Cwk.TMW.Core.Models
{
    public class User : IdentityUser
    {
        public string Address { get; set; }
    }
}
