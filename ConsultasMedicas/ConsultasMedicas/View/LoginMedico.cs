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
    public partial class LoginMedico : Form
    {
        public LoginMedico()
        {
            InitializeComponent();

            ConsultaControl c = new ConsultaControl();
            foreach (Medico m in c.ListarMedicos())
            {
                cbMedico.Items.Add(m.Nome);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {           
            
            if(cbMedico.Text == "")
            {
                MessageBox.Show("Por favor, selecione o seu nome na lista acima.");
            }
            else
            {
                MedicoControl medicoControl = new MedicoControl();
                Medico m = medicoControl.RetornarMedico(cbMedico.Text);
                MenuMedico menuMedico = new MenuMedico();
                menuMedico.MedicoLogado = m;
                menuMedico.Show();
                Close();
            }
            
        }
    }
}
