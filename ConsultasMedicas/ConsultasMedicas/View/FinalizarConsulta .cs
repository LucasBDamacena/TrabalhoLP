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
    public partial class FinalizarConsulta : Form
    {

        public DadosConsulta dados = new DadosConsulta();

        public FinalizarConsulta(DadosConsulta dados)
        {
            InitializeComponent();
            this.dados = dados;
        }

        private void FinalizarConsulta_Load(object sender, EventArgs e)
        {
            txtPaciente.Text = dados.Paciente.Nome;
            txtMedico.Text = dados.Medico.Nome;
            txtData.Text = dados.Data;
            txtDescricao.Text = dados.Descricao;            
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            ConsultaControl consultaControl = new ConsultaControl();
            if(consultaControl.FinalizarConsulta(dados.Id, txtResultado.Text))
            {
                MessageBox.Show("Consulta finalizada com sucesso.");
                Close();
            }
            else
            {
                MessageBox.Show("Falha ao finalizar a consulta.");
            }

        }
    }
}
