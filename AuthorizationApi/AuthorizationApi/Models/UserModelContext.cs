using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationApi.Models
{
    public class UserModelContext : DbContext
    {
        public UserModelContext(DbContextOptions<UserModelContext> options) : base(options)
        {
        }
        public DbSet<UserModel> Users { get; set; }
    }
}
