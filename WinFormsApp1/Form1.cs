using Entidades;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnLT_Click(object sender, EventArgs e)
        {
            if (this.validarbtnLT())
            {
                this.richTextBox1.Text = GestorSql.LeerTablaCompleta(this.txtbTABLA.Text);
            }
            else
            {
                MessageBox.Show("Debe completar el campo TABLA.");
            }

        }
        private bool validarbtnLT()
        {
            return this.txtbTABLA.Text != null && this.txtbTABLA.Text != string.Empty;
        }


        private void btnBD_Click(object sender, EventArgs e)
        {
            if (this.validarbtnBD())
            {
                this.richTextBox1.Text = GestorSql.BuscarDato(this.txtbTABLA.Text, this.txtbColumna.Text, this.txtbDATO.Text);
            }
            else
            {
                MessageBox.Show("Debe completar los campos requeridos.");
            }
        }
        private bool validarbtnBD()
        {
            return this.validarbtnLT() && this.txtbDATO.Text != null && this.txtbColumna != null
                && this.txtbDATO.Text != string.Empty && this.txtbColumna.Text != string.Empty;
        }

        private void txtbCarga_Click(object sender, EventArgs e)
        {
            if (this.validarbtnLT())
            {
                FormularioDeCarga form = new FormularioDeCarga(this.txtbTABLA.Text);
                form.Show();
            }
            else
            {
                MessageBox.Show("Ingrese el nombre de la tabla.");
            }
        }

        private void btnMD_Click(object sender, EventArgs e)
        {
            if (this.validarbtnLT())
            {
                FormularioDeModificacion form = new FormularioDeModificacion(this.txtbTABLA.Text);
                form.Show();
            }
            else
            {
                MessageBox.Show("Ingrese el nombre de la tabla.");
            }
        }
    }
}