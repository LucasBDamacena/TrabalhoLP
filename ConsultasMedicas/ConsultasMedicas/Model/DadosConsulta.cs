using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasMedicas.Model
{
    public struct DadosConsulta
    {
        public long Id { get; set; }
        public Medico Medico { get; set; }
        public string Descricao { get; set; }
        public Paciente Paciente { get; set; }
        public string Data { get; set; }
    }
}
