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
    public partial class FormularioDeModificacion : Form
    {
        private string tabla;
        public string Tabla { get => this.tabla; set => this.Tabla = value; }
        public FormularioDeModificacion(string tabla)
        {
            InitializeComponent();
            this.Tabla = tabla;
        }

        private void FormularioDeModificacion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GestorSql.modificarDatoDeTabla(this.txtColMod.Text, this.textDatoMod.Text
               , this.txtColBus.Text, this.txtDatBus.Text, this.tabla));
        }
    }
}
