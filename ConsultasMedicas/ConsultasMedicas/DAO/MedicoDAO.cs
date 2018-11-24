using ConsultasMedicas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasMedicas.DAO
{
    class MedicoDAO
    {

        public void Adicionar(Medico m)
        {
            using (var contexto = new EfContext())
            {      
                contexto.Medico.Add(m);
                contexto.SaveChanges();
            }
        }

        public List<Medico> Listar()
        {
            List<Medico> pacientes;
            using (var contexto = new EfContext())
            {
                pacientes = contexto.Medico.ToList();
            }
            return pacientes;
        }

        public Medico RetornarMedico(string nome)
        {
            Medico medico;
            using (var contexto = new EfContext())
            {
                medico = contexto.Medico.Where(x => x.Nome == nome).FirstOrDefault();
            }
            return medico;
        }

        public Medico PesquisarPorId(long id)
        {
            Medico m;
            using (var contexto = new EfContext())
            {
                try
                {
                    m = contexto.Medico.Where(x => x.Id == id).FirstOrDefault();
                    return m;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
