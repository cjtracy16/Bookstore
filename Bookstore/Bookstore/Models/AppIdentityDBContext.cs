using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class AppIdentityDBContext : IdentityDbContext<IdentityUser>
    {
        //Set up constructor with options
        public AppIdentityDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}
