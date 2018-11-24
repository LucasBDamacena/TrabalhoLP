using ConsultasMedicas.DAO;
using ConsultasMedicas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultasMedicas.Control
{
    class ConsultaControl
    {
        public bool Adicionar(Consulta c)
        {           
            if (c.DataRegistro != "" && c.DataConsulta != "  /  /       :" && c.Descricao != "")
            {  
                ConsultaDAO consultaDAO = new ConsultaDAO();
                consultaDAO.Adicionar(c);
                return true;
            }
            return false;
        }
        public List<Paciente> ListarPacientes() {            
            PacienteDAO pacienteDAO = new PacienteDAO();            
            return pacienteDAO.Listar();
        }

        public List<Medico> ListarMedicos()
        {
            MedicoDAO medicoDAO = new MedicoDAO();
            return medicoDAO.Listar();
        }    
        
        public BindingSource CarregarListaConsulta(string estado, Medico medico)
        {
            using (var contexto = new EfContext())
            {
                BindingSource bs = new BindingSource();
                 var j1 = contexto.Consulta.Join(contexto.Paciente,
                     c => c.Paciente, p => p.Id, (c, p) => new { c, p }).Where(y => y.c.Estado == estado);
                 var j2 = j1.Join(contexto.Medico,
                     cc => cc.c.Medico, m => m.Id, (cc, m) => new { cc, m });
              
                if (medico != null)
                {
                    j2 = j2.Where(x => x.m.Nome == medico.Nome);
                }
                
                if(estado == "ABERTA")
                {
                    bs.DataSource = j2.Select(x => new
                    {
                        Id = x.cc.c.Id,
                        Paciente = x.cc.p.Nome,
                        Medico = x.m.Nome,
                        Data = x.cc.c.DataConsulta,
                        Descricao = x.cc.c.Descricao
                    }).ToList();
                }
                else
                {
                    bs.DataSource = j2.Select(x => new
                    {
                        Id = x.cc.c.Id,
                        Paciente = x.cc.p.Nome,
                        Medico = x.m.Nome,
                        Data = x.cc.c.DataConsulta,
                        Descricao = x.cc.c.Descricao,
                        Resultado = x.cc.c.Resultado
                    }).ToList();
                }
               
                
                return bs;
            }
        }

        public DadosConsulta PesquisarConsultaPorId(string id)
        {
            try
            {
                ConsultaDAO consultaDAO = new ConsultaDAO();
                Consulta c = consultaDAO.PesquisarPorId(long.Parse(id));

                DadosConsulta dadosConsulta = new DadosConsulta();
                MedicoDAO medicoDAO = new MedicoDAO();
                PacienteDAO pacienteDAO = new PacienteDAO();
                Paciente p = pacienteDAO.PesquisarPorId(c.Paciente);
                Medico m = medicoDAO.PesquisarPorId(c.Medico);


                dadosConsulta.Medico = m;
                dadosConsulta.Paciente = p;
                dadosConsulta.Descricao = c.Descricao;
                dadosConsulta.Data = c.DataConsulta;
                dadosConsulta.Id = c.Id;
                return dadosConsulta;
            }
            catch(Exception e)
            {
                throw new Exception();
            }            
        }

        public bool FinalizarConsulta(long id, string resultado)
        {
            ConsultaDAO consultaDAO = new ConsultaDAO();
            bool resul = consultaDAO.FinalizarConsulta(id, resultado);
            return resul;
        }
    }
}
