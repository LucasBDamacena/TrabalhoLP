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
    public partial class NovoPaciente : Form
    {
        public NovoPaciente()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            try
            {
                paciente.Nome = txtNome.Text;
                paciente.Sexo = cbSexo.Text;
                paciente.Altura = int.Parse(txtAltura.Text);
                paciente.Peso = int.Parse(txtPeso.Text);
                paciente.Nascimento = mtxtNascimento.Text;
                PacienteControl pacienteControl = new PacienteControl();
                if (pacienteControl.Adicionar(paciente))
                {
                    Close();
                    MessageBox.Show("Paciente cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Informe valores válidos em todos os campos.");
                }
            }
            catch
            {
                MessageBox.Show("Informe valores válidos em todos os campos.");
            }

            
        }
    }
}
