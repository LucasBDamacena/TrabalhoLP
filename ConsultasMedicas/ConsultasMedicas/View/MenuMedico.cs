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
    public partial class MenuMedico : Form
    {
        public Medico MedicoLogado { get; set; }

        public MenuMedico()
        {
            InitializeComponent();
            
        }

        private void MenuMedico_Load(object sender, EventArgs e)
        {
            labelMedico.Text = $"Bem vindo, {MedicoLogado.Nome}!";
        }

        private void btnConsultasAbertas_Click(object sender, EventArgs e)
        {
            new ListaConsultasMedico(MedicoLogado, "ABERTA").Show();
        }

        private void btnConsultasRealizadas_Click(object sender, EventArgs e)
        {
            new ListaConsultas(MedicoLogado, "FINALIZADA").Show();
        }
    }
}
