using CNPJ_MODELS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPJ_Persistence.Contexto
{
    public class CnpjApiContext : DbContext
    {
        public CnpjApiContext(DbContextOptions<CnpjApiContext> options) : base(options) { }

        public DbSet <Root> Cnpj { get; set; }
        public DbSet<CnaesSecundario> CnaesSecundario { get; set; }
        public DbSet<Qsa> QuadroSocieatario { get; set; }

    }
}
