﻿using ConsultasMedicas.Control;
using ConsultasMedicas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultasMedicas.View
{
    public partial class ListaConsultasMedico : Form
    {
        public Medico Medico { get; set; }
        public string Estado { get; set; }
        public ListaConsultasMedico(Medico m, string estado)
        {
            InitializeComponent();
            Estado = estado;
            Medico = m;
        }

        private void ListaConsultasMedico_Load(object sender, EventArgs e)
        {
            Carregar();
        }

        public void Carregar()
        {
            ConsultaControl consultaControl = new ConsultaControl();
            dataGridView1.DataSource = consultaControl.CarregarListaConsulta(Estado, Medico);
            dataGridView1.Refresh();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            new CaixaDePesquisa().Show();
            Close();
        }
    }
}
