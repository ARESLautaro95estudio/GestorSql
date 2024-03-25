namespace Formularios_sql_
{
    partial class FormularioCrearNuevaTabla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSiguiente = new Button();
            btnCancelar = new Button();
            btnTerminar = new Button();
            txtColumnas = new TextBox();
            lblColumna = new Label();
            cmbTipoDeDato = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtTabla = new TextBox();
            SuspendLayout();
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(12, 237);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(82, 66);
            btnSiguiente.TabIndex = 0;
            btnSiguiente.Text = "SIGUIENTE";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(100, 237);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 66);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnTerminar
            // 
            btnTerminar.Location = new Point(184, 237);
            btnTerminar.Name = "btnTerminar";
            btnTerminar.Size = new Size(82, 66);
            btnTerminar.TabIndex = 2;
            btnTerminar.Text = "TERMINAR";
            btnTerminar.UseVisualStyleBackColor = true;
            btnTerminar.Click += btnTerminar_Click;
            // 
            // txtColumnas
            // 
            txtColumnas.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtColumnas.Location = new Point(12, 117);
            txtColumnas.Name = "txtColumnas";
            txtColumnas.Size = new Size(250, 31);
            txtColumnas.TabIndex = 3;
            // 
            // lblColumna
            // 
            lblColumna.AutoSize = true;
            lblColumna.Location = new Point(53, 86);
            lblColumna.Name = "lblColumna";
            lblColumna.Size = new Size(129, 15);
            lblColumna.TabIndex = 4;
            lblColumna.Text = "Nombre de la columna";
            // 
            // cmbTipoDeDato
            // 
            cmbTipoDeDato.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoDeDato.FormattingEnabled = true;
            cmbTipoDeDato.Location = new Point(12, 200);
            cmbTipoDeDato.Name = "cmbTipoDeDato";
            cmbTipoDeDato.Size = new Size(250, 31);
            cmbTipoDeDato.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 167);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 6;
            label1.Text = "Seleccione el tipo de dato";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 9);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre de la tabla";
            // 
            // txtTabla
            // 
            txtTabla.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtTabla.Location = new Point(12, 38);
            txtTabla.Name = "txtTabla";
            txtTabla.Size = new Size(250, 31);
            txtTabla.TabIndex = 8;
            // 
            // FormularioCrearNuevaTabla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 314);
            Controls.Add(txtTabla);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbTipoDeDato);
            Controls.Add(lblColumna);
            Controls.Add(txtColumnas);
            Controls.Add(btnTerminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnSiguiente);
            Name = "FormularioCrearNuevaTabla";
            Text = "FormularioCrearNuevaTabla";
            Load += FormularioCrearNuevaTabla_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSiguiente;
        private Button btnCancelar;
        private Button btnTerminar;
        private TextBox txtColumnas;
        private Label lblColumna;
        private ComboBox cmbTipoDeDato;
        private Label label1;
        private Label label2;
        private TextBox txtTabla;
    }
}