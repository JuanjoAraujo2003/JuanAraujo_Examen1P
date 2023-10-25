using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JuanAraujo_Examen1P.Models;

namespace JuanAraujo_Examen1P.Data
{
    public class JuanAraujo_Examen1PContext : DbContext
    {
        public JuanAraujo_Examen1PContext (DbContextOptions<JuanAraujo_Examen1PContext> options)
            : base(options)
        {
        }

        public DbSet<JuanAraujo_Examen1P.Models.JuanAraujo_tabla> JuanAraujo_tabla { get; set; } = default!;
    }
}
