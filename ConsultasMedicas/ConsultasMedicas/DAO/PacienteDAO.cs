using ConsultasMedicas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultasMedicas.DAO
{
    public class PacienteDAO
    {
        public void Adicionar(Paciente p) {
            using (var contexto = new EfContext())
            {
                contexto.Paciente.Add(p);
                contexto.SaveChanges();
            }
        }

        public List<Paciente> Listar()
        {
            List<Paciente> pacientes;
            using (var contexto = new EfContext())
            {
                pacientes = contexto.Paciente.ToList();
            }
            return pacientes;
        }

        public Paciente RetornarPaciente(string nome)
        {
            Paciente paciente;
            using (var contexto = new EfContext())
            {
                paciente = contexto.Paciente.Where(x => x.Nome == nome).FirstOrDefault();                
            }
            return paciente;
        }
        public Paciente PesquisarPorId(long id)
        {
            Paciente p;
            using (var contexto = new EfContext())
            {
                try
                {
                    p = contexto.Paciente.Where(x => x.Id == id).FirstOrDefault();
                    return p;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
