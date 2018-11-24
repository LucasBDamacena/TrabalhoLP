using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasMedicas.Model
{
    [Table("Medico")]
    public class Medico
    {
        [Key]
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }
        public string Sexo { get; set; }
    }
}
