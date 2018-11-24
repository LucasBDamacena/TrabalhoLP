using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasMedicas.Model
{
    [Table("Paciente")]
    public class Paciente
    {
        [Key]
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Nascimento { get; set; }
        public long Altura { get; set; }
        public float Peso { get; set; }
        public string Sexo { get; set; }
    }
}
