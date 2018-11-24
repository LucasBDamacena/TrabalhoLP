using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasMedicas.Model
{
    [Table("Consulta")]
    public class Consulta
    {
        [Key]
        public long Id { get; set; }
        public long Paciente { get; set; }
        public long Medico { get; set; }
        public string Descricao { get; set; }
        public string DataRegistro { get; set; }
        public string DataConsulta { get; set; }
        public string Resultado { get; set; }
        public string Estado { get; set; }
    }    
}
