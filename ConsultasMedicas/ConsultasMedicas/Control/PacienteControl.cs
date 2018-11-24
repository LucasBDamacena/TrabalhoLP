using ConsultasMedicas.DAO;
using ConsultasMedicas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasMedicas.Control
{
    class PacienteControl
    {
        public bool Adicionar(Paciente p)
        {
            if (p.Nome != "" && p.Peso.ToString() != ""&& p.Altura.ToString() != "" && p.Sexo != "" && p.Nascimento != "  /  /")
            {
                PacienteDAO pacienteDAO = new PacienteDAO();
                pacienteDAO.Adicionar(p);
                return true;
            }
            return false;
        }
        public Paciente RetornarPaciente(string nome)
        {
            PacienteDAO pacienteDAO = new PacienteDAO();          
            return pacienteDAO.RetornarPaciente(nome);
        }

        
    }
}
