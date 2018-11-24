using ConsultasMedicas.DAO;
using ConsultasMedicas.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultasMedicas
{
    public partial class MenuAtendente : Form
    {
        public MenuAtendente()
        {
            InitializeComponent();
        }
               

        private void btnConsultasRealizadas_Click(object sender, EventArgs e)
        {
            new ListaConsultas(null, "FINALIZADA").Show();
        }

        private void btnNovaConsulta_Click(object sender, EventArgs e)
        {
            new NovaConsulta().Show();
        }

        private void btnConsultasAbertas_Click(object sender, EventArgs e)
        {
            new ListaConsultas(null, "ABERTA").Show();
        }
    }
}
