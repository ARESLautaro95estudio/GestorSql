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
    public partial class FormularioCrearNuevaTabla : Form
    {

        private StringBuilder aux;
        public FormularioCrearNuevaTabla()
        {
            InitializeComponent();
            aux = new StringBuilder();
        }

        private void FormularioCrearNuevaTabla_Load(object sender, EventArgs e)
        {
            this.cmbTipoDeDato.Items.Add("INT");
            this.cmbTipoDeDato.Items.Add("BIGINT");
            this.cmbTipoDeDato.Items.Add("TINYINT");
            this.cmbTipoDeDato.Items.Add("SMALLINT");
            this.cmbTipoDeDato.Items.Add("FLOAT");
            this.cmbTipoDeDato.Items.Add("DOUBLE");
            this.cmbTipoDeDato.Items.Add("DECIMAL");
            this.cmbTipoDeDato.Items.Add("CHAR");
            this.cmbTipoDeDato.Items.Add("VARCHAR (50)");
            this.cmbTipoDeDato.Items.Add("TEXT");
            this.cmbTipoDeDato.Items.Add("DATE");
            this.cmbTipoDeDato.Items.Add("TIME");
            this.cmbTipoDeDato.Items.Add("DATETIME");
            this.cmbTipoDeDato.Items.Add("TIMESTAMP");
            this.cmbTipoDeDato.Items.Add("BLOB");
            this.cmbTipoDeDato.Items.Add("BIT");
            this.cmbTipoDeDato.Items.Add("BOOLEAN");
            this.cmbTipoDeDato.Items.Add("BOOL");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.aux.AppendLine(this.txtColumnas.Text + this.cmbTipoDeDato.SelectedItem.ToString() + ",");
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.aux.AppendLine(this.txtColumnas.Text + " "+this.cmbTipoDeDato.SelectedItem.ToString() );
            string auxQuery = $"CREATE TABLE {this.txtTabla.Text} ({this.aux.ToString()})";
            GestorSql.CrearTabla(auxQuery);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.aux.Clear();
            this.Close();
        }
    }
}
