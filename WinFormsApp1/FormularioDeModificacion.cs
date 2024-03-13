using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace WinFormsApp1
{
    public partial class FormularioDeModificacion : Form
    {
        private string tabla;
        public FormularioDeModificacion(string tabla)
        {
            InitializeComponent();
            this.tabla = tabla;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GestorSql.modificarDatoDeTabla(this.txtColMod.Text,this.textDatoMod.Text
                ,this.txtColBus.Text,this.txtDatBus.Text,this.tabla));
        }
    }
}
