using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios_sql_
{
    public partial class FormularioDeCarga : Form
    {
        private string tabla;
        public string Tabla { get => this.tabla; set => this.tabla = value; }
        public FormularioDeCarga(string tabla)
        {
            InitializeComponent();
            this.Tabla = tabla;
        }
        private void ArmadoDeFormulario()
        {
            this.rtbCarga.Text = GestorSql.Instrucciones(Tabla);
        }
       
        private void FormularioDeCarga_Load(object sender, EventArgs e)
        {
            this.ArmadoDeFormulario();
            this.txtQUERY.Text = $"INSERT INTO {Tabla} VALUES ()";

        }

        private void btnCarga_Click_1(object sender, EventArgs e)
        {
            GestorSql.Carga(this.txtQUERY.Text);
        }
    }
}
