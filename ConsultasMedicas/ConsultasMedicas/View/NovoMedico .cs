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
    public partial class NovoMedico : Form
    {
        public NovoMedico()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.Nome = txtNome.Text;
            medico.Sexo = cbSexo.Text;
            medico.Especialidade = txtEspecialidade.Text;

            MedicoControl medicoControl = new MedicoControl();
            if (medicoControl.Adicionar(medico))
            {
                Close();
                MessageBox.Show("Médico cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Dados inválidos, revise-os!");
            }

        }
    }
}
