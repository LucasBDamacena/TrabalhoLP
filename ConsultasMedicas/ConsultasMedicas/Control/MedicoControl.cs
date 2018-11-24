using ConsultasMedicas.DAO;
using ConsultasMedicas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasMedicas.Control
{
    class MedicoControl
    {
        public bool Adicionar(Medico m) {
            if (m.Nome != "" && m.Sexo != "" && m.Especialidade != "")
            {
                MedicoDAO medicoDAO = new MedicoDAO();
                medicoDAO.Adicionar(m);
                return true;
            }
            return false;
        }

        public Medico RetornarMedico(string nome)
        {
            MedicoDAO medicoDAO = new MedicoDAO();
            return medicoDAO.RetornarMedico(nome);
        }

        
    }
}
