using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebPiaget.Models;

namespace WebPiaget.Data
{
    public class WebPiagetContext : DbContext
    {
        public WebPiagetContext (DbContextOptions<WebPiagetContext> options)
            : base(options)
        {
        }

        public DbSet<WebPiaget.Models.Aluno> Aluno { get; set; } = default!;
    }
}
