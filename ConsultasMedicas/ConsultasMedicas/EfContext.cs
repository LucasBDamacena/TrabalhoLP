using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ConsultasMedicas.Model;

namespace ConsultasMedicas
{
    public class EfContext : DbContext
    {        
        public System.Data.Entity.DbSet<Paciente> Paciente { get; set; }
        public System.Data.Entity.DbSet<Medico> Medico { get; set; }
        public System.Data.Entity.DbSet<Consulta> Consulta { get; set; }
    }
}
