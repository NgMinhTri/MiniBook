using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MiniBook.Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBook.Identity.Data
{
    public class MiniBookDbContext : IdentityDbContext<User>
    {      

        public MiniBookDbContext(DbContextOptions<MiniBookDbContext> options) : base(options)
        {

        }

       
    }
}
