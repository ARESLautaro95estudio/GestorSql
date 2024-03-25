namespace Formularios_sql_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtbInfo = new RichTextBox();
            lblTabla = new Label();
            lblColumna = new Label();
            lblDato = new Label();
            txtTabla = new TextBox();
            txtColumna = new TextBox();
            txtDato = new TextBox();
            btnLeerTabla = new Button();
            btnBuscarDato = new Button();
            btnCargarDato = new Button();
            btnModificarFila = new Button();
            btnCrearTablaNueva = new Button();
            SuspendLayout();
            // 
            // rtbInfo
            // 
            rtbInfo.Location = new Point(12, 103);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.ReadOnly = true;
            rtbInfo.Size = new Size(682, 335);
            rtbInfo.TabIndex = 0;
            rtbInfo.Text = "";
            // 
            // lblTabla
            // 
            lblTabla.AutoSize = true;
            lblTabla.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTabla.Location = new Point(12, 24);
            lblTabla.Name = "lblTabla";
            lblTabla.Size = new Size(54, 21);
            lblTabla.TabIndex = 1;
            lblTabla.Text = "TABLA";
            // 
            // lblColumna
            // 
            lblColumna.AutoSize = true;
            lblColumna.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblColumna.Location = new Point(247, 24);
            lblColumna.Name = "lblColumna";
            lblColumna.Size = new Size(87, 21);
            lblColumna.TabIndex = 2;
            lblColumna.Text = "COLUMNA";
            // 
            // lblDato
            // 
            lblDato.AutoSize = true;
            lblDato.Location = new Point(488, 24);
            lblDato.Name = "lblDato";
            lblDato.Size = new Size(36, 15);
            lblDato.TabIndex = 3;
            lblDato.Text = "DATO";
            // 
            // txtTabla
            // 
            txtTabla.Location = new Point(11, 58);
            txtTabla.Name = "txtTabla";
            txtTabla.Size = new Size(166, 23);
            txtTabla.TabIndex = 4;
            // 
            // txtColumna
            // 
            txtColumna.Location = new Point(247, 58);
            txtColumna.Name = "txtColumna";
            txtColumna.Size = new Size(166, 23);
            txtColumna.TabIndex = 5;
            // 
            // txtDato
            // 
            txtDato.Location = new Point(488, 58);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(166, 23);
            txtDato.TabIndex = 6;
            // 
            // btnLeerTabla
            // 
            btnLeerTabla.Location = new Point(706, 26);
            btnLeerTabla.Name = "btnLeerTabla";
            btnLeerTabla.Size = new Size(82, 55);
            btnLeerTabla.TabIndex = 7;
            btnLeerTabla.Text = "Leer tabla completa";
            btnLeerTabla.UseVisualStyleBackColor = true;
            btnLeerTabla.Click += btnLeerTabla_Click;
            // 
            // btnBuscarDato
            // 
            btnBuscarDato.Location = new Point(706, 103);
            btnBuscarDato.Name = "btnBuscarDato";
            btnBuscarDato.Size = new Size(82, 55);
            btnBuscarDato.TabIndex = 8;
            btnBuscarDato.Text = "Buscar dato";
            btnBuscarDato.UseVisualStyleBackColor = true;
            btnBuscarDato.Click += btnBuscarDato_Click;
            // 
            // btnCargarDato
            // 
            btnCargarDato.Location = new Point(706, 179);
            btnCargarDato.Name = "btnCargarDato";
            btnCargarDato.Size = new Size(82, 55);
            btnCargarDato.TabIndex = 9;
            btnCargarDato.Text = "Cargar dato";
            btnCargarDato.UseVisualStyleBackColor = true;
            btnCargarDato.Click += btnCargarDato_Click;
            // 
            // btnModificarFila
            // 
            btnModificarFila.Location = new Point(706, 254);
            btnModificarFila.Name = "btnModificarFila";
            btnModificarFila.Size = new Size(82, 55);
            btnModificarFila.TabIndex = 10;
            btnModificarFila.Text = "Modificar fila";
            btnModificarFila.UseVisualStyleBackColor = true;
            btnModificarFila.Click += btnModificarFila_Click;
            // 
            // btnCrearTablaNueva
            // 
            btnCrearTablaNueva.Location = new Point(706, 334);
            btnCrearTablaNueva.Name = "btnCrearTablaNueva";
            btnCrearTablaNueva.Size = new Size(82, 55);
            btnCrearTablaNueva.TabIndex = 11;
            btnCrearTablaNueva.Text = "Crear tabla nueva";
            btnCrearTablaNueva.UseVisualStyleBackColor = true;
            btnCrearTablaNueva.Click += btnCrearTablaNueva_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrearTablaNueva);
            Controls.Add(btnModificarFila);
            Controls.Add(btnCargarDato);
            Controls.Add(btnBuscarDato);
            Controls.Add(btnLeerTabla);
            Controls.Add(txtDato);
            Controls.Add(txtColumna);
            Controls.Add(txtTabla);
            Controls.Add(lblDato);
            Controls.Add(lblColumna);
            Controls.Add(lblTabla);
            Controls.Add(rtbInfo);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbInfo;
        private Label lblTabla;
        private Label lblColumna;
        private Label lblDato;
        private TextBox txtTabla;
        private TextBox txtColumna;
        private TextBox txtDato;
        private Button btnLeerTabla;
        private Button btnBuscarDato;
        private Button btnCargarDato;
        private Button btnModificarFila;
        private Button btnCrearTablaNueva;
    }
}