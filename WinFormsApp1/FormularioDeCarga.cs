using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormularioDeCarga : Form
    {
        private List<string> listaLabels, dataNueva;
        private string tabla;
        private int conteo;
        public string Tabla { get => tabla; set => tabla = value; }
        public FormularioDeCarga(string tabla)
        {
            InitializeComponent();
            Tabla = tabla;
        }
        private void ArmadoDeFormulario()
        {
            this.richTextBox1.Text = GestorSql.Instrucciones(Tabla);
        }
        private void btnCarga_Click(object sender, EventArgs e)
        {
            GestorSql.Carga(this.txtQUERY.Text);
        }
        private void FormularioDeCarga_Load(object sender, EventArgs e)
        {
            this.ArmadoDeFormulario();
            this.txtQUERY.Text = "INSERT INTO people VALUES ()";
            
        }
    }
}