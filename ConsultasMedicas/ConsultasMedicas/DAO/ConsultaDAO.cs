using ConsultasMedicas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultasMedicas.DAO
{
    class ConsultaDAO
    {
        public void Adicionar(Consulta c)
        {
            using (var contexto = new EfContext())
            {
                contexto.Consulta.Add(c);
                contexto.SaveChanges();
            }
        }

        public Consulta PesquisarPorId(long id)
        {
            Consulta c;
            using (var contexto = new EfContext())
            {
                try
                {
                    c = contexto.Consulta.Where(x => x.Id == id).FirstOrDefault();
                    return c;
                }
                catch(Exception e)
                {                   
                    throw new Exception();
                }
            }
        }

        public bool FinalizarConsulta(long id, string resultado)
        {
            using (var contexto = new EfContext())
            {
                try
                {
                    Consulta c = contexto.Consulta.SingleOrDefault(x => x.Id == id);
                    c.Resultado = resultado;
                    c.Estado = "FINALIZADA";
                    contexto.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
