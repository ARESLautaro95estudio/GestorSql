using Entidades;
namespace Formularios_sql_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeerTabla_Click(object sender, EventArgs e)
        {
            if (this.validarbtnLT())
            {
                this.rtbInfo.Text = GestorSql.LeerTablaCompleta(this.txtTabla.Text);
            }
            else
            {
                MessageBox.Show("Debe completar el campo TABLA.");
            }
        }
        private bool validarbtnLT()
        {
            return this.txtTabla.Text != null && this.txtTabla.Text != string.Empty;
        }
        private bool validarbtnBD()
        {
            return this.validarbtnLT() && this.txtDato.Text != null && this.txtColumna != null
                && this.txtDato.Text != string.Empty && this.txtColumna.Text != string.Empty;
        }

        private void btnBuscarDato_Click(object sender, EventArgs e)
        {
            if (this.validarbtnBD())
            {
                this.rtbInfo.Text = GestorSql.BuscarDato(this.txtTabla.Text, this.txtColumna.Text, this.txtDato.Text);
            }
            else
            {
                MessageBox.Show("Debe completar los campos requeridos.");
            }
        }

        private void btnCargarDato_Click(object sender, EventArgs e)
        {
            if (this.validarbtnLT())
            {
                FormularioDeCarga form = new FormularioDeCarga(this.txtTabla.Text);
                form.Show();
            }
            else
            {
                MessageBox.Show("Ingrese el nombre de la tabla.");
            }
        }

        private void btnModificarFila_Click(object sender, EventArgs e)
        {
            if (this.validarbtnLT())
            {
                FormularioDeModificacion form = new FormularioDeModificacion(this.txtTabla.Text);
                form.Show();
            }
            else
            {
                MessageBox.Show("Ingrese el nombre de la tabla.");
            }
        }

        private void btnCrearTablaNueva_Click(object sender, EventArgs e)
        {
            FormularioCrearNuevaTabla formcnt = new FormularioCrearNuevaTabla();
            formcnt.Show();
        }
    }
}