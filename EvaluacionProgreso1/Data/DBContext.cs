using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EvaluacionProgreso1.Models;
using EvaluacionProgreso.Models;

namespace EvaluacionProgreso.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<EvaluacionProgreso1.Models.Carrera> Carrera { get; set; } = default!;
        public DbSet<EvaluacionProgreso.Models.Guaman> Guaman { get; set; } = default!;
    }
}
