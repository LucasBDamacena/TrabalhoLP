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
    public partial class CaixaDePesquisa : Form
    {
        public CaixaDePesquisa()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaControl consultaControl = new ConsultaControl();
                DadosConsulta consulta = consultaControl.PesquisarConsultaPorId(txtId.Text);
                FinalizarConsulta finalizarConsulta = new FinalizarConsulta(consulta);               
                finalizarConsulta.Show();
                Close();
            }
            catch
            {
                MessageBox.Show("A ID informada não foi encontrada. Tente novamente.");
            }
            
            
        }
    }
}
