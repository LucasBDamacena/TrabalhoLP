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
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void btnAtendente_Click(object sender, EventArgs e)
        {
            new MenuAtendente().Show();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            new LoginMedico().Show();
        }
    }
}
