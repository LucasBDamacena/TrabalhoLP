using ConsultasMedicas.Control;
using ConsultasMedicas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultasMedicas.View
{
    public partial class NovaConsulta : Form
    {
        public NovaConsulta()
        {
            InitializeComponent();
            ConsultaControl c = new ConsultaControl();
            
            foreach (Paciente p in c.ListarPacientes())
            {
                cbPaciente.Items.Add(p.Nome);
            }

            foreach (Medico m in c.ListarMedicos())
            {
                cbPaciente.Items.Add(m.Nome);
            }
        }

        private void btnNovoPaciente_Click(object sender, EventArgs e)
        {           
            new NovoPaciente().Show();
        }

        private void btnNovoMedico_Click(object sender, EventArgs e)
        {
            new NovoMedico().Show();
        }

        private void cbPaciente_Click(object sender, EventArgs e)
        {
            cbPaciente.Items.Clear();
            ConsultaControl c = new ConsultaControl();

            foreach (Paciente p in c.ListarPacientes())
            {
                cbPaciente.Items.Add(p.Nome);
            }
        }

        private void cbMedico_Click(object sender, EventArgs e)
        {
            cbMedico.Items.Clear();
            ConsultaControl c = new ConsultaControl();

            foreach (Medico p in c.ListarMedicos())
            {
                cbMedico.Items.Add(p.Nome);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {            
            Consulta consulta = new Consulta();
            consulta.Descricao = txtDescricao.Text;
            consulta.DataConsulta = mtxtData.Text;
            consulta.Estado = "ABERTA";
            string horarioAtual = DateTime.Now.ToString();
            horarioAtual = horarioAtual.Remove(horarioAtual.Length-2);
            consulta.DataRegistro = horarioAtual;

            if (cbPaciente.Text != "" || cbMedico.Text != "")
            {
                PacienteControl pacienteControl = new PacienteControl();
                consulta.Paciente = pacienteControl.RetornarPaciente(cbPaciente.Text).Id;

                MedicoControl medicoControl = new MedicoControl();
                consulta.Medico = medicoControl.RetornarMedico(cbMedico.Text).Id;

                ConsultaControl consultaControl = new ConsultaControl();
                if (consultaControl.Adicionar(consulta))
                {
                    //Close();
                    MessageBox.Show("Consulta cadastrada com sucesso!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Insira todos os dados solicitados!");
                }
            }           
            else
            {
                MessageBox.Show("Insira todos os dados solicitados!");
            }
            
            
           
        }
    }
}
